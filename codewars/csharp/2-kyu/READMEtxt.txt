Codewars:

Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.
You need to consider the following ratings:
Terrible: tip 0%
Poor: tip 5%
Good: tip 10%
Great: tip 15%
Excellent: tip 20%
The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:
"Rating not recognized" in Javascript, Python and Ruby...
...or null in Java
...or -1 in C#
Because you're a nice person, you always round up the tip, regardless of the service.

PEDAC:

P - 
Need to create a calculator to help determine the amount of a tip based on the amount of the bill and the percentage the customer deems appropriate based on the service received. Need to round up the tip once calculated. If there are cents in the calculation, round up to the next dollar. The rating is case sensitive, so if a customer does not provide a recognized rating, they receive a “Rating not recognized, please try again” message and must enter a valid rating to proceed.

E - 
Customer bill $20 and rated service TERRIBLE = $20 * .00 = $0 tip
Customer bill $20 and rated service POOR = $20 * .05 - $1 tip
Customer bill $20 and rated service GOOD = $20 * .10 = $2.00 tip
Customer bill $10 and rated service GREAT = $20 * .15 = $3.00 tip
Customer bill $45 and rated service EXCELLENT = $20 * .20 = $4.00 tip
Customer bill $38.78 rated service GOOD = $38.78 * .10 = $3.88 rounded up to $4.00


D - 

Case sensitive ratings need to be converted to all caps. Also the values of the associated tip are:

Terrible: tip 0% change to TERRIBLE: 0%
Poor: tip 5% change to POOR: 5%
Good: tip 10% change to GOOD: 10%
Great: tip 15% change to GREAT: 15%
Excellent: tip 20% change to EXCELLENT: 20%

Round up tip to next whole dollar amount

A - 

Obtain the total amount of bill and display
Present five options to customer to rate service:

- Terrible: tip 0% change to TERRIBLE: 0%
- Poor: tip 5% change to POOR: 5%
- Good: tip 10% change to GOOD: 10%
- Great: tip 15% change to GREAT: 15%
- Excellent: tip 20% change to EXCELLENT: 20%

Prompt customer to enter their ranking as a case sensitive Console.Read. Indicate that to the customer that the ratings are case sensitive

- TERRIBLE: 0%
- POOR: 5%
- GOOD: 10%
- GREAT: 15%
- EXCELLENT: 20%

If customer does not enter a recognized option, display this message: "Rating not recognized. Please try again and remember that ratings are case sensitive."

Once customer enters their rating, calculate the amount of the bill by multiplying the amount of the bill by the tip amount associated with the rating.

If the amount of the tip is not a whole dollar amount, round up to the next whole dollar amount.

C -

Obtain the total amount of bill and display
Present five options to customer to rate service:

*new Method = TipExplanation
Console.WriteLine ("TERRIBLE: 0% tip"); 
Console.WriteLine ("POOR: 5% tip");
Console.WriteLine ("GOOD: 10% tip");
Console.WriteLine ("GREAT: 15% tip");
Console.WriteLine ("EXCELLENT: 20% tip");

Console.WriteLine ("Please enter your rating to calculate your tip. Entries are case sensitive, and calculated tips will be rounded up to the nearest whole dollar amount.");
Console.Read ("var=Rating");

*Loop - 
If customer does not enter a recognized option, display this message: "Rating not recognized. Please try again and remember that ratings are case sensitive."

Once customer enters their rating, calculate the amount of the bill by multiplying the amount of the bill by the tip amount associated with the rating.

If the amount of the tip is not a whole dollar amount, round up to the next whole dollar amount.