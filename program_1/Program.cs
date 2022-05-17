int secondNumber(int number)
{
    return number/10%10;
}
string str;
int a;
Console.WriteLine("Введите число");
str = Console.ReadLine();
a=int.Parse(str);
Console.WriteLine("вторая цифра числа "+a+": "+secondNumber(a));

