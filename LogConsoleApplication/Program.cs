// See https://aka.ms/new-console-template for more information
using Serilog;

Console.WriteLine("Hello, World!");

Log.Logger = new LoggerConfiguration()
                      .WriteTo.Console()
                      .CreateLogger();


Log.Information("test");

Console.ReadLine();