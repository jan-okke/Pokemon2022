using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pokemon2022.GameUI.Entities;
using System;
using System.Collections.Generic;

namespace Pokemon2022.GameUI
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Map TestMap;
        private Point PlayerPosition = new Point(6, 6);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _spriteBatch.Begin();
            TestMap = new Map();
            TestMap.MapTileset = new Tileset();
            TestMap.MapTileset.Graphic = Content.Load<Texture2D>("JohtoTileset");
            TestMap.MapTileset.Load(GraphicsDevice);
            TestMap.Size = new Point(6, 6);
            TestMap.TilesetData = new Dictionary<int, List<int>>
            {
                {0, new List<int> {1,3,4,5,6,7,} },
                {1, new List<int> {2,3,4,1,4,4,4}}
            };
            _spriteBatch.End();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.Right)) PlayerPosition.X++;
            if (kbState.IsKeyDown(Keys.Left)) PlayerPosition.X--;
            if (kbState.IsKeyDown(Keys.Up)) PlayerPosition.Y--;
            if (kbState.IsKeyDown(Keys.Down)) PlayerPosition.Y++;


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            TestMap.Render(_spriteBatch, PlayerPosition);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}