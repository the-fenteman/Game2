using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game2
{
    class GameObject
    {
        public Rectangle edge = new Rectangle();
        public Vector2 location;
        public Texture2D box;

        public GameObject()
        {
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch sb, GraphicsDevice graphics)
        {

        }
    }
}
