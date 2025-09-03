namespace DefaultNamespace;

public class WordsReversal
{
    public string ReverseWords(string s) 
    {
        // store a new string to begin reversal
		string reversed = "";
        // loop through the string, backwards
        // store a temp "word"
		string word = "";
		for (int i = (s.Length-1); i >= 0; i--)
		{
            if (s[i] == ' ')
            {
                if (word.Length > 0)
                {
                    reversed += ReverseWord(word) + " ";
                    word = "";
                }
            }
            else
            {
                word += s[i];
            }
		}
        // handle last word
        reversed += ReverseWord(word);
            
        // return words
		return reversed.Trim();
    }

    public string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}