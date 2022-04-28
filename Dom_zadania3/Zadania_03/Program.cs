// Задача 1
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125 


// int n = 5;                               
// Console.Write(n + " -> ");
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"{i * i * i}, ");
// }


// string met1(int count, string c)
// {
//     int i = 0;
//     string result = string.Emptx;
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = met1(5,", durak ");
// Console.Write(res);

int x = 5;
Console.Write(x + " -> ");
int kub(int n)
{
    int result = n;
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i * i}, ");
    }
    return result;
}
int res = kub(x);
Console.Write(res);



// сделал как смог((
// не могу нормально сделать методы, а если сделал не могу использовать его нормально(( 