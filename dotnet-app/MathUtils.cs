using System;

public class MathUtils
{
    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Le nombre doit être positif.");

        if (n <= 1)
            return 1;

        return n * Factorial(n - 1);
    }
}