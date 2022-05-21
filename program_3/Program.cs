int pr(int a)
{
    if (a>999)
    {
        while (a>999)
        {
            a/=10;
        }
    }
    if ((a<999)&&(a>100))
    {
        return a%10;
    }
    else
    {
        return -1;
    }
}

string str;
int a,c;
Console.WriteLine("Введите число");
str = Console.ReadLine();
a=int.Parse(str);
c=pr(a);
if (c==-1)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    Console.WriteLine("третья цифра числа "+a+": "+c);
}