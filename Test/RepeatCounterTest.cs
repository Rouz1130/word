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
        //act
        int result = checkNewWord.CountRepeats();

        //Assert
        Assert.Equal(1, result);
      }


        [Fact]
        public void Test2_LetterDontMatch_true()
      {
          //arrange
          RepeatCounter checkNewWord = new RepeatCounter("a", "b");
          //act
          int result = checkNewWord.CountRepeats();

          //Assert
          Assert.Equal(0, result);
      }


        [Fact]
        public void Test3_TwoWordsReturnNone_true()
      {
          //arrange
          RepeatCounter checkNewWord = new RepeatCounter("and", "the");

          //act
          int result = checkNewWord.CountRepeats();

          //Assert
          Assert.Equal(0, result);
       }


        [Fact]
        public void Test4_TwoWordsReturnNone_true()
      {
          //arrange
          RepeatCounter checkNewWord = new RepeatCounter("and", "and");

          //act
          int result = checkNewWord.CountRepeats();

          //Assert
          Assert.Equal(1, result);
      }

    }
}
