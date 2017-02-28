﻿using md5tool;
using System;
namespace md5console
{
    class Program
    {
        string newline = Environment.NewLine;

        static void Main(string[] args)
        {
            Func obj = new Func();
            if (obj.IsAdmin())
            {
                obj.CreateRegKey();
                Console.WriteLine("Reg OK!" + Environment.NewLine);
            }
            else
            {
                string filename = "";
                if (args.GetLength(0) > 0)
                {
                    filename = args[0];
                }
                obj.ShowMessage(filename);
            }
        }


    }
}
