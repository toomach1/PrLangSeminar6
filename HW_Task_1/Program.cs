// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите числа");

string str = Console.ReadLine();
string[] strArr = str.Split(' ');

int count = 0;

int[] arr = new int[strArr.Length];

for (int i = 0; i < strArr.Length; i++)
{
    arr[i] = int.Parse(strArr[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0)
    {
        count++;
    }
}

System.Console.WriteLine($"количество чисел больше 0 = {count}");
