using Microsoft.Xna.Framework;
using Pokemon2022.GameUI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.GameUI.Entities
{
    public class Event
    {
        public Point MapLocation { get; set; }
        public EventTrigger Trigger { get; set; }
        public List<EventCommand> Commands { get; set; }
    }
}
