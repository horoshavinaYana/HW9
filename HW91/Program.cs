//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintPrevNaturalNumbers(int naturalnumber)
{
    if(naturalnumber > 1)
    {
        Console.Write($"{naturalnumber},");    
        naturalnumber--;
    }
    else
    {
        Console.Write($"{naturalnumber}");    
        return;
    };
    PrintPrevNaturalNumbers(naturalnumber);
}

int NaturalNumbers = GetIncomingData("Введите натуральное число");
PrintPrevNaturalNumbers( NaturalNumbers );