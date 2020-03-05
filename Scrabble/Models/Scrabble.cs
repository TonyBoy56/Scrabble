using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {
    public string MyWord;

    private static Dictionary<int, char[]> letters = new Dictionary<int, char[]>();

    public Word(string aWord)
    {
      MyWord = aWord;
    letters.Add( 1, new char[]{'a', 'e','i','o','u','l', 'n','r','s','t'} );
    letters.Add( 2, new char[]{'d','g'} );
    letters.Add( 3, new char[]{'b','c','m','p'} );
    letters.Add( 4, new char[]{'f','h','v','w','y'} );
    letters.Add( 5, new char[]{'k'} );
    letters.Add( 8, new char[]{'j','x'} );
    letters.Add( 10, new char[]{'q','z'} );
    }
    
    public char[] BreakToArray()
    {
      // int wordValue = 0;
      char[] inputWord = MyWord.ToCharArray();
      return inputWord;
     }
  }
}