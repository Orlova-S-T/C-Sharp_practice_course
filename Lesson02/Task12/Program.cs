﻿void Divisibility(int num1, int num2) //Параметры num1 и num2 проверяются на кратность num1:num2.
{
    int relation = num1 % num2;
    if (relation == 0) Console.WriteLine($"Число {num1} кратно числу {num2}");
    else Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток деления равен {Math.Abs(relation)}");
}

Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Divisibility(firstNumber, secondNumber);


