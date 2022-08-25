
//ПОКАЗАТЬ ВТОРУЮ ЦИФРУ ТРЕХЗНАЧНОГО ЧИСЛА

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if(number >= 100 && number < 1000)
{
int number1 = number%100;
int number2 = number%10;
int number3 = number1 - number2;
int result = number3 / 10;
Console.Write("Вторая цифра трехзначного числа = ");
Console.WriteLine(result);
}
    else 
    {
        Console.WriteLine("Это число не является трехзначным!!!");
    }
