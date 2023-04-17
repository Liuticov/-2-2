string CheckWeekdays(int weekdays)
{
    if (weekdays == 6 || weekdays == 7)
    {
        return "Да, это выходной";
    }
    else
    { 
        return "Нет, это не выходной";
    }
}
bool CheckNumber(int number)
{
    if (number <= 7 && number > 0 )
    {
        return true;
    }
    else
    { return false; }
}

Console.Write("Введите число: ");
int days_in_week = int.Parse(Console.ReadLine());

if (CheckNumber(days_in_week))
{
    Console.WriteLine(CheckWeekdays(days_in_week));
}
else
    Console.WriteLine("Неверно введенное число ");


