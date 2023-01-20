            //Программа принимает желаемый размер массива, создаёт массив вещественных чисел
            //и вычисляет разницу между наибольшим и наименьшим элементом массива

double[] CreateRandomArrayOfDoubles(int length, double minValue, double maxValue) //Чуть преобразовл для заполнения вещественными числами
{
    double[] array = new double[length];
    
    double randnew;
    var rnd = new Random();  

    for (int i = 0; i < array.Length; i++)
    {
        randnew = minValue + rnd.NextDouble() * (maxValue - minValue);
        array[i] = Math.Round(randnew, 2);       //Для читаемости округляем до 2 значащих после запятой
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} 

double[] MaxMinSubtraction (double[] array)
{
    double max, min, substr;
        
    max = array[0];
    min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    substr = max-min;
    double[] result = {max, min, substr};
    return result;
}

int len;
double[] res;

Console.Write("Введите размер массива: ");
len = int.Parse(Console.ReadLine()!);

double[] arr = CreateRandomArrayOfDoubles(len, -10, 10);

PrintArray(arr);

res = MaxMinSubtraction(arr);

Console.WriteLine($"Разница между наибольшим ({res[0]}) и наименьшим ({res[1]}) элементами массива = " + res[2]);