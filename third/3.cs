// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Введите размер массива");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);


float[] array = new float[N];
for (int i = 0; i < N; ++i)
{
    array[i] = new Random().Next(-100, 100);
}

float min = array[0];
float max = array[0];

for (int i = 0; i < N; ++i)
{
    System.Console.Write(array[i] + "\t");
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

System.Console.Write("-> " + (max - min));
