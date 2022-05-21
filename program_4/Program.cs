void week(int day)
{
    day=day%7;
    if ((day==6)||(day==7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
string str;
int a;
Console.WriteLine("Введите число");
str = Console.ReadLine();
a=int.Parse(str);
week(a);
