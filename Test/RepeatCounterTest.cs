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

        RepeatCounter checkNewWord = new RepeatCounter("a", "a");

        int result = checkNewWord.CountRepeats();
        //act.....

        //Assert
        Assert.Equal(1, result);
        }
        //
        // [Fact]
        // public void Test2_LettersDontMatch_true()
        // {
        //   //arrange
        //
        //   RepeatCounter checkNewWord = new RepeatCounter("a", "b");
        //
        //   int result = checkNewWord.CountRepeats();
        //   //act.....
        //
        //   //Assert
        //   Assert.Equal(0, result);
        //
        // }
  }
}
