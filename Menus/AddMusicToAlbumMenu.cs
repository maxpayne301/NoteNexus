﻿

using NoteNexus.Models;

namespace NoteNexus.Menus;

internal class AddMusicToAlbumMenu : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        do
        {
            try
            {
                base.Execute(registeredBands);
                DisplayTitle("Add music to an album");
                Console.Write("For which band is it?: ");
                string bandName = Console.ReadLine()!;
                if (registeredBands.ContainsKey(bandName))
                {
                    Console.Write("For which album would you like to add a music to?: ");
                    string albumName = Console.ReadLine()!;
                    bool albumFound = false;
                    for (int i = 0; i < registeredBands[bandName].Albums.Count; i++)
                    {
                        if (registeredBands[bandName].Albums[i].Name == albumName)
                        {
                            albumFound = true;
                            Console.Write("What's the name of the song?: ");
                            string musicName = Console.ReadLine()!;
                            Console.Write("How long is this song in minutes?: ");
                            int duration = int.Parse(Console.ReadLine()!);                            
                            registeredBands[bandName].Albums[i].AddMusic(new Music(musicName, bandName, duration, true));
                            Console.WriteLine($"{musicName} registered successfully to {albumName}");
                            Thread.Sleep(2000);

                        }
                        
                    }
                    if (!albumFound)
                    {
                        Console.WriteLine($"{albumName} not found in {bandName}!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine($"{bandName} not found!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                break;
            }
            catch (FormatException ex) 
            {
                Console.WriteLine($"Invalid input: {ex.Message}");

            }

        } while (true);
        
        
    }

}
