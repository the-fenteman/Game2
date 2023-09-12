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
    class player : GameObject
    {
        public Vector2 movement = new Vector2(0, 0);
        public direction playerdir;

        public enum direction
        {
            up,down,left,right
        }


        public player()
        {
            location = new Vector2(200, 200);
        }

        public override void Update()
        {
            edge = new Rectangle((int)location.X, (int)location.Y, 25, 25);

            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.W))
            {
                movement.Y = -1;
                playerdir = direction.up;
            }
            if (ks.IsKeyDown(Keys.S))
            {
                movement.Y = 1;
                playerdir = direction.down;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                movement.X = 1;
                playerdir = direction.right;
            }
            if (ks.IsKeyDown(Keys.A))
            {
                movement.X = -1;
                playerdir = direction.left;
            }

            location += movement;
            movement = new Vector2(0, 0);
        }
        public override void Draw(SpriteBatch sb, GraphicsDevice graphics)
        {
            sb.Draw(box, edge, Color.Blue);
        }
    }
}
