// ДАНО ЧИСЛО ИЗ ОТРЕЗКА [10, 99]. ПОКАЗАТЬ НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА.

int number = new Random().Next(10, 99);
Console.WriteLine(number);
int number1 = number %10;
int number2 = number - number1;
int number3 = number2 / 10;
//int number4 = number3 - number2;
if (number3 > number1)
{
    Console.Write("Максимальное число цифры = ");
    Console.WriteLine(number3);
}
else
{
    Console.Write("Максимальное число цифры = ");
    Console.WriteLine(number1);
}