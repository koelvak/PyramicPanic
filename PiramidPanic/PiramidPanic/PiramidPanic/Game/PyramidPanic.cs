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

namespace PiramidPanic
{

    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //fields, de velden van deze class
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private KeyboardState ks;

        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

      
        protected override void Initialize()
        {
            // maakt de muiscursor zichtbaar in het canvas
            IsMouseVisible = true;

            //veranderd de naav van de window
            this.Window.Title = "Pyramid Panic";

            //veranderd de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;

            //veranderd de hoogte van het canvas
            this.graphics.PreferredBackBufferHeight = 480;

            //past de canvas verandering toe
            this.graphics.ApplyChanges();


            base.Initialize();
        }

       
        protected override void LoadContent()
        {
            
           this.spriteBatch = new SpriteBatch(GraphicsDevice);

        }

     
        protected override void UnloadContent()
        {
            
        }

      
        protected override void Update(GameTime gameTime)
        {


                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

            

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

   

            base.Draw(gameTime);
        }
    }
}
