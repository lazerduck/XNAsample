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

namespace ComputingSample
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Here we declare our global variables such as textures and rectangles
        //screen dimensions
        const int WIDTH = 800;
        const int HEIGHT = 600;
        //textures
        Texture2D Doge;

        //rectangles - these will be used to draw textures in
        Rectangle DogeRect;
        float xvelocity = 10;
        float yvelocity = 10;

        //example of the class
        DogeSprite doge;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = HEIGHT;
            graphics.PreferredBackBufferWidth = WIDTH;
        }

        protected override void Initialize()
        {
            //initialise the rectangles
            DogeRect = new Rectangle(0, 0, 100, 100);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //load the textures from the content list on the right
            Doge = Content.Load<Texture2D>("doge");

            //class example
            doge = new DogeSprite(Doge,new Rectangle(0,0,100,100),new Vector2(10));
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            //make the image move
            DogeRect.X += (int)xvelocity;
            DogeRect.Y += (int)yvelocity;
            //check we are still in the window
            //if the left or right hand sides leave the screen then flip the direction if we do
            if (DogeRect.X < 0 || DogeRect.X + DogeRect.Width > WIDTH)
            {
                xvelocity = -xvelocity;
            }
            //repeat for the y axis
            if (DogeRect.Y < 0 || DogeRect.Y + DogeRect.Height > HEIGHT)
            {
                yvelocity = -yvelocity;
            }

            //class example
            doge.update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            //start the spritebatch so we can draw
            spriteBatch.Begin();
            //draw object
            spriteBatch.Draw(Doge, DogeRect, Color.White);
            //class example
            doge.draw(spriteBatch);
            //close the spritebatch
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
