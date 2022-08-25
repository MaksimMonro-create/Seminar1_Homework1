// УДАЛИТЕ ВТОРУЮ ЦИФРУ ТРЕХЗНАЧНОГО ЧИСЛА
int number = new Random().Next(100, 999);
Console.Write("Трехзначное число = ");
Console.WriteLine(number);
int number1 = number%100;
int number2 = number1%10;
int number3 = number1 - number2;
int number4 = number3 / 10;
int number5 = number - number1;
int number6 = number5 / 10;
int result = number6 + number2;
Console.Write("Новое число = ");
Console.WriteLine(result);
