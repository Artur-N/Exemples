// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел
int[] A = new int[10];
Console.WriteLine("Массив <А>: ");
for (int i = 0; i < A.Length; i++)
{
    A[i] = new Random().Next(10, 100);
    Console.Write(A[i] + " ");
}

// решение через метод

// void arrA(int[] A)
// {
//         for (int i = 0; i < A.Length; i++)
//     {
//         A[i] = new Random().Next(10, 100);
//     }
// }

// void Print(int[] A)
// {
//     for (int pos = 0; pos < A.Length; pos++)
//     {
//         Console.Write(A[pos] + " ");
//     }
// }

// arrA(A);
// Print(A);

Console.WriteLine();
Console.WriteLine();

// Создать масив B, отбрасывая те, которые нарушают порядок возрастания
Console.WriteLine("Задача 1: Убрать числа, нарушающие порядок возрастания. ");
int[] B = new int[A.Length];
B[0] = A[0];
Console.Write(B[0] + " ");
int max = B[0];
for (int i = 1; i < A.Length; i++)
{
    if (A[i] > max)
    {
        max = A[i];
        B[i] = max;
        Console.Write(B[i] + " ");
    }
}
Console.WriteLine();

// отбрасить те, которые больше среднего арифметического элементов A
double sum(int[] A)
{
    double s = 0;
    double mid = 0;
    for (int i = 0; i < A.Length; i++)
    {
        s = A[i] + s;
    }
    mid = s / A.Length;
    return mid;
}
double f = sum(A);

Console.WriteLine();

Console.WriteLine("Задача 2: Убрать все числа, которые больше среднеарифметического.");
Console.WriteLine("Среднее арифметическое массива <A> " + (f));

// решение через метод

// void arrB(int[] A)
// {
//         for (int i = 0; i < A.Length; i++)
//     {
//         if (A[i] <= f)
//         {
//             B[i] = A[i];
//             Console.Write(B[i] + " ");
//         }
//     }
// }
// arrB(A);

// решение линейное

for (int i = 0; i < A.Length; i++)
{
    if (A[i] < f)
    {
        B[i] = A[i];
        Console.Write(B[i] + " ");
    }
}

Console.WriteLine();

// отбросить чётные

Console.WriteLine();

Console.WriteLine("Задача 3: Убрать все чётные: ");

for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 2 != 0)
    {
        B[i] = A[i];
        Console.Write(B[i] + " ");
    }
}

// решение через метод

// void C(int[] A)
// {
//     for (int i = 0; i < A.Length; i++)
//     {
//         if (A[i] % 2 != 0)
//         {
//             B[i] = A[i];
//             Console.Write(A[i] + " ");
//         }
//     }
// }
// C(A);
