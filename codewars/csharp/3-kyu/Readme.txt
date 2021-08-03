Given an array of integers your solution should find the smallest integer.

For example:

Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.

P - Working with an array of integers, determine which is the smallest. 

E - The first integer in the array is the smallest, or one of the remaining integers in the array are the smallest

    Given [34, 15, 88, 2] your solution will return 2
    Given [34, -345, -1, 100] your solution will return -345

D - Array of integers 
    creating a loop to review integers

A - 

1. Assume that the first number is the smallest by taking the first integer of the array 
    as the lowest
2. Then review the second integer in the array and compare with the first integer - if smaller, record it. 
3. In a loop, review the next integer in the array and compare it with the smallest recorded integer - if smaller, record it.
4. Console.WriteLine displaying the lowest integer.

C -
values = new int[] { 34, 15, 88, 2  }; 

int lowestNumber [0];

if 

{
[0 ++] is > lowestNumber, update lowestNumber 
}

Console.WriteLine ("Lowest number is {lowestNumber}");
