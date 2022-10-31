

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine());




int[,,] GetArray(int m,int n, int k)
{
    int [,,] array = new int[m,n,k];
{
    int count = 3;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a< array.GetLength(2); a++)
            {
                array[ i, j, a] += count;
                count= count+4;
            }
        }
    }
}
      
           

return array;
    

}


int[,,] array=GetArray(m,n,k);   
void PrintArray(int [,,]array)
{
    
    for (int i=0; i < array.GetLength(0); i++)
{    for (int j=0; j < array.GetLength(1); j++)
    {for (int a=0; a < array.GetLength(2); a++)
    {

Console.Write($"{array[i,j,a]}, [{i} , {j}, {a} ] ");}
Console.WriteLine();
}}}
    
  
 
PrintArray(array);

/*int[,] array=new int[,]{{5,9,7,0,3,5,6,5,7,4},{5,9,7,0,3,5,6,5,7,4}};
int maxNumbers=array[0,0];
for  (int i=0; i <array.GetLength(0); i++)
{for (int j=0; j <array.GetLength(1); j++)

{
if (maxNumbers<array[i,j])
{maxNumbers=array[i,j];}}}

for   (int i=0; i <array.GetLength(0); i++)
{for  (int j=0; j <array.GetLength(1); j++)


{for  (int p=i+1; p <array.GetLength(0); p++)
{for  (int r=j+1; r <array.GetLength(1); r++)


{if (array[i,j]==array[i,r])
{maxNumbers=maxNumbers+1;
array[i,r]=maxNumbers;}}

{if (array[i,j]==array[p,j])
{maxNumbers=maxNumbers+1;
array[p,j]=maxNumbers;}}


}}}




 for (int i=0; i < array.GetLength(0); i++)
{    for (int j=0; j < array.GetLength(1); j++)
    

       {Console.Write($"{array[i,j]},");}
Console.WriteLine();}


*/