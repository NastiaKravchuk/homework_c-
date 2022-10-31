//Упорядосить массив по убыванию
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());



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

int[,] NewArray(int [,] array)
{int temp=0;
for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)
    {
        for (int a=0; a < array.GetLength(1)-1; a++)
    
    {
       if (array[i,a]<array[i,a+1])
       {  
temp=array[i,a+1];
array[i,a+1]= array[i,a];
array[i,a]=temp;
       }
       }
    }
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
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray(array));
