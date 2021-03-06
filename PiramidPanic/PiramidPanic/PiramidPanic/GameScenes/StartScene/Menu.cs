﻿using System;
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
    public class Menu
    {
        #region Fields
        private enum Button { start, load, help, edit, score,  quit };
        private PyramidPanic game;
        private Images startButton, loadButton, helpButton, scoresButton, quitButton;

        // Maak een List<Image> waar we Image objecten in kunnen stoppen, in dit geval de buttons
        private List<Images> buttonList;
        private int top = 430, left = 10, space = 130;
        #endregion

        #region Properties

        #endregion


        #region Constructor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }
        #endregion

        #region Initialize
        public void Initialize()
        {
            this.LoadContent();
        }
        #endregion

        #region LoadContent
        public void LoadContent()
        {
            this.startButton =
                new Images(this.game, @"StartScene\Button_start", new Vector2(this.left, this.top));
            this.loadButton =
                new Images(this.game, @"StartScene\Button_load", new Vector2(this.left + this.space, this.top));
            this.helpButton =
                new Images(this.game, @"StartScene\Button_help", new Vector2(this.left + 2 * this.space, this.top));
            this.scoresButton =
                new Images(this.game, @"StartScene\Button_scores", new Vector2(this.left + 3 * this.space, this.top));
            this.quitButton =
                new Images(this.game, @"StartScene\Button_quit", new Vector2(this.left + 4 * this.space, this.top));

            this.startButton.Color = Color.White;
            this.loadButton.Color = Color.Gold;
            // Maak een nieuw object van het type List<Image>
            this.buttonList = new List<Images>();

            // Voeg nu de gemaakte Image objecten toe aan this.buttonList
            this.buttonList.Add(this.startButton);
            this.buttonList.Add(this.loadButton);
            this.buttonList.Add(this.helpButton);
            this.buttonList.Add(this.scoresButton);
            this.buttonList.Add(this.quitButton);
        }
        #endregion

        #region Update
        public void Update(GameTime gametime)
        {
            if (Input.EdgeDetectorKeyDown(Keys.Right))
            {
                this.startButton.Color = Color.White;
                this.loadButton.Color = Color.Gold;
            }
            
        }
        #endregion


        #region Draw
        public void Draw(GameTime gameTime)
        {
            foreach (Images button in this.buttonList)
            {
                button.Draw(gameTime);
            }
        }
        #endregion
    }
}