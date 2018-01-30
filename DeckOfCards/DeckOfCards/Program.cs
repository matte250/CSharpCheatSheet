using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(Exercise 45)
             * Create a program that can shuffle a deck of cards. The cards can be represented as an array of integers,
             * like [1,1,1,1,2,2,2,2,3,3,…n]. Then make it possible to draw 1 card from the deck and add to another array. (The
             * card should then disappear from the card deck and appear in the array with the drawn cards. Tip: You can use
             * Array.Resize( ref array, newSize) to change the size of an existing array, and Array.Copy. There is however not a
             * requirement that the array needs to be in a specific order after a card has been drawn. Complete the functions
             * below.
             */

            // Variable initization.
            string strDeck,strDrawn;
            char input = 'b';
            int[] deck = {
                1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,
                6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,
                10,11,11,11,11,12,12,12,12,13,13,13,13
            };

            int[] drawn = new int[0];
            Console.CursorVisible = false;

            while (!input.Equals('x'))
            {
                PrintExercise(45, "Deck of cards.");
                // Deck string setup.
                Console.WriteLine("[DECK]");
                strDeck = "{";
                foreach (int i in deck)
                {
                    if (i < 10) strDeck += " ";
                    strDeck += (i + ", ");

                }
                strDeck.Remove(strDeck.Length - 1, 1);
                strDeck += "}";
                strDeck = strDeck.Insert(strDeck.Length / 2, "\n");
                Console.WriteLine(strDeck);
                // Drawn string setup..
                Console.WriteLine("[HAND]");
                strDrawn = "{";
                foreach (int i in drawn)
                {
                    if (i < 10) strDrawn += " ";
                    strDrawn += (i + ", ");

                }
                strDrawn.Remove(strDrawn.Length - 1, 1);
                strDrawn += "}";
                strDrawn = strDrawn.Insert(strDrawn.Length / 2, "\n");
                Console.WriteLine(strDrawn);
                // Reading keys.
                Console.WriteLine(String.Concat(Enumerable.Repeat("- ", 20)));
                Console.WriteLine("Press D to draw a card, S to shuffle the deck. or X to exit.");
                input = Console.ReadKey().KeyChar;
                if (input.Equals('d') && deck.Length > 0)
                {
                    Array.Resize(ref drawn, drawn.Length + 1);
                    drawn[drawn.Length - 1] = DrawCard(ref deck);
                }
                if (input.Equals('s')) ShuffleCards(ref deck);
            }


        }

        static int DrawCard(ref int[] deck)
        {
            // code to draw a card here
            int card = deck[deck.Length - 1];
            Array.Resize(ref deck, deck.Length - 1);
            return card;
        }
        static void ShuffleCards(ref int[] deck)
        {
            // code to shuffle the deck here
            Random r = new Random();
            int number = 0;
            int[] tempA = new int[deck.Length];
            int[] tempB = new int[deck.Length];
            deck.CopyTo(tempA, 0);

            while (tempA.Length != 0)
            {
                int index = r.Next(tempA.Length - 1);
                tempB[number] = tempA[index];
                for (int i = index; i < tempA.Length; i++)
                {
                    tempA[i] = tempA[Math.Min(i + 1, tempA.Length - 1)];
                }
                Array.Resize(ref tempA, tempA.Length - 1);
                number++;
            }

            tempB.CopyTo(deck, 0);
        }

        public static void PrintExercise(int x, string desc)
        {
            // Printing format for exercise descriptions.
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(Exercise {0}) ", x);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(desc);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(String.Concat(Enumerable.Repeat("- ", 20)));
        }
    }
}
