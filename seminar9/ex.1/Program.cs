Console.WriteLine("Введите число A");
int A= int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B= int.Parse(Console.ReadLine());

void GetNumbers(int A, int B)

{if (A==B)
{
    Console.Write(B);
return;}
else
{ 
   GetNumbers(A,B-1);
    Console.Write(B);
}}
GetNumbers(A,B);

