int number = new Random().Next(1,999);

Console.WriteLine(number);
int a = (number%10)%10;


if (number>99)
{
   Console.WriteLine(a);
}
else
{
   Console.WriteLine("Третьей цифры нет"); 
}

