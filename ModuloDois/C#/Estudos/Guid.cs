namespace Estudos;
using System;

public class Guid
{
    public Guid guid;
    public void ExemploGuid()
    {
        guid = new Guid();
        Console.WriteLine("New GUID Is: " + guid.ToString().Substring(0, 15));
    }
}