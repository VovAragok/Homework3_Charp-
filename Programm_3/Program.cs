
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube(int n)
{double result = 0;
for (int i = 1; (i <= n); i++)
{result = Math.Pow(i,3);
Console.WriteLine(result);
    
}}



void revisor()
{
    int number = 0;
    while (true)
    {
        Console.Write("Введите  число N ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            Console.WriteLine($"Кубы чисел от 1 до {number}");
            cube(number);
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}

revisor();
