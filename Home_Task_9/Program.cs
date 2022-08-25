// ВЫЯСНИТЬ, КРАТНО ЛИ ЧИСЛО ЗАДАННОМУ, ЕСЛИ НЕТ, ТО ВЫВЕСТИ ОСТАТОК

Console.WriteLine("Введите любое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для проверки кратности");
int number2 = int.Parse(Console.ReadLine());
int number = number2%number1;
if(number==0 && number2 > number1)
{
    Console.Write("Число ");
    Console.Write(number2);
    Console.Write(" кратно ");
    Console.WriteLine(number1);
}
else 
{
    Console.Write("Число ");
    Console.Write(number2);
    Console.Write(" не кратно ");
    Console.WriteLine(number1);
    Console.Write("Остаток от деления равен ");
    Console.WriteLine(number);
}
