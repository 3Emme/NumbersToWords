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
      Console.WriteLine("numberString: "+numberString);
      string result;      
      Dictionary<string, string> singlesDict = new Dictionary<string, string>() { {"1","one"},{"2","two"},{"3","three"},{"4","four"},{"5","five"},{"6","six"},{"7","seven"},{"8","eight"},{"9","nine"}, };

      Dictionary<string, string> doublesDict = new Dictionary<string, string>() { {"10","eleven"},{"11","eleven"},{"12","twelve"},{"13","thirteen"},{"14","fourteen"},{"15","fifteen"},{"16","sixteen"},{"17","seventeen"},{"18","eightteen"},{"19","nineteen"},{"20","twenty"} };

      //Dictionary<string, string> doublesDict = new Dictionary<string, string>

      char[] numberCharArray = numberString.ToCharArray();
      int arrayLength = numberCharArray.Length;
      if(arrayLength == 1)
      {
        string singleChar = Char.ToString(numberCharArray[0]);
        singlesDict.TryGetValue(singleChar, out string value);
        Console.WriteLine("single: "+value);
        result = value;
      }
      else if(arrayLength == 2)
      {
        if (Char.ToString(numberCharArray[0]) == "0") //SINGLES
        {
          string singleChar = Char.ToString(numberCharArray[0]);
          singlesDict.TryGetValue(singleChar, out string value);
          Console.WriteLine("single: "+value);
          result = value;
        }
        else if (Char.ToString(numberCharArray[0]) == "1") // TEENS
        {
        string firstChar = Char.ToString(numberCharArray[0]);
        string secondChar = Char.ToString(numberCharArray[1]);
        string doubleNum = firstChar+secondChar;
        doublesDict.TryGetValue(doubleNum, out string value);
        Console.WriteLine("double: "+value);
        result = value;
        }
        else // TENS
        {
          result = "I have no idea what you mean.";
        }
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