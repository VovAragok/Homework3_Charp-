// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void tuple()
{
    Console.WriteLine("Введите параметры точки А:");
    var A = (x: revisor(), y: revisor(), z: revisor());
    Console.WriteLine("Введите параметры точки B:");
    var B = (x: revisor(), y: revisor(), z: revisor());
    
    double distance = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2) + Math.Pow(A.z - B.z, 2));
    Console.WriteLine($"Расстояние между точками A({A.x}, {A.y}, {A.z}) и B({B.x}, {B.y}, {B.z}) равно: {distance}");
}

int revisor()
{
    int number;
    while (true)
    {
        Console.Write("Введите координату: ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}

tuple();







