using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.GameUI.Entities
{
    public class Map
    {
        public Point Size { get; set; }
        public Tileset MapTileset { get; set; }
        public Dictionary<int, List<int>> TilesetData { get; set; }
        public List<Event> Events { get; set; }

        private const int VIEWRANGE_LEFT = 8;
        private const int VIEWRANGE_UP = 6;

        public Map()
        {
            
        }

        public Map(int sizeX, int sizeY, Tileset tileset, Dictionary<int, List<int>> tilesetData) 
        {
            Size = new Point(sizeX, sizeY);
            MapTileset = tileset;
            TilesetData = tilesetData;
        }
        public Map(Point size, Tileset tileset, Dictionary<int, List<int>> tilesetData)
        {
            Size = size;
            MapTileset = tileset;
            TilesetData = tilesetData;
        }

        private Point GetPointFromIndex(int index)
        {
            return new Point(index % Size.X, (int)(index / Size.X));
        }

        public void Render(SpriteBatch batch, Point playerPos)
        {
            foreach (int layer in TilesetData.Keys) 
            {
                var loc = new Point(0, 0);
                for (int i = 0; i < TilesetData[layer].Count; i++)
                {
                    var pt = GetPointFromIndex(i);
                    if (pt.X < playerPos.X - VIEWRANGE_LEFT || pt.X > playerPos.X + VIEWRANGE_LEFT) continue;
                    if (pt.Y < playerPos.Y - VIEWRANGE_UP || pt.Y > playerPos.Y + VIEWRANGE_UP) continue;
                    var tile = MapTileset.GetTile(TilesetData[layer][i]);
                    batch.Draw(tile.Graphic, new Rectangle(loc.X, loc.Y, 32, 32), Color.White);
                    loc.X += 32;
                    if (loc.X >= VIEWRANGE_LEFT * 64)
                    {
                        loc.Y += 32;
                        loc.X = 0;
                    }
                }
            }
        }
        public Event GetEvent(Point playerPos)
        {
            foreach (Event e in Events)
            {
                if (e.MapLocation == playerPos && e.Trigger == Enums.EventTrigger.PlayerTouch) 
                {
                    return e;
                }
            }
            return null;
        }
    }
}
