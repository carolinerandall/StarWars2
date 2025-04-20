using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codingchallenge
{
    public class AsciiArt // Corrected the class name from AciiArt to AsciiArt
    {
        public AsciiArt asciiArt = new AsciiArt();
        private int asciiArtID;

        public void DisplayJediCharacter()
        {
            System.Console.WriteLine(@"
                o
               /|\
               / \
                ");
        }
        public void DisplayYoda(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(@"
                <o>
                /|\
                / \
                ");
            Console.ResetColor();
        }
    }
}