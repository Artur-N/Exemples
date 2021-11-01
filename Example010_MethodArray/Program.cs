int[] array = { 15, 2, 31, 43, 54, 26, 71, 18, 54 };

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

        index++;
}

