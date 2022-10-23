//цикл, который принимает на вход два числа (а и b ) и возводит число а в натуральную степень b
Console.WriteLine("Ведите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(GetRow(a, b));

int GetRow(int a, int b)
{
    int result = 1;
    for (int i=1; i<=b; i++)
{
    result = result*a;
}
return result;}

