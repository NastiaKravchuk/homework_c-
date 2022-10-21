Console.WriteLine ("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
string str = a.ToString();
int [] array = new int [str.Length];


for (int i = 0; i < array.Length; i++)
{ array[i]=int.Parse(str[i].ToString());}

    if ( array[0]==array[4] && array[1]==array[3] )
    {
      Console.WriteLine("Tru");  
    }
    else
    {
        Console.WriteLine("False");
    }
