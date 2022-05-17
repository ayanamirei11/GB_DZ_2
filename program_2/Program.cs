int ob(int a)
{
    int number1=a/100;
    //Console.WriteLine(number1);
    int number2=a%10;
    //Console.WriteLine(number2);
    return 10*number1+number2;
}

int randomNumber=new Random().Next(100,1000);
Console.WriteLine(randomNumber);
Console.WriteLine(ob(randomNumber));
