﻿/* Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2 */

int[] posNum = new int[] {345,897,568,234,135,230,583,245,632,145};
int count = 0;

for (int i = 0; i < 10; i++)
{
    if (posNum[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine ("Количество четных элементов: {0}" , count);

