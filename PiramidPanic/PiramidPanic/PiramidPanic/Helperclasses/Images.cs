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
    public class Images
    {
        #region Fields
        /*
         * field zijn private en zijn alleen beschikbaar binnen de class. ze worden ook wel class variablen genoemd
         */
        /*
         * met een Texture2D kun je een plaatje zichtbaar maaken.
         */
        private Texture2D texture;

        /*
         * de rectangle gebruiken we voor colitiondetection
         */

        private Rectangle rectangle;

        //de game instantie word als field geregistreerd
        private PyramidPanic game;

        //we maken een variable van het type color en geven het de standwaarde Color.White
        private Color color = Color.White;


        #endregion 

        #region Properties
        public Color Color
        {
            set { this.color = value; }
        }

        #endregion

        #region Constructor

        /*
         * dit is de constructor van de Image class, hij is meestal public en heeft dezelfde naam als de classe
         */
        public Images(PyramidPanic game, string pathNameAsset, Vector2 position)
        {
            //geef de het game weer
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(pathNameAsset);
            this.rectangle = new Rectangle((int)position.X,
                                           (int)position.Y,
                                           this.texture.Width,
                                           this.texture.Height);

        }
        #endregion

        #region Update
        
        #endregion

        #region Draw

        public void Draw(GameTime gametime)
        {
            this.game.SpriteBatch.Draw(this.texture, this.rectangle, this.color);
        
        }
        #endregion
    }
}
