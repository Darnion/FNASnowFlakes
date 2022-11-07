using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace FNASnowFlakes
{
    public class Background : GameObject
    {
        public Background()
        {
            position = new Vector2(0, 0);
            layerDepth = 1.0f;
        }

        public override void Initialize() => base.Initialize();

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("background", content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects)
        {
            base.Update(objects);
        }
    }
}
