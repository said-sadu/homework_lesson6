Console.WriteLine("Введите элементы: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // не помню как изменить ошибку с Null в 
                                                                      // console readline, поэтому программа не всегда срабатывает
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}


Console.WriteLine($"Кол-во элементов больше нуля: {count}");