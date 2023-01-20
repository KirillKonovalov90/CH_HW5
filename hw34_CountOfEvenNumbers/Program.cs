        //Программа принимает желаемый размер массива, создаёт массив состоящий
        //из случайных трёхзначных чисел и считает количество чётных чисел в данном массиве

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    var rnd = new Random();  // чтобы не возникало проблем с генерацией, лучше вынести в начало кода,
                             // дабы у одного и того же объекта брать элементы, а не создавать новый
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1); //+1 чтобы включить правую границу
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} 

int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int len;

Console.Write("Введите размер массива: ");
len = int.Parse(Console.ReadLine()!);

int[] arr = CreateRandomArray(len, 100, 999);

PrintArray(arr);

Console.WriteLine("Количество чётных элементов в массиве = " + CountEvenNumbers(arr));