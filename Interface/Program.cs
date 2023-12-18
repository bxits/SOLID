namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            IErrorLogger l;// = new ConsoleErrorLogger();
            l = new EMailAlertErrorLogger();
            DBAccess dba = new DBAccess(l);


        }
    }
}