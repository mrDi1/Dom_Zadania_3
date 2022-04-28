// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Double x1 = 3;
Double x2 = 2;
Double y1 = 6;
Double y2 = 1;
Double z1 = 8;
Double z2 = -7;
Double dis;

// dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// dis = Math.Round(dis,2);
// Console.WriteLine($"Расстояние между двумя точками на плоскости равно {dis}");

dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
dis = Math.Round(dis,2);                                                                    // округлили остаток
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {dis}");

// Методы мне совсем не даются (((