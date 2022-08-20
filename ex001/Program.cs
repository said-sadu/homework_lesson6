Console.WriteLine("Введите элементы через пробел: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // не помню как изменить ошибку с Null в 
                                                                      // console readline
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов больше нуля: {count}");