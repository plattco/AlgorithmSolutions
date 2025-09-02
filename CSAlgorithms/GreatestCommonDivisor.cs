/*
 * This program finds the greatest common divisor between two given strings. From LeetCode:
 * https://leetcode.com/problems/greatest-common-divisor-of-strings/?envType=study-plan-v2&envId=leetcode-75
 */
public class GreatestCommonDivisor {
    public string GcdOfStrings(string str1, string str2) 
    {
        int i = 0;
        string matching = "";

        while(i < str1.Length && i < str2.Length){
            if(str1[i] == str2[i]){
                matching += str1[i];
            }
            else{
                break;
            }
            i++;
        }

        for (int k = matching.Length; k > 0; k--)
        {
            string candidate = matching.Substring(0, k);
            if (IsDivisible(str1, candidate) && IsDivisible(str2, candidate))
            {
                return candidate;
            }
        }

        return "";
    }

    private bool IsDivisible(string s, string t)
    {
        if (t.Length == 0) return true;
        if (s.Length % t.Length != 0) return false;
        
        string reconstructed = "";
        for (int k = 0; k < s.Length / t.Length; k++)
        {
            reconstructed += t;
        }

        return s.Equals(reconstructed);
    }
}