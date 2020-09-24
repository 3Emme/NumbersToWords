using System;

namespace NumbersToWords
{
  public class Translator
  {
    public string NumberString { get; set; }
    public void WordNumber(string numberString)
    {
      NumberString = numberString;
    }

    public string NumberParser()
    {
      string result;
      result = "I have no idea what you mean.";
      return result;
    }
  }
}