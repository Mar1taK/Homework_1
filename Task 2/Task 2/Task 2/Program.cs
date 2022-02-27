// Даны длины сторон прямоугольного палаллелепипеда. Найти его объем и площадь поверхности.

int a = 15; // length
int b = 67; // width
int h = 112; // height

int volume = a * b * h;
int area = 2 * (a * b + b * h + a * h);


Console.WriteLine("Объем прямоугольного параллелепипеда равен: " + volume);
Console.WriteLine("Площадь поверхности параллелепида равна: " + area);
Console.ReadLine();
