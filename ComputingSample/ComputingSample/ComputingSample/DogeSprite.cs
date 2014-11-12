using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ComputingSample
{
    class DogeSprite
    {
        //variables to be used in the class
        Rectangle spriteRect;
        Texture2D spriteTex;
        Vector2 velocity;
        //constructor for the class
        public DogeSprite(Texture2D Stex, Rectangle Srect, Vector2 Svel)
        {
            //assign the input to the classes variables
            spriteRect = Srect;
            spriteTex = Stex;
            velocity = Svel;
        }

        public void update()
        {
            //add update code
        }

        public void draw(SpriteBatch spriteBatch)
        {
            //add drawing code
        }

    }
}
