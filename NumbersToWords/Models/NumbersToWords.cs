using System;
using System.Collections.Generic;

namespace NumbersToWords
{
  public class Translator
  {
    // public string NumberString { get; set; }
    // public void Translator(string numberString)
    // {
    //   NumberString = numberString;
    // }

    static public string NumberParser(string numberString)
    {
      string result;      
      // Dictionary<string, string> singlesDict = new Dictionary<string, string>() { {"1","one"} };
      // char[] numberArray = numberString.ToCharArray();
      // if (numberArray.length = 1)
      // {
      //   if
      // }
      if (numberString == "1")
      {
        result = "one";
      }
      else
      {
        result = "I have no idea what you mean.";
      }
      return result;
    }
  }
}