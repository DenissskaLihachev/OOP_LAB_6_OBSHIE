void QuickSort(int?[] arr, int begin, int end)
{
    if (end < 0)
        end = arr.Length - 1;
    if (begin >= end)
        return;
    int middleIndex = (end - begin) / 2 + begin, currentIndex = begin;
    Swap(arr, begin, middleIndex);
    for (int i = begin + 1; i <= end; ++i)
    {
        if (arr[i] >= arr[begin] || arr[i] == null)
        {
            currentIndex++;
            Swap(arr, currentIndex, i);
        }
    }
    Swap(arr, begin, currentIndex);
    QuickSort(arr, begin, currentIndex - 1);
    QuickSort(arr, currentIndex + 1, end);
}
void Swap(int?[] arr, int i, int j)
{
    (arr[j], arr[i]) = (arr[i], arr[j]);
}
void PrintNullable(int? number)
{
    if (number.HasValue)
    {
        
        Console.Write(number); // аналогично предыдущей строке
    }
    else
    {
        Console.Write("null");
    }
}

Random random = new Random();

int?[] mas = new int?[100];

Console.Write("Введите число от 1 до 100: "); int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    mas[i] = null;
    mas[new Random().Next(mas.Length)] = random.Next(mas.Length);
}

Console.Write("[ ");
for (int i = 0; i < mas.Length; i++)
{
    PrintNullable(mas[i]);
    Console.Write(" ");
}
Console.Write("]");

Console.ReadKey();

QuickSort(mas, 0, mas.Length - 1);
Array.Reverse(mas);

Console.Write("[ ");
for (int i = 0; i < mas.Length; i++)
{
    PrintNullable(mas[i]);
    Console.Write(" ");
}
Console.Write("]");