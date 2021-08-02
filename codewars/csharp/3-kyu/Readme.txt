Given an array of integers your solution should find the smallest integer.

For example:

Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.

P - Working with two sets of arrays, determine which is the smallest integer. 
E - The first integer in the array is the smallest, or one of the remaining integers in the list are the smallest
D - Array of four integers and creating a loop to review the integers to sort and identify the smallest value 
Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345

A - 
1. Assume that the first number is the smallest. 
2. Then review the second integer in the array and compare with the remaining integers - if smaller, record it. 
3. Review the third integer in the array and compare it with the smallest recorded integer - if smaller, record it.
4. Review the fourth integer in the array and compare it with the smallest recorded integer - if smaller, record it.
5. Repeat process with second array of integers - 
6. Assume that the first number is the smallest. 
7. Then review the second integer in the array and compare with the remaining integers - if smaller, record it. 
8. Review the third integer in the array and compare it with the smallest recorded integer - if smaller, record it.
9. Review the fourth integer in the array and compare it with the smallest recorded integer - if smaller, record it.

C -

Problem 1

int[] array = { 34, 15, 88, 2 };
int max = array.Max();
int min = array.Min();

Problem 2

int[] array = { 34, -345, -1, 100 };
int max = array.Max();
int min = array.Min();
