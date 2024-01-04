using System;
using TestingConsoleApp;
using TestingConsoleApp.CodeWars;
using TestingConsoleApp.Old;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");

int[] a = { 5, 7, 10, 5, 15 };
int[] b = { 2, 2, 1, 3, 5 };

int steps = StepCountToEqualElementOfArray.MinStepsToMakeEqual(a, b);
Console.WriteLine($"Minimum steps to make all elements equal: {steps}"); 



Console.ReadKey();



