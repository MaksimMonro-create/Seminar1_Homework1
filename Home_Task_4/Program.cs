// ВЫЯСНИТЬ, ЯВЛЯЕТСЯ ЛИ ЧИСЛО ЧЕТНЫМ

Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int result = number%2;

if(result == 0)
{
    Console.WriteLine("Число четное");
}
    else
    {
        Console.WriteLine("Число нечетное");
    }