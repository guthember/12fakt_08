using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eldontes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("A fájl tartalmazza-e a 42 számot?\n");

      // Fájlból töltjük fel a tömböt
      // Egész számok, külön sorban, max 100 darab szám lehet
      int[] tomb = new int[100];
      int db = 0; // mennyit olvasunk be? (hány szám van a fájlban)

      StreamReader be = new StreamReader("adatok.txt");

      // amíg nem érek a fájl végére
      while (!be.EndOfStream)
      {
        // beolvasunk a fájlból és konvertálunk
        tomb[db] = Convert.ToInt32(be.ReadLine());
        Console.WriteLine(tomb[db]);
        db++;
      }

      // erőforrás bezárása
      be.Close();

      Console.WriteLine();

      // a 42-t tartalmazza-e? (igen, nem)
      int i = 0; // indexeléshez és találathoz

      while (i < db && tomb[i] != 42)
      {
        i++;
      }

      if (i == db)
      {
        Console.WriteLine("Nem");
      }
      else
      {
        Console.WriteLine("Igen");
      }


      Console.ReadLine();
    }
  }
}
