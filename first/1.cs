// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.WriteLine("Введите размер массива");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int A = 0;

int[] array = new int[N];
for (int i = 0; i < N; ++i)
{
    array[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < N; ++i)
{
    if (array[i] % 2 == 0)
    {
        A++;
    }
    System.Console.Write(array[i] + "\t");
}
System.Console.Write("-> " + A);