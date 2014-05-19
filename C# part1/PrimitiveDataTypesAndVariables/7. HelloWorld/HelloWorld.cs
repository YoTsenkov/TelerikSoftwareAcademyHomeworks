using System;
class HelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object msg = hello + " " + world;
        string objValue = (string)msg;
    }
}

