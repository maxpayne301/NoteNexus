﻿

using NoteNexus.Interfaces;
using NoteNexus.Models;

namespace NoteNexus.Menus;

abstract internal class Menu
{
    public static void DisplayTitle(string title)
    {
        int stringCount = title.Length;
        string characteres = string.Empty.PadLeft(stringCount, '*');
        Console.WriteLine(characteres);
        Console.WriteLine(title);
        Console.WriteLine(characteres + "\n");
    }

    public virtual void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
    }
}
