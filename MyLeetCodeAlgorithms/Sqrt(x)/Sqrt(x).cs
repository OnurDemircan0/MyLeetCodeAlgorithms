/* INSTRUCTIONS

Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
*/

/* Constraints:

0 <= x <= 2^31 - 1
*/

int x = 1658753294;

int MySqrt(int x)
{
    double approximateValue = x; //This is the approximate value of the square root of x.
    double halfValue = x / 2; //Increase or decrease the aproximate value by this.

    //If the square of approximate value is greater or less than x around 0.9, that means we found the approximate value.
    //The 0.9 value can be anything between 0 and 1. The closer to 1 will be faster, so I used 0.9
    while (!(approximateValue * approximateValue < x + 0.9 && approximateValue * approximateValue > x - 0.9))
    {
        //Decrease approximate value if the square of approximate value is greater than x + 0.9, otherwise increase it.
        if (approximateValue * approximateValue > x + 0.9)
        {
            approximateValue -= halfValue;
        }
        else
        {
            approximateValue += halfValue;
        }

        halfValue /= 2; //Every time get the half of the current value. This way it will find the approximate value quickly.
    }

    //Since we find the approximate value and not the exact square root of x, we have to check if the square root of x is an integer.
    if (Math.Ceiling(approximateValue) * Math.Ceiling(approximateValue) == x) return (int)Math.Ceiling(approximateValue);
    else return (int)approximateValue;
}

Console.WriteLine(MySqrt(x));