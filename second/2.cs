// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.WriteLine("Введите размер массива");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int sum = 0;

int[] array = new int[N];
for (int i = 0; i < N; ++i)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < N; ++i)
{
    System.Console.Write(array[i] + "\t");
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}

System.Console.WriteLine("-> " + sum);
