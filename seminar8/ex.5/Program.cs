



int n=4;
int[,] GetArray(int n)
{
    int [,] array = new int[n,n];
    int number=1;
for (int i=0; i < n/2; i++)
    {for (int j=0; j < n-i; j++)
    {array[i,j]=number++;}
    {for (int k=i+1; k < n-i; k++)
    {array[k,n-1-i]=number++;}
    {for (int j=n-i-2; j >i; j--)
    {array[n-1-i,j]=number++;}
    {for (int k=n-1-i; k > i; k--)
    {array[k,i]=number++;}
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
int[,] array=GetArray(n);


PrintArray(array);
Console.WriteLine();
