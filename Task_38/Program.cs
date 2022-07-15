// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

double[] array = new double[5] {3.57, 35.5, 150, 96.2, 4};

double max = array[0];
double min = array[0];
double result;
   
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)  max = array[i];
    if (array[i] < min)  min = array[i];
} 

result = max - min;

Console.WriteLine (result);

