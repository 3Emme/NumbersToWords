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
      Dictionary<string, string> singlesDict = new Dictionary<string, string>() { {"1","one"},{"2","two"},{"3","three"},{"4","four"},{"5","five"},{"6","six"},{"7","seven"},{"8","eight"},{"9","nine"} };

      Console.WriteLine("numberString: "+numberString);
      if (singlesDict.TryGetValue(numberString, out string value))
      {
        result = value;
        Console.WriteLine("value: "+value);
      }
      else 
      {
        result = "I have no idea what you mean.";
      }
      Console.WriteLine("result: "+result);
      return result;
    }
  }
}