// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
int[] A = new int[10];
int i = 0;
while (i < 10)
{
    A[i] = new Random().Next(10, 100);
    i++;
}
i = 0;
Console.WriteLine("Массив А");
while (i < 10)
{
    Console.Write(A[i] + " ");
    i++;
}
Console.WriteLine();

// Создать масив B, отбрасывая те, которые нарушают порядок возрастания
Console.WriteLine("Массив B");
int[] B = new int[10];
B[0] = A[0];
Console.Write(B[0] + " ");
i = 0;
while (i < 10)
{
    if (A[i + 1] > A[i])
    {
        B[i] = A[i + 1];
        Console.Write(B[i] + " ");
    }
    i++;
}

// отбрасить те, которые больше среднего арифметического элементов A

int sum(int[] A)
{
    i = 0;
    int s = 0;
    int mid = 0;
    while (i < 10)
    {
        s = A[i] + s;
        i++;
    }
    return s;
    mid = s / 10;
}
int f = sum(A);
Console.WriteLine(f);
