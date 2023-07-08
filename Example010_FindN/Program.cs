// Найти заданное число в массиве

int[] array = { 1, 12, 34, 656, 43, 86, 6, 57, 43, 76 };

int n = array.Length;
//System.Console.WriteLine(N);

int find = 43;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine($"Число {find} найдено, номер элемента массива - {index}");
        break;
    }
    index++;
}