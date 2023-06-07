// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = (Console.ReadLine()!);
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void ExamDigit (int value)
{
    int digit1 = value / 10000;
    int digit2 = (value / 1000)%10;
    int digit3 = (value / 100)%10;
    int digit4 = (value / 10)%10;
    int digit5 = value %10;
    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Введенное число является палиндромом ");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ является палиндромом ");
    }
}

int num = Prompt ("Введите пятизначное число: ");
while (num < 10000 && num > 99999)
{
    Console.WriteLine("Введено неверное число...");
    num = Prompt ("Повторите ввод пятизначного числа: ");
}
ExamDigit(num);