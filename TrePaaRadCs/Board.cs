using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrePaaRadCs
{
    internal class Board
    {
        private Square[] _squares = new Square[9];
        private readonly Random _random = new Random();
        public Board() 
        {
            for(int i = 0; i < _squares.Length; i++) 
            {
                _squares[i] = new Square();
            }

        }

        public char getSquareChar(int index)
        {
            if (_squares[index].IsEmpty()) return ' ';
            else if (_squares[index].IsOccupiedByPlayerOne()) return 'x';
            else  return 'o';
        }

        public int Mark(string position, bool isPlayerOne)
        {
            int index = 0;
            switch (position)
            {
                case "a1":
                    index = 0;
                    break;
                case "b1":
                    index = 1;
                    break;
                case "c1":
                    index = 2;
                    break;
                case "a2":
                    index = 3;
                    break;
                case "b2":
                    index = 4;
                    break;
                case "c2":
                    index = 5;
                    break;
                case "a3":
                    index = 6;
                    break;
                case "b3":
                    index = 7;
                    break;
                case "c3":
                    index = 8;
                    break;

                default:
                    index = 0;
                    break;
            }



            if (index >=0 && index < 9)
            return _squares[index].SetOccupation(isPlayerOne);
            else return 0;
        }
        public void MarkRandom(bool isPlayerOne)
        {
            int randomNumber = 0;
            do
            {
                randomNumber = _random.Next(0, 9);
            } while (_squares[randomNumber].IsOccupied());

            _squares[randomNumber].SetOccupation(isPlayerOne);

        }

        public bool checkIfBoardIsFull()
        {
            int counter = 0;
            foreach (var item in _squares)
            {
                if(item.GetOccupier() != 0 ) counter++;
            }
            if (counter >= 9)
            {
                return true;
            }
            else return false;

        }
        /*public int checkIfHasWon()
        {


        }*/

        private bool checkOnePossibility(int index1, int index2, int index3)
        {
            bool one = _squares[index1].GetOccupier() == 1 || _squares[index1].GetOccupier() == 2;
            bool two = _squares[index1].GetOccupier() == _squares[index2].GetOccupier();
            bool three = _squares[index1].GetOccupier() == _squares[index3].GetOccupier();
            bool toReturn =  one && two && three;
            //Console.WriteLine(toReturn);
            return toReturn;

        }

        public bool checkForWinner()
        {
            return checkOnePossibility(0, 1, 2)
                || checkOnePossibility(3, 4, 5)
                || checkOnePossibility(6, 7, 8)
                || checkOnePossibility(0, 3, 6)
                || checkOnePossibility(1, 4, 7)
                || checkOnePossibility(2, 5, 8)
                || checkOnePossibility(0, 4, 8)
                || checkOnePossibility(2, 4, 6);
        }
    }
}
