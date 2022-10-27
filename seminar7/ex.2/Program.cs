Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int b = int.Parse(Console.ReadLine());


int[,] GetArray(int m,int n)
{
    int [,] array = new int[m,n];
Random random = new Random();

for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)

    array[i,j]=random.Next(1,10);
}
return array;
}




void PrintArray(int [,]array)
{
    
    for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)
    {

Console.Write($"{array[i,j]}, ");}
Console.WriteLine();
}


}
int[,] array=GetArray(m,n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
if (a < array.GetLength(0) && b < array.GetLength(1)) 
Console.WriteLine(array[a, b]);
else Console.WriteLine("Числа в массиве нет");

