﻿namespace Labyrinth.Renderer
{
    using System;
    using Labyrinth.Users;

    public class ConsoleRenderer : IRenderer
    {
        public ConsoleRenderer()
        {
        }

        public void ShowLabyrinth(LabyrinthMatrix labyrinth, IPlayer player)
        {
            Console.WriteLine();
            char[][] myMatrix = labyrinth.Matrix;
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    if (i == player.PositionRow && j == player.PositionCol)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(myMatrix[j][i]);
                    }
                }

                Console.WriteLine();
            }
        }

        public string AddInput() 
        {
            string input = Console.ReadLine();
            return input;
        }

        public void ShowWelcomeMessage()
        {            
            Console.WriteLine();
            Console.WriteLine("Welcome to “Labirinth” game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");            
        }

        public void ShowInputMessage()
        {
            Console.Write("Enter your move (L=left, R-right, U=up, D=down): ");
        }

        public void ShowGoodByeMessage() 
        {
            Console.WriteLine("Good bye!");
        }
        public void ShowInvalidMoveMessage()
        {
            Console.WriteLine("Invalid move!");
        }
        public void ShowEscapeLabyrinthMessage(int moves)
        {
            Console.WriteLine("Congratulations! You escaped in " + moves.ToString() + " moves.");
        }
    }
}