using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcApp.Domen;
public class Calc
{

    // Метод для сложения двух чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int factorial(int f)
    {
        int fact = 1;
        for (int i = 1; i <= f; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}
