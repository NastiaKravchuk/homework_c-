double [] creatArray(int size, double maxValue, double minValue)

    {
        double [] array = new double[size];

        Random random = new Random();

        for (int i =0; i<array.Length; i++)
        {
            array[i]=random.NextDouble();
        }
        return array;
    }

    double GetMax (double[] array)
    {
        double max=array[0];
        for (int i =0; i<array.Length; i++)
        if (array[i]>max)
        {
            max=array[i];
        }
        return max;

    }

double GetMin (double[] array)
    {
        double min=array[0];
        
        for (int i =0; i<array.Length; i++)
        if (array[i]<min)
        {
            min=array[i];
        }
        return min;

    }
string GetArray(double[] array)
    {
    string sum = string.Empty;
    for (int
     i =0; i<array.Length; i++)

    {
        sum=sum + $"{array[i]}, "; 
    
    }
    return sum;
    }

    double[] array = creatArray(10,1,74);

Console.WriteLine("Массив " + GetArray(array));
Console.WriteLine("Максимальное значение " + GetMax(array));
Console.WriteLine("Минимальное значение " + GetMin(array));
Console.WriteLine("Разница между max и min " + (GetMax(array)-GetMin(array)));