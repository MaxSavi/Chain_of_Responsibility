public interface IHandler
{
    IHandler SetNext(IHandler next); // установка следующего обработчика в цепочке
    void Handle(string issue, int severity); // обработка запроса
}
