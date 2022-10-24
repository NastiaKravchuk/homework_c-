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



int GetQuantity(int[] array)
{
    int count=0;
foreach( int element in array)
{if (element%2=0)
count++;
}
return count; 
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

int[] array =creatArray(10, 100, 1000);
Console.WriteLine(GetArray(array));
Console.WriteLine(GetQuantity(array));

