// НАЙТИ МАКСИМАЛЬНОЕ ИЗ ТРЕХ ЧИСЕЛ


Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > number1)
{
    max = number2;
    if (number2 > number3) 
    {
       max = number2; 
    }
    else 
    {
        max = number3;
    }
    
}
    else
    {
        max = number1;
        if (number1 > number3)
        {
            max = number1;
        }
        else
        {
            max = number3;
        }
    }



Console.Write("Максимальное число = ");
Console.WriteLine(max);


