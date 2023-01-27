            // Произведение пар чисел в одномерном массиве. Пара - первый
            //и последний элемент, второй и предпоследний и тд. ответ в новый массив.

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

int[] ProductOfPairsOfNums(int[] array)
{
    int product, len;
    int[] result;

    len = array.Length;

    if (len % 2 != 0)
    {
        result = new int[len / 2 + 1];
    }
    else
    {
        result = new int[len / 2];
    }
    
    for (int i = 0; i < len / 2; i++)
    {
        product = array[i] * array[len - i - 1];
        result[i] = product;
    }
    if (len % 2 != 0)
    {
        //Array.Resize(ref result, result.Length +1); // не стоит менять размер массива
        result[len / 2] = array [len / 2];
    }

    return result;
}

int len;
int[] arr;

Console.Write("Введите размер массива: ");
len = int.Parse(Console.ReadLine()!);

arr = CreateRandomArray(len, 0, 10);

PrintArray(arr);

PrintArray(ProductOfPairsOfNums(arr));