Console.Write("Введите числа через пробел ");
string text = Console.ReadLine();
int[] array = Array.ConvertAll(text.Split(), int.Parse);


int GetCount(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
 {
  count++;
}
}
  return count;
}
Console.WriteLine($"Количество чисел больше 0 = " + (GetCount(array)));