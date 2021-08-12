# \_5_kyu

Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.

P -

E -

string: the dog ran after the rabbit and fell in a hole

Words:
the 3
dog 3
ran 3
after 5
the 3
rabbit 6
and 3
fell 4
in 2
a 1
hole 4

D - split the list of strings

A -

var words = s.split (" ")
var lengths = words.Select(word => word.Length)
