Console.WriteLine("Введите число A");
int A= int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B= int.Parse(Console.ReadLine());

int GetNumbersSum(int A, int B)

{if (A==B)
{
    
 return B;}

else
{ 
   return GetNumbersSum(A,B-1)+B;}
   return B;};

GetNumbersSum(A,B);
Console.WriteLine(GetNumbersSum(A,B));