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
    public class StartScene : IGameState
    {
        //Fields
        private PyramidPanic game;

        // stap1: maak een varibale (reference) van de class, bedenk een pasende naam


        //maak een varibale aan genaamd title, deze is van he type Image
        private Images gameTitel;

        private Menu menu;

        private Images background;
       



        //Constructor
        public StartScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize
        public void Initialize()
        {
            this.LoadContent();
        }


        //LoadContent
        public void LoadContent()
        {
            this.background = new Images(this.game, @"StartScene\Background", new Vector2(0f, 0f));
            this.gameTitel = new Images(this.game, @"StartScene\Title", new Vector2(105f, 30f));
            

            this.menu = new Menu(this.game);
         
        }


        //Update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectorKeyDown(Keys.Right))
            {
                this.game.GameState = this.game.PlayScene;
            }
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Red);
            this.background.Draw(gameTime);
            this.gameTitel.Draw(gameTime);
            this.menu.Draw(gameTime);
   

               
        }
    }
}