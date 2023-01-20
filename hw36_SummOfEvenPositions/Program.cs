            //Программа задёт одномерный массив случайных чисел и выводит сумму элементов массива,
            //стоящих на чётных позициях

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    var rnd = new Random();  

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} 

int SummOfEvenPositions(int[] array)
{
    int summ = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 == 0)
        {
            summ += array[i];
        }
    }

    return summ;
}

int len;

Console.Write("Введите размер массива: ");
len = int.Parse(Console.ReadLine()!);

int[] arr = CreateRandomArray(len, 0, 10);

PrintArray(arr);
Console.WriteLine(SummOfEvenPositions(arr));