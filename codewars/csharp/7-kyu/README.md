# \_7_kyu

The Collatz Conjecture states that for any natural number n, if n is even, divide it by 2. If n is odd, multiply it by 3 and add 1. If you repeat the process continuously for n, n will eventually reach 1.

For example, if n = 20, the resulting sequence will be:

[20, 10, 5, 16, 8, 4, 2, 1]

Write a program that will output the length of the Collatz Conjecture for any given n. In the example above, the output would be 8.

For more reading see: http://en.wikipedia.org/wiki/Collatz_conjecture

P - For any number, if it is even (divisible by 2), we can reduce the number down to 1. If a number is odd (not divisible by 2 without a remainder), we should multiply the number by 3 and add 1 to turn it into an even number. Then we can divide it by 2 to reduce the number to 1. If during the division we return an odd number, we should repeat the process of multiplying by 3 and adding 1 until we reach the number 1. We need to display the number sequence showing the journey for the given number to 1.

E -

n = 1, the resulting sequence will be:

[1, 4, 2, 1]

n = 3, the resulting sequence will be:

[3, 10, 5, 16, 8, 4, 2, 1]

n = 5, the resulting sequence will be:

[5, 16, 8, 4, 2, 1]

n = 7, the resulting sequence will be:

[7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1]

n = 9, the resulting sequence will be:

[28, 14, 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1]

n = 11, the resulting sequence will be:

[11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1]

n = 13, the resulting sequence will be:

[13, 40, 20, 10, 5, 16, 8, 4, 2, 1]

n = 15, the resulting sequence will be:

[15, 46, 23, 70, 35, 106, 53, 160, 80, 40, 20, 10, 5, 16, 8, 4, 2, 1]

n = 20, the resulting sequence will be:

[20, 10, 5, 16, 8, 4, 2, 1]

D - given an int, answer contains a list of the sequence numbers

A -
