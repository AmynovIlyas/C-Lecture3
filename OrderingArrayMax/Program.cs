// Задача на упорядовачивание данных внутри массива (выюором максимального)

int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine();
}

void SelectionSold(int [] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] > arr[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}

PrintArray(array);
SelectionSold(array);
PrintArray(array);




