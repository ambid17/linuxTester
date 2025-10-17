namespace linuxTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var environmentName = Environment.GetEnvironmentVariable("DB_CONNECTION");
            Console.WriteLine($"Environment: {environmentName}");
        }
    }
}
