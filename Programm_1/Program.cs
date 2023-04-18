// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


 void palLid(int n)
{
    int number = n;
    int result = 0;
    while(number != 0)
    {
        int temp = number % 10;
        result = result * 10 + temp;
        number = number / 10;
    }

    if (n == result)
    {
        Console.WriteLine("Паллиндром");
    }
    else
    {
        Console.WriteLine("не Паллиндром");
    }
}

void revisor()
{
    int number = 0;
    while (true)
    {
        Console.Write("Введите пятизначное число  ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            palLid(number);
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}

revisor();