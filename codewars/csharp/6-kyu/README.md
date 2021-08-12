# \_6_kyu

Kata - https://www.codewars.com/kata/53d6387b83db278202000802/train/csharp

You have an array of numbers 1 through n (where 1 <= n <= 10). The array needs to be formatted correctly for the person reading the countdown of a spaceship launch.

Unfortunately, the person reading the countdown only knows how to read strings. After the array is sorted correctly make sure it's in a format he can understand.

Between each number should be a space and after the final number (n) should be the word 'liftoff!'

Example:

Kata.Liftoff(new List<int> {2, 8, 10, 9, 1, 3, 4, 7, 6, 5}) => "10 9 8 7 6 5 4 3 2 1 liftoff!"

P - We have an array of number 1 through n (where 1 <= n <= 10), but the array could be unsorted. In order for the person reading the array, they need the array sorted in descending order and converted to a list. During the sort, the reader needs the integers to be displayed with a space between the numbers and include the word 'Liftoff!'.

E - Kata.Liftoff(new List<int> {2, 8, 10, 9, 1, 3, 4, 7, 6, 5}) => "10 9 8 7 6 5 4 3 2 1 liftoff!"

Kata.Liftoff(new List<int> {2, 10, 9, 1, 7, 6, 5}) => "10 9 7 6 5 2 1 liftoff!"

Kata.Liftoff(new List<int> {}) => "liftoff!"

D - Array of integers converted to List and sorted.

A -
