using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3
{
    class bas
    {
        protected Vector2 pos;
        protected Texture2D tex;

        public void update() { }
        public virtual void Draw (SpriteBatch spritebatch)
        {
            spritebatch.Draw(tex, pos, Color.AliceBlue);
        }
        public Texture2D Tex
        {
            get { return tex; }
            set { tex = value; }
        }
        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }


        }
}
