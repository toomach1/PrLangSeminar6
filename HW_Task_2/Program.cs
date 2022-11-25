// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

float SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    float num = int.Parse(Console.ReadLine());

    return num;
}

System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");

float numK1 = SetNumber("k1");
float numB1= SetNumber("b1");
float numK2 = SetNumber("k2");
float numB2 = SetNumber("b2");

float x = (numB2-numB1)/(numK1-numK2);

System.Console.WriteLine($"точка переcечения -> ({x},{numK1*x + numB1})");