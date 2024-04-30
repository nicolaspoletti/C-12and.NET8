﻿namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Environment.CurrentDirectory);
        System.Console.WriteLine(Environment.OSVersion.VersionString);
        System.Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
    }
}
