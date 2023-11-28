using System;
using TestingConsoleApp;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");

OutMethodTest test = new OutMethodTest();
string outStr = "";
test.TestOutMethod(out outStr);

Console.WriteLine(outStr);
Console.WriteLine(test.TestOutMethod(out outStr));






Console.ReadKey();
