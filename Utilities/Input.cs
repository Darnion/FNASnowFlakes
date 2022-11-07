using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FNASnowFlakes
{
    public static class Input //Static classes can easily be accessed anywhere in our codebase. They always stay in memory so you should only do it for universal things like input.
    {
        private static KeyboardState keyboardState = Keyboard.GetState();
        private static KeyboardState lastKeyboardState;

        private static MouseState mouseState;
        private static MouseState lastMouseState;

        public static void Update()
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            lastMouseState = mouseState;
            mouseState = Mouse.GetState();
        }

        /// <summary>
        /// Checks if key is currently pressed.
        /// </summary>
        public static bool IsKeyDown(Keys input)
        {
            return keyboardState.IsKeyDown(input);
        }

        /// <summary>
        /// Checks if key is currently up.
        /// </summary>
        public static bool IsKeyUp(Keys input)
        {
            return keyboardState.IsKeyUp(input);
        }

        /// <summary>
        /// Checks if key was just pressed.
        /// </summary>
        public static bool KeyPressed(Keys input)
        {
            if (keyboardState.IsKeyDown(input) == true && lastKeyboardState.IsKeyDown(input) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns whether or not the left mouse button is being pressed.
        /// </summary>
        public static bool MouseLeftDown()
        {
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns whether or not the right mouse button is being pressed.
        /// </summary>
        public static bool MouseRightDown()
        {
            if (mouseState.RightButton == ButtonState.Pressed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the left mouse button was clicked.
        /// </summary>
        public static bool MouseLeftClicked()
        {
            if (mouseState.LeftButton == ButtonState.Pressed && lastMouseState.LeftButton == ButtonState.Released)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the right mouse button was clicked.
        /// </summary>
        public static bool MouseRightClicked()
        {
            if (mouseState.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
