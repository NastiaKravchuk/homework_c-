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
void PrintArray2(double []array)
{
    
    for (int i=0; i < array.GetLength(0); i++)
{
    

Console.Write($"{array[i]}, ");}
Console.WriteLine();
}

int[,] array=GetArray(m,n);

double[] newArray= new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    newArray[i] = result / array.GetLength(0);
}


PrintArray2(newArray);
PrintArray(array);
