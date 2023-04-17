Console.WriteLine("Введите трехзначное число : ");
int a = int.Parse(Console.ReadLine());
int b = 0;

for (b = 0; (a < 100 || a > 999) && (b <= 9); b += 1)
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число ПОЖАЛУЙСТА : ");
    a = int.Parse(Console.ReadLine());
}
if (b <= 9)
{
    int first = a / 10;
    int second = first % 10;
    Console.Write("Вторая цифра в введенном числе: " + second);
}

else
{
    if (b == 10)
    {
        if (a < 100 || a > 999)
        {
            Console.WriteLine("Я СДАЮСЬ: ");
        }
        else
        {
            int first = a / 10;
            int second = first % 10;
            Console.Write("Вторая цифра в введенном числе: " + second);

        }

    }


}

