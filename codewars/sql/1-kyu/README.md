# \_1_kyu

In your application, there is a section for adults only. You need to get a list of names and ages of users from the users table, who are 18 years old or older.

users table schema

name
age
NOTE: Your solution should use pure SQL. Ruby is used within the test cases just to validate your answer.

SQL for Beginners Series

This kata is part of a collection of SQL challenges for beginners. You can take the rest of the challenges here:

Adults only (SQL for Beginners #1)
On the Canadian Border (SQL for Beginners #2)
Register for the Party (SQL for Beginners #3)
Collect Tuition (SQL for Beginners #4)
Best-Selling Books (SQL for Beginners #5)
Countries Capitals for Trivia Night (SQL for Beginners #6)

P - An application contains "adult only" section that is intended for users over 18+ yrs old. The Users table contains the user ages - need to obtain a list of those users.

E -

Shawn, 44
Austin, 21
Lexi, 17

D -

String, Integer

A -

Filter the results of the tables so that only users who are >= 18 are returned

C -

SELECT \*
FROM USERS
WHERE age >= 18
