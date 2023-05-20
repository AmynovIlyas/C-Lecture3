// Задача на упорядовачивание данных внутри массива
// Алгоритм сортировки методом выбора = Выбором максимального/минимального

int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] arr1)
{
    int count = arr1.Length;
    for(int i = 0; i < count-1; i++)
    {
        Console.Write($"{arr1[i]}, ");
    } 
    Console.WriteLine($"{arr1[count-1]}");
    Console.WriteLine();
}

void SelectionSort(int[] arr2)
{
    for(int i = 0; i < arr2.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < arr2.Length; j++)
        {
            if (arr2[j] < arr2[minPosition])
            {
                minPosition = j;    
            }  
        }

        int temporary = arr2[i];
        arr2[i] = arr2[minPosition];
        arr2[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);
