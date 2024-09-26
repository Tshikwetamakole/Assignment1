// See https://aka.ms/new-console-template for more information
using System;

namespace MilkSongApp
{
    class MilkSong
    {
        public void Sing()
        {
            for (int bottles = 99; bottles > 0; bottles--)
            {
                if (bottles > 1)
                {
                    Console.WriteLine($"{bottles} bottles of milk on the wall, {bottles} bottles of milk.");
                    Console.WriteLine($"Take one down and pass it around, {bottles - 1} {(bottles - 1 > 1 ? "bottles" : "bottle")} of milk on the wall.");
                }
                else
                {
                    Console.WriteLine($"{bottles} bottle of milk on the wall, {bottles} bottle of milk.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of milk on the wall.");
                }

                Console.WriteLine();  // Add a blank line between verses
            }

            // When there are no bottles left
            Console.WriteLine("No more bottles of milk on the wall, no more bottles of milk.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of milk on the wall.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MilkSong song = new MilkSong();
            song.Sing();
        }
    }
}

