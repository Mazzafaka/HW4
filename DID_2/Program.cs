// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int result = SumOfDigits(number);
        Console.WriteLine($"Сумма цифр числа {number} равна {result}");
    }

    int SumOfDigits(int number)
    {
        int total = 0;
        foreach (char digitChar in number.ToString())
        {
            int digit = int.Parse(digitChar.ToString());
            total += digit;
        }
        return total;
    }


Main();