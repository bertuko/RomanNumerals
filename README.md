# RomanNumerals
Converts integers between 1 to 3999 to roman numerals

I created a static class with an int extension method, that way it can be used without instantiating anything. 

The solution uses a recursive function to return the roman numeral string. In the class I added a static IDictionary with the equivalencies from major to minor. A List or IEnumerable could have sufficed, however this way I made sure there is only one value per number. The advantages of using the dictionary like this is that it is loaded into memory just once.

The way I solved this is quite straightforward. Having the equivalencies list from major to minor, I can do a loop through them until the number is greater or equal than the value. That means I can write the corresponding letter/s. Therefore, I can subtract the value from the original value (since we already have that value) and call the same function until no value is found in that list.
