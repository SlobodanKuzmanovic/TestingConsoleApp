using System;
using TestingConsoleApp;
using TestingConsoleApp.Old;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");

testInterface1 obj1 = new Abc();
testInterface2 obj2 = new Abc();
obj1.Show();
obj2.Show();

Console.ReadKey();
