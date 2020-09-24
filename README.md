# _Numbers To Words!_

#### _Translate numeric values into written words!, 09/24/20_

#### By _**Emme Buentiempo & Ben Stoller**_

## Description

_Create a console app that translates numbers in numeric form into written words. For example, it would translate 384 into "three hundred eighty four". Use multiple dictionaries to solve this.

Start small, and then get your code working for numbers up to 1 trillion._

## Specs

* (1) if input is "1" then return "one"
  * input: "1"
  * output: "one"

* (2) If input is any number up to 9, return the name for the number
  * input: "9"
  * output: "nine"

* (3) Is input is in the "teens" return "eleven", "twelve" etc...
  * input: "14"
  * output: "fourteen"

* (4) If input is any number up to 99, return the name.
  * input: "85"
  * output: "eighty five"

* (5) If input is in the hundreds, return the single digit name followed by hundred.
  * input: "200"
  * output: "two hundred"

* (6) Combine specs 4 and 5 for more numbers in the hundreds
  * input "467"
  * output: "four hundred sixty seven"

* (7) If input is in the thousands, add "thousand" and incorperate specs 4-6 to display everything. 
  * input: "5,634"
  * output: "five thousand six hundred thirty four"

* (8) If number is in the "ten" (spec 3) or "hundred" (specs 4-6) "thousand"...
  * input: "134,000"
  * output: "one hundred thirty four thousand"
  * input: "16,000"
  * output: "sixteen thousand"
  
* (9) If input is in the millions, add "million" and incorperate specs 4-8 to display everything. 
  * input: "2,005,634"
  * output: "two million five thousand six hundred thirty four"

* (10) If input is in the billions, "ten" (spec 3) or "hundred" (specs 4-6) "billion".
  * input 256,000,000,000
  * output "two hundred six billion"

* (11) If input is in the trillions, add "trillion" and incorperate specs 4-10 to display everything. 
  * input: "5,003,002,005,634"
  * output: "five trillion three hundred billion two million five thousand six hundred thirty four"

## Setup/Installation Requirements


## Known Bugs

_

## Support and contact details



## Technologies Used

C#

### License

MIT License

Copyright (c) 2020 **_Ben Stoller & Emme Buentiempo_**

