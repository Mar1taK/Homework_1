//Известен радиус окружности. Найти длину окружности и площадь круга.

    Console.Write("Ведите радиус окружности: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    
    double lengthCircle = 2 * Math.PI * radius;
    double AreaCircle = Math.PI * Math.Pow(radius, 2);
    
    Console.Write("Длинна окружности равна: {0} \nПлощадь круга равна: {1}", Math.Round(lengthCircle, 2), Math.Round(AreaCircle, 2));
    