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
            base.Update(objects);
        }
    }
}
