// ПО ДВУМ ЗАДАННЫМ ЧИСЛАМ ПРОВЕРИТЬ, ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ ЧИСЛО КВАДРАТОМ ВТОРОГО ЧИСЛА

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int result = number1 / number2;
if (result == number2)
{
    Console.WriteLine("Певое число является квадратом второго");
}
if (result != number2)
{
    Console.WriteLine("Первое число не является квадратом второго");
}