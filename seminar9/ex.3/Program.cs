
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());


int AckermannF (int M, int N)
{
    if (M == 0) 
    {return N + 1;
    }

    if  (M > 0 && N == 0) 
    {return AckermannF(M - 1, 1);
    }

    else
    {return AckermannF(M - 1, AckermannF(M, N - 1));
    }

}

Console.WriteLine(AckermannF(M, N));
