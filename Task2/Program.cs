/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);



Console.WriteLine($"{GetSumNumbers(M, N)} ");


int GetSumNumbers(int NumbM, int NumbN)
{
    if (NumbM == NumbN)
    {

        return NumbM;
    }
    else
    {
        return NumbM + GetSumNumbers(NumbM + 1, NumbN);
    }

    // SumNumbers = SumNumbers + (NumbM++);
    // GetSumNumbers(NumbM, NumbN, SumNumbers);
}
