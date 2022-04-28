// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


bool ProvPalin(string s, int i, int j)
{
    bool result = true;
    if (j >= 0)
    {
        result = (s[i] == s[j]) && ProvPalin(s, ++i, --j);
    }
    return result;
}
int i = 23432;
Console.WriteLine(ProvPalin(i.ToString(), 0, i.ToString().Length - 1));

