// Сортировки массива

int[] array = { 2, 4, 6, 9, 7, 4, 5, 1, 3 };

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Sort1(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

void Sort2(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }
}

PrintArr(array);
Sort1(array);
PrintArr(array);
Sort2(array);
PrintArr(array);



