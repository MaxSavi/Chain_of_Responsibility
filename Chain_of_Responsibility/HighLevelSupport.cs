using System;

public class HighLevelSupport : IHandler
{
    public IHandler SetNext(IHandler next)
    {
        return next; // это последний обработчик, дальше передавать некуда
    }

    public void Handle(string issue, int severity)
    {
        if (severity <= 10)
        {
            Console.WriteLine($"[HighLevelSupport] Проблема \"{issue}\" решена на высоком уровне поддержки.");
        }
        else
        {
            Console.WriteLine($"[HighLevelSupport] Проблема \"{issue}\" слишком сложная, передача не возможна.");
        }
    }
}
