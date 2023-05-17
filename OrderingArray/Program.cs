// Задача на упорядовачивание данных внутри массива
// Алгоритм сортировки методом выбора = Выбором максимального/минимального

int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    } 
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = 1;
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }  
        }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);
