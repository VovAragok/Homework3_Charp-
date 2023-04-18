double p = 1; // начальное давление 
double v = 0.25; // объем в м^3

double t = (15 + 273) ; // начальная температура
double pMax = 1000; // максимально допустимое давление в Па

int resultTime = 0;

while (p < pMax)
{
    t  += 1;
    p = v*t;
    resultTime = resultTime+=1;
}
Console.WriteLine($"Сосуд лопнет через {resultTime} секунд.");

