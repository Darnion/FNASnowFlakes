using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FNASnowFlakes
{
    public class SnowFlake : GameObject
    {
        private bool lever = false;
        public SnowFlake()
        {

        }

        public SnowFlake(Vector2 inputPosition, float inputScale)
        {
            position = inputPosition;
            scale = inputScale;
        }

        public override void Initialize() => base.Initialize();

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("snowflake", content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects)
        {
            CheckInput();
            if (lever)
            {
                position.Y += scale * 100;
                if (position.Y > 900)
                {
                    position.Y = -scale * image.Height;
                }
            }
            base.Update(objects);
        }

        private void CheckInput()
        {
            if (Input.MouseLeftClicked())
            {
                lever = !lever;
            }
        }
    }
}
