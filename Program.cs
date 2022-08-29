// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
string isPalindrom(int s)
{   
    string newString = s.ToString();
    for (int i = 0; i < newString.Length / 2; ++i)
        if (newString[i] != newString[newString.Length - 1 - i]) return "Нет";
    return "Да";
}

Console.Write(isPalindrom(14212));
Console.WriteLine();
Console.Write(isPalindrom(12821));
Console.WriteLine();
Console.Write(isPalindrom(23432));
