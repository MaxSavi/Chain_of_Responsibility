using System;

class Program
{
    static void Main()
    {
        IHandler supportChain = SupportChain.CreateSupportChain();

        Console.WriteLine("Тест 1: Простая проблема (severity = 1)");
        supportChain.Handle("Не работает клавиатура", 1);

        Console.WriteLine("\nТест 2: Средняя проблема (severity = 4)");
        supportChain.Handle("Компьютер зависает", 4);

        Console.WriteLine("\nТест 3: Сложная проблема (severity = 7)");
        supportChain.Handle("Ошибка в базе данных", 7);

        Console.WriteLine("\nТест 4: Нерешаемая проблема (severity = 12)");
        supportChain.Handle("Взрыв сервера", 12);
    }
}

