// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)


int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int [size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last+1);
    }

    return arr;
}

int[] RevertArray(int[] arr)
{
    int size = arr.Length;
    int[] revertArr = new int[size];
    for (int i = 0; i < size; i++)
    {
       revertArr[i] = arr[size - 1 -i];
    }
    return revertArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      System.Console.Write(arr[i]+ " ");  
    }
    System.Console.WriteLine();
}

int size = SetNumber("size");

int[] array = GetRandomArray(size, 0, 100);

int[] revertArray = RevertArray(array);

PrintArray(array);

PrintArray(revertArray);