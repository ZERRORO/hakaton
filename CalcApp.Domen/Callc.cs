﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcApp.Domen;
public class Calc
{

	// Метод для сложения двух чисел
	public static int Add(int a, int b)
	{
		return a + b;
	}
	public static int Substraction(int a, int b)
	{
		return a + b;
	}
<<<<<<< HEAD
	public static int factorial(int f)
	{
		int fact = 1;
		for (int i = 1; i <= f; i++)
		{
			fact = fact * i;
		}
		return fact;
=======
    public bool IsEven(int num)
    {
        return num % 2 == 0;
>>>>>>> 9b2021439e0b60ecfb8167722097668d8b24f7ae
	}
	// Метод для деления двух чисел
	public double Divide(int a, int b)
	{
		return a / b;
	}
	// Метод для проверки числа на простоту
	public static bool isPrime(int number)
	{
		if (number <= 1)
		{
			return false; // Числа меньше или равные 1 не являются простыми
		}
		for (int i = 2; i * i <= number; i++)
		{
			if (number % i == 0)
			{
				return false; // Число делится без остатка, значит, оно не простое
			}
		}
		return true; // Число простое
	}
}
