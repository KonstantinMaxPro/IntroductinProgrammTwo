int number;
// Первый вариант вывода второй цифры путем вычесления остатка
void PrintFirstDigit(int digit){
    while(digit >= 1000)
    {
        digit /= 10;
    }
    if(digit >= 100)
    {
        digit %= 10;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(digit);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Число меньше трёхзначного");
        Console.ResetColor();
    }
}
// Второй вариант вывода второй цифры путем конвертации toString и вывод третьего символа
void PrintFirstDigitStr(int digit){
    string numberString = Convert.ToString(digit);
    if(numberString.Length >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(numberString[2]);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Число меньше трёхзначного");
        Console.ResetColor();
    }
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("================================");
Console.WriteLine("ВЫВОД ТРЕТЬЕЙ ЦИФРЫ ЛЮБОГО ЧИСЛА");//Название
Console.WriteLine("================================");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите число: ");
}
Console.WriteLine("\n=======================================");
Console.WriteLine($"Вторая цифра в числе {number}: ");
//Вывод первого вариант решения
Console.Write("Первый метод: ");
PrintFirstDigit(number);
//Вывод второго варианта решения
Console.Write("Второй метод: ");
PrintFirstDigitStr(number);
Console.WriteLine("=======================================");

