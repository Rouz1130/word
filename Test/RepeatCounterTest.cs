using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter
{
  public class RepeatCounterTest
  {
      [Fact]
      public void Test1_RepeatCounterGetA_true()
      {
        //arrange
        string word = "a";
        RepeatCounter checkNewWord = new RepeatCounter(word,"");

        //act.....
        string checkWord = checkNewWord.GetWord();

        //Assert
        Assert.Equal(word, checkWord);

        // Test2_RepeatCounterGetThe_true()
      //



      }
  }
}
