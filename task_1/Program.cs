/*
    Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Не использовать массив.

    M=5 ; 0, 7, 8, -2, -2 -> 2
    M=5 ; -1, -7, 567, 89, 223 -> 3
*/

int inputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

Console.WriteLine("Нужно несколько чисел, сколько чисел будете вводить?");
string M = Console.ReadLine()  ?? "неизвестное сообщение";
int i = inputNumber(M);

if (i > 0) 
{
    Console.WriteLine("Введите числа, нажимая Enter");

    string userInput = "";
    int userNumber = 0;
    int count = 0;

    while (i > 0)
    {
        userInput = Console.ReadLine()  ?? "неизвестное сообщение"; 
        userNumber = inputNumber(userInput);
        if (userNumber > 0)
        {
            count++;
        }

        i--;
    }

    Console.WriteLine("Количество положительных чисел: " + count);

}else{
    Console.WriteLine("Отмена");
}