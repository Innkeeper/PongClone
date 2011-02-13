using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class Input
    {
        private KeyboardState keyboardState;
        private KeyboardState lastState;

        public Input()
        {
            keyboardState = Keyboard.GetState();
            lastState = keyboardState;
        }

        public void Update()
        {
            lastState = keyboardState;
            keyboardState = Keyboard.GetState();
        }

        public bool RightUp
        {
            get
            {
                if (Game1.gamestate == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.Up) && lastState.IsKeyUp(Keys.Up);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.Up);
                }
            }
        }

        public bool RightDown
        {
            get
            {
                if (Game1.gamestate == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.Down) && lastState.IsKeyUp(Keys.Down);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.Down);
                }
            }
        }

        public bool LeftUp
        {
            get
            {
                if (Game1.gamestate == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.W) && lastState.IsKeyUp(Keys.W);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.W);
                }
            }
        }

        public bool LeftDown
        {
            get
            {
                if (Game1.gamestate == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.S) && lastState.IsKeyUp(Keys.S);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.S);
                }
            }
        }

        public bool MenuSelect
        {
            get
            {
                return keyboardState.IsKeyDown(Keys.Enter) && lastState.IsKeyUp(Keys.Enter);
            }
        }
    }
}
