// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
int[] A = new int[20];
Console.WriteLine("Массив <А>: ");
// for (int i = 0; i < 20; i++)
// {
//     A[i] = new Random().Next(10, 100);
//     Console.Write(A[i] + " ");
// }

// Через метод
void arrA(int[] A2)
{
    int len = A2.Length;
    for (int i = 0; i < len; i++)
    {
        A2[i] = new Random().Next(10, 100);
    }
}

void Print(int[] A3)
{
    int count = A3.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(A3[pos] + " ");
    }
}

arrA(A);
Print(A);

Console.WriteLine();
Console.WriteLine();

// Создать масив B, отбрасывая те, которые нарушают порядок возрастания
Console.WriteLine("Массив <B>: ");
int[] B = new int[20];
B[0] = A[0];
Console.Write(B[0] + " ");
for (int i = 0; i < B.Length - 1; i++)
{
    if (A[i + 1] > A[i])
    {
        B[i] = A[i + 1];
        Console.Write(B[i] + " ");
    }
}
Console.WriteLine();
// отбрасить те, которые больше среднего арифметического элементов A

int sum(int[] A)
{
    int s = 0;
    int mid = 0;
    for (int i = 0; i < 20; i++)
    {
        s = A[i] + s;
    }
    mid = s / 20;
    return mid;
}
int f = sum(A);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое массива <A> - " + (f));

Console.WriteLine();
Console.WriteLine("Меньше среднего арифметического в массива <В> следующие цифры: ");
// решение через функцию
void arrB(int[] B2)
{
    int len = B2.Length;
    for (int i = 0; i < B2.Length; i++)
    {
        if (B2[i] < f & B2[i] > 0)
        {
            Console.Write(B2[i] + " ");
        }
    }
}
arrB(B);

    // for (int i = 0; i < B.Length; i++)
    // {
    //     if (B[i] < f & B[i] > 0)
    //     {
    //         Console.Write(B[i] + " ");
    //     }
    // }
    Console.WriteLine();

    // отбросить чётные
    
    Console.WriteLine();
    Console.Write("Оставшиеся нечётные массива <B>: ");
    for (int i = 0; i < B.Length; i++)
    {
        if (B[i] % 2 != 0)
        {
            Console.Write(B[i] + " ");
        }
    }

