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


namespace PyramidPanic
{
    class ControlScene
    {

        //fiel
        private PyramidPanic game;

        //constructor
        public ControlScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }


        //Initialize
        public void Initialize()
        {


        }

        // Loadcontent
        public void loadContent()
        {

        }

        //update
        public void Update(GameTime gametime)
        {

        }

        //draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.PaleGoldenrod);
        }
    }
}
