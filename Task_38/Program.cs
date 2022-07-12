// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

    double[] Array = new double[5] {2, 35, 150, 96,4};

    double max = Array[0];
    double min = Array[0];
    double result = 0;
   
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) 
        {   max = Array[i];
        }

        if (Array[i] < min)
        {   min = Array[i];
        } 
    }
result = max - min;

Console.WriteLine (result);

