# \_2_kyu

You are a border guard sitting on the Canadian border. You were given a list of travelers who have arrived at your gate today. You know that American, Mexican, and Canadian citizens don't need visas, so they can just continue their trips. You don't need to check their passports for visas! You only need to check the passports of citizens of all other countries!

Select names, and countries of origin of all the travelers, excluding anyone from Canada, Mexico, or The US.

travelers table schema

name
country
NOTE: The United States is written as 'USA' in the table.

NOTE: Your solution should use pure SQL. Ruby is used within the test cases just to validate your answer.

P -

At the Canadian border, we have tourists arriving. Tourists from the USA, Mexico and Canada do not need visas. With using SQL, you need to review the list of tourists to determine which tourists will their passports reviewed for a visa. Use Select names and countries of origin of all tourists to determine the list, and exclude anyone from the three countries that do not need a passport/visa.

E -

Shawn, USA - exclude
Jim, Ukraine - include
Sally, Mexico - exclude
Marsha, Australia - include
Heather, Canada - exclude
Mark, Ecuador - include

D -

Table with schema of Name and Country
Only use SQL for solution

A -

Determine through search query of the Travelers table

C -

SELECT "Country"
FROM "Travelers"
WHERE != 'USA', 'Canada', 'Mexico'

SELECT \*
FROM Travelers
WHERE Country <>'USA' and <>'Canada' and <>'Mexico'
