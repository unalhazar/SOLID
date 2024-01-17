namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var formatter = new LogFormatter();
            var logger = new Logger(formatter);

            var message = logger.Log("Merhaba, bu bir test log mesajıdır.");
            Console.WriteLine(message);
        }

        public class Logger
        {
            private readonly LogFormatter _logFormatter;

            public Logger(LogFormatter logFormatter)
            {
                _logFormatter = logFormatter;
            }

            public string Log(string message)
            {
                var formattedMessage = _logFormatter.FormatMessage(message);
                return formattedMessage;
            }
        }

        public class LogFormatter
        {
            public string FormatMessage(string message)
            {
                // Mesajı formatla ve geri dön
                return $"[{DateTime.Now}] {message}";
            }
        }

    }
}
