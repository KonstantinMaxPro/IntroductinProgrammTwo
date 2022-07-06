int number;
// Первый вариант вывода второй цифры путем вычесления остатка
int SecondDigit(int result)
{
    if(result > 100)
    {
        result /= 10; 
    }
    if(result > 10)
    {
        result %= 10;
    }
    return result;
}
// Второй вариант вывода второй цифры путем конвертации toString и вывод второго символа
void SecondDigitStr(int result)
{
    string digit = Convert.ToString(result);
    System.Console.WriteLine(digit[1]); 
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("ВЫВОД ВТОРОЙ ЦИФРЫ С ТРЕХЗНАЧНОГО ЧИСЛА");//Название
Console.WriteLine("=======================================");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите трёхзначное число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите трёхзначное число: ");
}
while (number > 999 || number < 100)//Проверка числа на трёхзначность
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ТРЁХЗНАЧНОЕ ЧИСЛО\n");   
    Console.ResetColor();
    Console.Write("Введите трёхзначное число: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
        Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
        Console.ResetColor();
        Console.Write("Введите трёхзначное число: ");
    }
}

Console.WriteLine("\n=======================================");
Console.WriteLine($"Вторая цифра в числе {number}: ");
Console.ForegroundColor = ConsoleColor.Yellow;
//Вывод первого вариант решения
Console.Write($"Первый метод: {SecondDigit(number)}\nВторой метод: ");
//Вывод второго варианта решения
SecondDigitStr(number);
Console.ResetColor();
Console.WriteLine("=======================================");