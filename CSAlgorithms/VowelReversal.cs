namespace DefaultNamespace;

public class VowelReversal
{
    public string ReverseVowels(string s)
    {
        int i = 0;
        string vowels = "";
        List<int> vowelIndexes = new List<int>();
        char[] charArray = s.ToCharArray();
        // loop through string
        while (i < s.Length)
        {
            // store vowels in list
            // store vowel indeces in a list
            if (IsVowel(s[i]))
            {
                vowels += s[i];
                vowelIndexes.Add(i);
            }

            i++;
        }

        i = 0;
        // loop through string again
        while (i < s.Length)
        {
            // place new vowels where they were reversed
            if (vowelIndexes.Contains(i))
            {
                charArray[i] = vowels[vowels.Length - 1];
                vowels = vowels.Substring(0, vowels.Length - 1);
            }

            i++;
        }
        
        return new string(charArray);
    }
    
    public string FasterReverseVowelsViaTwoPointers(string s)
    {
        char[] charArray = s.ToCharArray();
        
        int left = 0;
        int right = charArray.Length - 1;
        
        while (left < right)
        {
            while (left < right && !IsVowel(charArray[left]))
            {
                left++;
            }
            
            while (left < right && !IsVowel(charArray[right]))
            {
                right--;
            }
            
            if (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                
                left++;
                right--;
            }
        }
        
        return new string(charArray);
    }

    public bool IsVowel(char c)
    {
        char lowerC = char.ToLower(c);
        switch (lowerC)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
