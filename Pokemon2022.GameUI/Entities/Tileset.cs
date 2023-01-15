using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.GameUI.Entities
{
    public class Tileset
    {
        public Texture2D Graphic;
        private Tile[,] Tiles;
        private GraphicsDevice Device;

        private void CreateTextureAtlas(int width = 32, int height = 32)
        {
            // Calculate the number of subtextures in the x and y directions
            int numX = Graphic.Width / width;
            int numY = Graphic.Height / height;

            // Create an array to store the subtextures
            Texture2D[,] subTextures = new Texture2D[numX, numY];
            Tiles = new Tile[numX, numY];

            // Loop through the subtextures and extract the pixel data for each one
            for (int x = 0; x < numX; x++)
            {
                for (int y = 0; y < numY; y++)
                {
                    // Create a new texture to store the subtexture
                    subTextures[x, y] = new Texture2D(Device, width, height);

                    // Create an array to hold the pixel data for the subtexture
                    Color[] data = new Color[width * height];

                    // Extract the pixel data from the original texture
                    Graphic.GetData(0, new Rectangle(x * width, y * height, width, height), data, 0, data.Length);

                    // Set the pixel data for the subtexture
                    subTextures[x, y].SetData(data);
                    Tiles[x, y] = new Tile(subTextures[x, y]);
                }
            }
        }

        public Tileset()
        {
        }

        public void Load(GraphicsDevice device)
        {
            Device = device;
            CreateTextureAtlas();
        }

        public Tile GetTile(int index)
        {
            return Tiles[index % 8, index / 8];
        }
    }
}
