using System;
using TestingConsoleApp;
using TestingConsoleApp.Old;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");

Class1 class1 = new Class1();

Console.WriteLine(class1.Test());

class1 = new Class2();

Console.WriteLine(class1.Test());




Console.ReadKey();
