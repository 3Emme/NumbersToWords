using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumbersToWords;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersToWordsTests
  {
    [TestMethod]
    public void NumberParser_TranslateToOne_one()
    {      
      Assert.AreEqual("one",Translator.NumberParser("1"));
    }

    [TestMethod]
    public void NumberParser_Translate1through9_word()
    {
      Assert.AreEqual("five",Translator.NumberParser("5"));
    }

    [TestMethod]
    public void NumberParser_TranslateTeens_word()
    {
      Assert.AreEqual("thirteen",Translator.NumberParser("13"));
    }
  }
}