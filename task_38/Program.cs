// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива
// [3 7 22 2 78] -> 76


double[] GenerateManualArray()
{
    Console.Write("Введите элементы массива через пробел: ");
    string input = Console.ReadLine();
    string[] numbersString = input.Split(' ');
    double[] array = Array.ConvertAll(numbersString, double.Parse);
    return array;
}

double FindArrayDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    double difference = max - min;
    return difference;
}

double[] array = GenerateManualArray();
double difference = FindArrayDifference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом: {difference}");