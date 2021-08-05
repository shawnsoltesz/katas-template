Given an array of integers your solution should find the smallest integer.

For example:

Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.

P - Working with an array of integers, determine which is the smallest. 

E - Given [34, 15, 88, 2] your solution will return 2
    Given [34, -345, -1, 100] your solution will return -345

D - Array of integers
    Sort array of integers

A - 

1. Sort list of arrays
2. Identify the integer in index [0] position
3. Console.WriteLine displaying the lowest integer.

C -
values = new int[] { 34, 15, 88, 2 }; 

var values.Sort();

var lowestValue = values [0];

return lowestValue;
