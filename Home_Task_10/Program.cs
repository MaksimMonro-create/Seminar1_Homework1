// НАЙТИ ТРЕТЬЮ ЦИФРУ ЧИСЛА ИЛИ СООБЩИТЬ, ЧТО ЕЕ НЕТ

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
// string str = " ";
string str = Convert.ToString(number);
Console.WriteLine("Всего цифр в числе: " + str.Length);
if(str.Length < 3)
{
    Console.WriteLine("Во введенном числе нет третьей цифры!");
}
else 
{
Console.WriteLine($"Третья цифра числа равна {str[2]}");
}
