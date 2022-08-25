// ПОКАЗАТЬ ЧЕТНЫЕ ЧИСЛА ОТ 1 ДО N

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int result = number1;

 if(number2 > number1)
{
    Console.WriteLine("Четные числа приведены ниже: ");
    
    for (result = number1;  result < number2; result++)
    {
        if (result%2 == 0)
        {
            Console.WriteLine(result);
        }
        
    }
}
else 
{
    Console.WriteLine("ВТОРОЕ ЧИСЛО ДОЛЖНО БЫТЬ БОЛЬШЕ ПЕРВОГО!!!");
}


