// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
int[] A = new int[5];
int i = 0;
while (i < 5)
{
    A[i] = new Random().Next(10, 20);
    i++;
}

i = 0;
while (i < 5)
{
    Console.Write(A[i] + " ");
    i++;
}
Console.WriteLine();

// Создать масив B, отбрасывая те, которые нарушают порядок возрастания
int[] B = new int[5];
int i2 = A[0];
i = 1;
Console.WriteLine(i2);
 
while (i < 5)
//{
//      if (i + 1 > i)
//    {
//
//    }
//    {
//        B
//    }
//else
//    { }
//    A[i + 1] > A[i]
