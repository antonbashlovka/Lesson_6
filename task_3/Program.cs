/*
    Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
    Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
    Если кол-во элементов нечетное, то элемент посередине не учитывать.
    Результат сложения вывести на экран.
    1, 3, 8, 3, 2 -> 11
    8, 3, 4, 2 -> 28
*/
void printArray(int[] arr){
    string res = "[";
    foreach (int value in arr ){
        res = res + Convert.ToString(value) + ",";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

void fillArray(ref int[] arr, int n){

    string userInput = "";
    int userNumber = 0;

    for (int i = 0; i < n; i++)
    {
        userInput = Console.ReadLine()  ?? "неизвестное сообщение"; // проверка на NULL
        userNumber = inputNumber(userInput);
        arr[i] = userNumber;
    }
}

int inputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

Console.WriteLine("Нужен массив чисел, сколько чисел будете вводить?");
string M = Console.ReadLine()  ?? "неизвестное сообщение";
int i = inputNumber(M);

if (i > 0) 
{
    Console.WriteLine("Введите числа, нажимая Enter");

    int[] arr = new int[i]; 

    fillArray(ref arr, i);
    printArray(arr);

    int sum = 0;

    for (int j = (arr.Length)/2; j > 0; j--){
        if ((arr.Length % 2) == 0) {
            sum = sum + arr[j*2-1]*arr[arr.Length-j*2];
        }else{
            sum = sum + arr[j-1]*arr[arr.Length-j];
        }
    }

    Console.WriteLine("Сумма произведений пар чисел: " + sum);

}else{
    Console.WriteLine("Отмена");
}