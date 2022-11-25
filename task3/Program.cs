// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int num = SetNumber("десятичное число"); 
int size = 32;

bool[] array = new bool[size];

for (int i = 0; i < size; i++)
{
    array[size - i - 1] = num % 2 ==0? false: true;
    num/=2;
    if(num<0)
    {
        break;
    }
}

for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i]? 1: 0);
    
}    