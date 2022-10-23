//программа, которая принимает на вход число и выдает сумму цифр в числе
Console.WriteLine("Ведите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(GetSum(a));

int GetSum(int a)
{
   int sum=0;
   while (a!=0)
{
    int a1 = a%10;
    a = a/10;
    sum+=a1;
}
return sum;
}
