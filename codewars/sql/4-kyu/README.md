# \_4_kyu

Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

P - With a string that can contain any character, we need to determine whether it has the same amount of 'x's and 'o's. The evaluation method must return a boolean and be case insensitive for the characters in the string.

E -

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

D -

string of characters
return a boolean that is case insensitive

A -

Take the string and review contents for O and o, and X and x.
The review needs to not worry about the case of each letter in the string
If the quantity of X, x, O and/or o are ==, return a boolean of 'true'
If the quantity of X, x, O and/or o are !=, return a boolean of 'false'

C -
