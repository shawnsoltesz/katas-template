# \_5_kyu

**Codewar #1**

https://www.codewars.com/kata/585b1fafe08bae9988000314/train/csharp

Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.

P

Working with a string of digits 0-9, we need to return a new string that contains the same digits as the original string, but each digit must be repeated in its original sequence, but repeat the number of times that equals its value

E

Digits.Explode("312") = "333122"
Digits.Explode("102269") = "12222666666999999999"
Digits.Explode ("1") = "1"
Digits.Explode ("20304") = "223334444"
Digits.Explode ("0") =

D

String of numbers given as 'Digits.Explode'

A

Take the string of digits and isolate each to assess it individually and identify its value
Using a loop, repeat each number, with the exception of 0, the number of times that equals its value
Concatentate each of the individual strings into one new long string

C

---

**Codewar #2**

https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/train/csharp

This time no story, no theory. The examples below show you how to write function accum:

P

Write the function for 'accum' that takes each letter from a - z and/or A - Z, and repeat the number based on it's position in the string of given letters. However, the first letter in the return string, regardless of it's case in the given set, must appear in Capital letter, and each subsequent letter should be lower case. Additionally, the first letter has a count of 1, second letter has a count of 2, third letter has a count of 3, etc.
Return value

E

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of 'accum' is a string which includes only letters from a..z and A..Z.

D

String of letters given as 'accum'

A

Take given string of 'accum' and convert to lower to make all letters the same
use a loop to run through the string to output a new string of the letters, but given the position of the letter in the original string, repeat the letters as follows - first position = 1 letter, second position = 2 letters, third position = 3 letters, etc.
Convert the first letter in each mini string to upper case
Concatenate the mini strings of letters into one new long string
Return value

C
