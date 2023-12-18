// See https://aka.ms/new-console-template for more information
using S_OLID;

Console.WriteLine("Hello, World!");

//EMailAlertErrorLogger e = new EMailAlertErrorLogger();
ConsoleErrorLogger cel = new ConsoleErrorLogger();

Mitarbeiter ma = new Mitarbeiter(cel);
