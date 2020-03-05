using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{
  public class Word
  {
    public string MyWord;

    private static Dictionary<int, char[]> letterDictionary = new Dictionary<int, char[]>()
    {
      {1, new char[]{'a', 'e','i','o','u','l', 'n','r','s','t'},
      {2, new char[]{'d','g'}},
      {3, new char[]{'b','c','m','p'}},
      {4, new char[]{'f','h','v','w','y'}},
      {5, new char[]{'k'}},
      {8, new char[]{'j','x'}},
      {10, new char[]{'q','z'}}
    });

    public in CalcWordScore(string theirWord)
    {
      int[] theKeys = letterDictionary.Keys.ToArray();
      int totalScore = 0;
      for (int i = 0; i < theirWord.Length)
    }
    
    // public static char[] BreakToArray()
    // {
    //   // int wordValue = 0;
    //   char[] inputWord = MyWord.ToCharArray();
    //   return inputWord;
    // }

    // public int ReturnValue()
    // {
    //   int totalScore = 0;
    //   Word inputWord = new Word("a");
    //   char[] result = MyWord.ToCharArray();
    //   for (int i = 0; i < result.Length; i++);
    //   {
        
    //     if (letters.ContainsKey(element))
    //     {
    //      totalScore +=  
    //     }
    //   }
    //   return totalScore;
    // }
} 