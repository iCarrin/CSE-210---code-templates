using System;
using System.Buffers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.CallMenu();
    }
}