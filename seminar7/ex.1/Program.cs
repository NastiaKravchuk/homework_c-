Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());



double[,] GetArray(int m,int n)
{
    double [,] array = new double[m,n];
Random random = new Random();

for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)

    array[i,j]=random.NextDouble();
}
return array;
}

void PrintArray(double [,]array)
{
    
    for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)
    {

Console.Write($"{array[i,j]}, ");}
Console.WriteLine();
}


}

PrintArray(GetArray(m,n));