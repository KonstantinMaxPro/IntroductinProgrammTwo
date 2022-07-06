int day = 6;

string WeekDays(int day)
{
    int numberDay = day - 1;
    string[] nameday = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    int count = 0;
    string weekDay = "";
    while(count < nameday.Length)
    {
        if(numberDay == count)
        {
            weekDay = nameday[count];
        }
        count++;
    }
    return weekDay;
}
void DayOff(int day){
    if(day == 6 || day == 7)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Выходной день"); 
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Будний день"); 
    }
    Console.ResetColor();
}


Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("       БУДНИЙ ИЛИ ВЫХОДНОЙ ДЕНЬ");//Название
Console.WriteLine("=======================================");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите число от 1 до 7: ");
/*Проверка ввода числа на int*/
while (!int.TryParse(Console.ReadLine(), out day))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите число от 1 до 7: ");
}
while (day > 7 || day < 1)//Проверка на лимит числа
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ ЧИСЛО НЕ ОТ 1 ДО 7\n");   
    Console.ResetColor();
    Console.Write("Введите число от 1 до 7: ");
    while (!int.TryParse(Console.ReadLine(), out day))
    {
        Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
        Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
        Console.ResetColor();
        Console.Write("Введите число от 1 до 7: ");
    }
}

Console.WriteLine("\n=======================================");
Console.WriteLine($"День {day} это: ");
Console.Write($"{WeekDays(day)} - ");
DayOff(day);
Console.WriteLine("=======================================");

