// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int numA = SetNumber("A");

int numB = SetNumber("B");

int numC = SetNumber("C");

if (numA < numB + numC && numB < numA + numC && numC < numB + numA)
{
    System.Console.WriteLine("треугольник существует");
}
else
{
    System.Console.WriteLine("треугольник не существует");
}
