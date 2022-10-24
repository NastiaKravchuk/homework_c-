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

    int GetMax (int[] array)
    {
        int max=array[0];
        for (int i =0; i<array.Length; i++)
        if (array[i]>max)
        {
            max=array[i];
        }
        return max;

    }

int GetMin (int[] array)
    {
        int min=array[0];
        
        for (int i =0; i<array.Length; i++)
        if (array[i]<min)
        {
            min=array[i];
        }
        return min;

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

    int[] array = creatArray(10,1,74);

Console.WriteLine("Массив " + GetArray(array));
Console.WriteLine("Максимальное значение " + GetMax(array));
Console.WriteLine("Минимальное значение " + GetMin(array));
Console.WriteLine("Разница между max и min " + (GetMax(array)-GetMin(array)));