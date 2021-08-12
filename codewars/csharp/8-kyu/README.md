# \_8_kyu

You're at the zoo... all the meerkats look weird. Something has gone terribly wrong - someone has gone and switched their heads and tails around!

Save the animals by switching them back. You will be given an array which will have three values (tail, body, head). It is your job to re-arrange the array so that the animal is the right way round (head, body, tail).

Same goes for all the other arrays/lists that you will get in the tests: you have to change the element positions with the same exact logics

Simples!

P -

The zoo animals are incorrect - the heads and tails are switched around. To fix, take a given array with three values - tail, body and head and re-arrange so that order is head, body and tail.

E - Array - (tail, body, head) to be rearranged as (head, body, tail)

D - Array to be converted to a list

A -

Convert the array to a list
Reverse the list

C -

int[] array = { tail, body, head };
List<int> list = new List<int>(array);

List<string> meerkat = new List<string> { "Fred", "Wilma", "Barney" };
meerkat.Reverse();
