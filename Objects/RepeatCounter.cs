using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
{
    private string _word;
    private string _sentence;
    // private static List<RepeatCounter> _instances = new List<RepeatCounter> {} meaning a private in -Id
    // might have to put in a private in RepeatCounter?? try it out
    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }


    public void SetWord(string word)
    {
      _word = word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public int CountRepeats()
    {
      if (this._word == this._sentence)
      {
        return 1;
      }
      else
      {
        string[] mySentenceSplitAsArray = this._sentence.ToLower().Trim().Split(new string[]{" "}, StringSplitOptions.None);
        int countRepeats = 0;
        foreach(string word in mySentenceSplitAsArray)
        {
          if (word == _word)
          {
           countRepeats++;
          }


        }
        return countRepeats;
      }

      /*else
      {
        return 0;
      }*/

      //the blue jays rock the theater

      }
    }
  }
  //
  // string[] splitSentence = this._sentence.ToLower().Split(' ');
  // string newWord = this._word.ToLower();
  // if (this._word == this._sentence)
  // {
  //   return 0;
  // }
  //
  // int count = 0;
  // foreach (string word in splitSentence)
  // {
  //   if (word == newWord)
  // {
  //   count++;
  // }
  //
  // }
  //   return count;
