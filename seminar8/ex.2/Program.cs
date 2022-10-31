//поиск строки с наименьшим ср.арифметич.
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

int GetSearchMinSum (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row;
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
Console.WriteLine($"Строка с наименьшей суммой - {GetSearchMinSum(array)}");


