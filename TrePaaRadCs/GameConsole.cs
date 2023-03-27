using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrePaaRadCs
{
    internal class GameConsole
    {


        public void Show(Board gameBoard)
        {
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            int squareCounter = 0;
            for (int i = 0; i < 3; i++) 
            {
                
                for(int j = 0; j < 9; j++) 
                {
                    if (j == 0)
                    {
                        Console.Write(""+(i+1));

                    }
                    if (j == 1)
                    {
                        Console.Write('│');
                    }
                    if (j == 8)
                    {
                        Console.Write("│");
                        Console.WriteLine();
                    }
                    if ((j > 2 && j < 8) && (j % 2 == 0))
                    {
                        Console.Write(' ');
                    }
                    if ((j > 2 && j < 8) && (j % 2 == 1))
                    {
                        char square = gameBoard.getSquareChar(squareCounter);
                        Console.Write(square);//her printes x eller O eller <tom>
                        //Console.Write('x');//her printes x eller O eller <tom>
                        squareCounter++;
                    }

                }
                
            }
            Console.WriteLine(" └─────┘");


        }
            
    }
}
