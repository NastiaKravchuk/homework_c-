int [] creatArray(int size, int maxValue, int minValue)

    {
        int [] array = new int[size];

        Random random = new Random();

        for (int i =0; i<array.Length; i++)
        {
            array[i]=random.Next(maxValue, minValue);
        }
        return array;
    }

int GetSum(int []array)
{
int sum=0;
{for (int i =0; i<array.Length; i++)
if(array[i]%2!=0)
sum=array[i]+sum;
}
return sum;
}
string GetArray(int[] array)
    {
    string sum = string.Empty;
    for (int i =0; i<array.Length; i++)

    {
        sum=sum + $"{array[i]}, "; 
    
    }
    return sum;
    }

    int[] array = creatArray(6,1,4);

Console.WriteLine(GetArray(array));
Console.WriteLine(GetSum(array));
