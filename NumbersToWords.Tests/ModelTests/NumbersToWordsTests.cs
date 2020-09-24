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
  }
}