/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int tryCount = 3, number = 0;
string input = string.Empty, tmp = string.Empty;
bool res = false;

while (!res)
{
    Console.WriteLine($"\r\nВведите пятизначное целое число (количество попыток: {tryCount})");

    input = Console.ReadLine() ?? string.Empty;
    tmp = input.Replace("-", "");
    res = int.TryParse(input, out number) && tmp.Length == 5;

    if (!res)
    {
        tryCount --;

        if (tryCount == 0)
        {
            Console.WriteLine("\r\nВы исчерпали все попытки.\r\nВыполнение программы будет остановлено.");
            return;
        }
    }    
}

Console.WriteLine($"Число {number}{(tmp[0] == tmp[4] && tmp[1] == tmp[3] ? " " : " не ")}является палиндромом.");