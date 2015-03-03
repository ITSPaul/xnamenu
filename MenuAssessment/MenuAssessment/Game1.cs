using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MenuAssessment
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle _viewRect;
        string[] menuOptions = new string[] { "  Play  ", "  Character  ", "  Exit " };
        private Texture2D _txMenuBack;
        private Texture2D _background;
        private SpriteFont _font;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            _viewRect = graphics.GraphicsDevice.Viewport.Bounds;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _txMenuBack = Content.Load<Texture2D>("parchmentBackground");
            _background = Content.Load<Texture2D>("photoShopButton");
            _font = Content.Load<SpriteFont>("message");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            string str = "  This is the Item  ";
            Vector2 strSize = _font.MeasureString(str);
            Vector2 pos = new Vector2(100, 100);
            Vector2 rectSize = new Vector2(strSize.X, strSize.Y) + new Vector2(20,strSize.Y);
            Rectangle item = new Rectangle((int)pos.X, (int)pos.Y, (int)rectSize.X, (int)rectSize.Y);
            Vector2 textPos = pos + new Vector2(rectSize.X - strSize.X,
                                        rectSize.Y - strSize.Y) / 2;

            spriteBatch.Begin();
            spriteBatch.Draw(_background, _viewRect, Color.White);
            spriteBatch.Draw(_txMenuBack, item, Color.White);
            spriteBatch.DrawString(_font, str, textPos, Color.SaddleBrown);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
