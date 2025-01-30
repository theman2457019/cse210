using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Menu.Display();
        int choice = Menu.getChoice();
        System.Console.WriteLine($"{choice}");

        if (choice == 1){
            Entry.Display();
        }
    }

}

