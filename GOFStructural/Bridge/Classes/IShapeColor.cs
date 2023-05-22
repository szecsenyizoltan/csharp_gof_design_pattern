using System;

namespace Bridge.Classes
{
    public interface IShapeColor
    {
        ConsoleColor Color { get; }
        string Name { get; }
    }
}