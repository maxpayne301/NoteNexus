﻿

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class ListAllAlbumsMenu : Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayTitle("Displaying every album from a band");
        Console.Write("From wich band you want to see their albums?: ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            
            foreach (var kvp in registeredBands)
            {
                kvp.Value.DisplayAlbums();
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"{bandName} not found!");
            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
        }

    }


}