using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class InvalidCategoryException : Exception
    {
        public InvalidCategoryException(MoveCategory category)
            :base($"Invalid Move Category {category}")
        { }
    }
}
