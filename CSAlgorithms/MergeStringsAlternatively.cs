/*
 * This program merges two strings together by adding the letters together in alternating order. From LeetCode:
 * https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75
 */
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        int j = 0;
        string combined = "";
        while(i < word1.Length && j < word2.Length){
            combined += word1[i];
            combined += word2[j];
            i++;
            j++;
        }

        if(word1.Length > i){
            combined += word1.Substring(i);
        }
        if(word2.Length > j){
            combined += word2.Substring(j);
        }
        return combined;
    }
}