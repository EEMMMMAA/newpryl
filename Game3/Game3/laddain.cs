using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3
{
    static class LaddaIn
    {
        public static Texture2D Spelare;

        public static void Ladda(ContentManager cont)
        {
            Spelare = cont.Load<Texture2D>("screenshot");
        }

    }
}
