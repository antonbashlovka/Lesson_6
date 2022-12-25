/*
    Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

float inputNumber(string M){
    float i = 0;
    while (float.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }
    return i;
}

void fillArray(ref float[] arr, int n){

    string userInput = "";
    float userNumber = 0;

    for (int i = 0; i < n; i++)
    {
        userInput = Console.ReadLine()  ?? "неизвестное сообщение"; 
        userNumber = inputNumber(userInput);
        arr[i] = userNumber;
    }
}

Console.WriteLine("Найти точку пересечения двух прямых");
Console.WriteLine("Уравнение первой прямой y = k1*x + b1, введите k1 и b1, нажимая Enter");

float[] l1 = new float[2];
float[] l2 = new float[2];

fillArray(ref l1, 2);

Console.WriteLine("Вы составили уравнение y = " + l1[0] + "x + " + l1[1]);
Console.WriteLine("Давайте составим второе: введите k2 и b2, нажимая Enter");

fillArray(ref l2, 2);

Console.WriteLine("Вы составили уравнение y = " + l2[0] + "x + " + l2[1]);

float x = 0;
float y = 0;

x = (l2[1]-l1[1])/(l1[0]-l2[0]);
y = l1[0]*x+l1[1];

Console.WriteLine("Координаты пересечения прямых: x=" + x + ", y=" + y);