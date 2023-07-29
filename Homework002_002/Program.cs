Console.WriteLine("Введите число");
        int.TryParse(Console.ReadLine()!, out int a);
    
        if (a>999 || a<100)
        {
        Console.WriteLine("Не трехзначное число");
        return;
        }
        int GetSecond(int a)
        {
        while (a >= 1000) a /= 10;
        int b = a % 10;
        return b;
        }
        Console.WriteLine(GetSecond(a));
