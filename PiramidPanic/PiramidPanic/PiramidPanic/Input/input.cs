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
    public static class Input
    {
        // field
        private static KeyboardState ks, oks;
        private static MouseState ms, oms;
        private static GamePadState gps, ogps;

        //constructor
        static Input()
        {
            ks = Keyboard.GetState();
        }

        public static void Update()
        {
            oks = ks;
            ks = Keyboard.GetState();
        }

        // dit is de edgedetrector voor een willekeurige toets op het toetsenboard

        public static bool EdgeDetectorKeyDown(Keys key)
        {
            return (ks.IsKeyDown(key) && oks.IsKeyUp(key));
        }
        
    }
}
