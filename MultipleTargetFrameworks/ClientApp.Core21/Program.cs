﻿namespace ClientApp.Core21
{
    using System;
    using MultipleTargetFrameworks;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new DemoObject().Message);
            Console.ReadKey();
        }
    }
}
