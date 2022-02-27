// Найти сумму, разность, произведение и частное от деления первого числа на второе

Console.WriteLine("Введите число 1: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2: ");

double number2 = Convert.ToDouble(Console.ReadLine());
double plus = (number1) + (number2);
double minus = (number1) - (number2);
double multiplied = (number1) * (number2);
double divided = (number1) / (number2);

Console.WriteLine("Сумма: {0}", plus);
Console.WriteLine("Разность: {0}", minus);
Console.WriteLine("Произведение: {0}", multiplied);
Console.WriteLine("Частное: {0}", divided);
Console.ReadLine();


