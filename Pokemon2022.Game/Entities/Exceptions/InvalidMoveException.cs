using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class InvalidMoveException : Exception
    {
        public InvalidMoveException(string name)
            : base($"Invalid Move {name}")
        { }
    }
}
