using System;

public class MiddleLevelSupport : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler next)
    {
        _nextHandler = next;
        return next;
    }

    public void Handle(string issue, int severity)
    {
        if (severity <= 5)
        {
            Console.WriteLine($"[MiddleLevelSupport] Проблема \"{issue}\" решена на среднем уровне поддержки.");
        }
        else
        {
            Console.WriteLine($"[MiddleLevelSupport] Не могу обработать \"{issue}\". Передаю дальше...");
            _nextHandler?.Handle(issue, severity);
        }
    }
}
