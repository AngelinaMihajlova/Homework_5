/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях */

int length = 4;
int[] array = new int[] {-4,-6,89,6};
int sum = 0;

for (int i = 1; i < length; i += 2)
{
    sum += array[i];
}

Console.WriteLine (sum);