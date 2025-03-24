using System;

public class LowLevelSupport : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler next)
    {
        _nextHandler = next;
        return next;
    }

    public void Handle(string issue, int severity)
    {
        if (severity <= 2)
        {
            Console.WriteLine($"[LowLevelSupport] Проблема \"{issue}\" решена на низком уровне поддержки.");
        }
        else
        {
            Console.WriteLine($"[LowLevelSupport] Не могу обработать \"{issue}\". Передаю дальше...");
            _nextHandler?.Handle(issue, severity);
        }
    }
}
