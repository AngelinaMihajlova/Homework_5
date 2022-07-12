// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int Length = 4;
int[] Array = new int[4] {-4,-6,89,6};
int sum = 0;

for (int i = 1; i < Length; i += 2)
{
    sum = sum + Array[i];
}


Console.WriteLine (sum);