// всегда  надо  быть информативным поэтому выведем  
PrintYellow("Программа для анализа функции! y=-x^2 -2 ");

while (true) // безконченый цыкл  - что  бы не перезапускать  программу каждый раз 
{
    MyProgramm(); // сам алгоритм 
}



// методы 

void MyProgramm()
{
    PrintGreen("Введите x минимальный"); // все диалги будем делать зелеными  - чтоб красиво

    double xMin = GetDouble(); // получит  число  -сложная  задача - вынесем  в  отдельный  метод 

    PrintGreen("Введите x максимальный");

    double xMax = GetDouble();

    PrintGreen("Введите шаг функции");

    double xStep = GetDouble();

    Myfunction(xMin, xMax, xStep); // когда  у  нас  есть  все данные  дадим их отдельному методу 
}

void Myfunction(double xMin, double xMax, double xStep)
{
    // валидация  входных параметров 
    if (xMin > xMax)
    {
        PrintRed("x минимальная больше чем x максимальная");
        return; // выход из функции  дострочно
    }

    if (xStep == 0)
    {
        PrintRed("Шаг равен нулю");
        return;
    }


    if (xStep < 0)
    {
        PrintRed("Шаг меньше нуля");
        return;
    }


    PrintYellow("_____Ответ____");
    /// переберем функцию 
    for (double i = xMin; i <= xMax; i += xStep)
    {
        double y = -Math.Pow(i, 2) - 2; // формула

        PrintYellow($"x={i}: y={y}"); // Ответ 
    }
}

void PrintGreen(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Green; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}

void PrintYellow(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Yellow; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}




void PrintRed(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Red; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}



double GetDouble()
{
    try
    {
        string temp = Console.ReadLine();
        return Convert.ToDouble(temp);
    }
    catch
    {
        PrintRed("Не верный ввод, введите число");
        return GetDouble();
    }
}
