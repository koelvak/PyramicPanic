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
   
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        // Fields, de velden van deze class 
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        // Maak een variabele aan van het type StartScene
        private StartScene startScene; // Camelcase notatie

        // Maak een variabele aan van het type PlayScene
        private PlayScene playScene; // Camelcase notatie

        // Maak een variabele aan van het type GameOverScene
        private gamoverScene gamoverScene; // Camelcase notatie
        
        
        // Maak een variabele aan van het type HelpScene
        private ControlScene controlscene; // Camelcase notatie

        // Maak een variabele aan van het type GameEndScene
        private Wonscene wonscene; // Camelcase notatie

        /* De variabele die alle verschillende Scene-objecten kan bevatten is van het type 
         * IGameState. Dit is geen class, maar een nieuw objecttype Interface
         */
        private IGameState gameState;

        //properties
        public IGameState GameState
        {
            get { return this.gameState; }
            set { this.gameState = value; }
        }

        public Wonscene WonScene
        {
            get { return this.wonscene; }
        }

        public PlayScene PlayScene
        {
            get { return this.playScene; }
        }

        public ControlScene ControlScene
        {
            get { return this.controlscene; }
        }

        public StartScene StartScene
        {
            get { return this.startScene; }
        }

        public gamoverScene gameoverscene
        {
            get { return this.gameoverscene; }
        }

        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }



        
        



        public PyramidPanic()
        {
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            // Maakt de muiscursor zichtbaar in het canvas
            IsMouseVisible = true;
            
            // Veranderd de titel van het canvas
            this.Window.Title = "Pyramid Panic";
            
            // Veranderd de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 1250;

            //Veranderd de hoogte van het canvas
            this.graphics.PreferredBackBufferHeight = 720;

            // Past de veranderingen betreffende het canvas toe
            this.graphics.ApplyChanges();
            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

            // Maak een instantie aan van de class StartScene
            this.startScene = new StartScene(this);

            // Maak een instantie aan van de class StartScene
            this.playScene = new PlayScene(this);

            // Maak een instantie aan van de class GameOverScene
            this.gamoverScene = new gamoverScene(this);

            // Maak een instantie aan van de class HelpScene
            this.controlscene = new ControlScene(this);

            // Maak een instantie aan van de class GameEndScene
            this.wonscene = new Wonscene(this);

            this.gameState = this.wonscene;
        }


        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            // Wanneer de gamepad Back toets of de toetsenbord Escape toets wordt ingedrukt dan
            // Stopt het spel 
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                 (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

            // Roep de Update method aan van de Input class
            Input.Update();

            // Roep de Update(gameTime) method aan van het startScene-object
            this.gameState.Update(gameTime);



            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Purple);

            // Roep de Begin() method aan van het spriteBatch-object
            this.spriteBatch.Begin();

            // Roep de Draw(gameTime) method aan van het startScene-object
            this.gameState.Draw(gameTime);

            // Roep de End() method aan van het spriteBatch-object
            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}