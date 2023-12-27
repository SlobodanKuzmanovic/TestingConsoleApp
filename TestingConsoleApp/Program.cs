using System;
using TestingConsoleApp;
using TestingConsoleApp.CodeWars;
using TestingConsoleApp.Old;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");

var n = Convert.ToInt32(Console.ReadLine());
var strArry = Console.ReadLine();

var arr = strArry.Split(' ').Select(x => Convert.ToInt32(x)).ToList();

var orderedArr = arr.GroupBy(x => x).OrderByDescending(x => x.Count()).ToList();

Console.WriteLine(n);


Console.ReadKey();



