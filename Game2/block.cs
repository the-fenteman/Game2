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
    class block : GameObject
    {
        public block()
        {
            location = new Vector2(100, 100);
        }

        public override void Update()
        {
            edge = new Rectangle((int)location.X, (int)location.Y, 25, 25);
        }

        public override void Draw(SpriteBatch sb, GraphicsDevice graphics)
        {
            sb.Draw(box, edge, Color.Red);
        }
    }
}
