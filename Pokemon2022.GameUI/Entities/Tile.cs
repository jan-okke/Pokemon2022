using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.GameUI.Entities
{
    public class Tile
    {
        public Texture2D Graphic;

        public Tile(Texture2D graphic)
        {
            Graphic = graphic;
        }
    }
}
