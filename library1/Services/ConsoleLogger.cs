namespace library1.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string textToLog)
        {
            Console.WriteLine(textToLog);
        }
    }
}