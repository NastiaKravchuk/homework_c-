//Умножение матрицы
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
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

int[,] GetArray2(int a,int b)
{
    int [,] array = new int[a,b];
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
int[,] array2=GetArray(a,b);
int [,] array3= new int[m,b];
if (m!=b)
{Console.WriteLine("Умножение не возможно ");
    return;}

    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
         {

            for (int k=0; k < array.GetLength(1); k++)
       
            { array3[i,j]=0;
    

        array3[i,j]+=array[i,k]*array2[k,j];
    }
        }}

PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(array3);
Console.WriteLine();


