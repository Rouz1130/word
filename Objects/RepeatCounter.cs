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
      string[] splitSentence = this._sentence.ToLower().Split(' ');
      string newWord = this._word.Trim().ToLower();
      if (this._word == "")
      {
        return 0;
      }

      int count = 0;
      foreach (string word in splitSentence)
      {
        if (word == newWord)
      {
        count++;
      }

      }
        return count;

      }
    }
  }
