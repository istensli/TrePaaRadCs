using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrePaaRadCs
{
    internal class Square
    {
        private int _occupier;

        public Square()
        {
            _occupier = 0;
        }

        public int GetOccupier()
        {
            return _occupier;
        }

        public bool IsEmpty()
        {
            return _occupier == 0;
        }

        public bool IsOccupiedByPlayerOne()
        {
            return _occupier == 1;
        }
        public bool IsOccupied()
        {
            if (_occupier == 1 || _occupier == 2)
                return true;
            else return false;
        }

        public int SetOccupation(bool isPlayerOne)
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Denne plassen er okkupert!");
                return 1;
            }
            if (isPlayerOne)
            {
                _occupier = 1;
            }
            else _occupier = 2;
            return 0;
        }
    }
}
