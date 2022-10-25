Console.WriteLine("Ведите значение b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите значение k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите значение b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите значение k2");
int k2 = int.Parse(Console.ReadLine());

double x= (b1-b2)/(k2-k1);
double y =(k1*x+b1);


Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(y);