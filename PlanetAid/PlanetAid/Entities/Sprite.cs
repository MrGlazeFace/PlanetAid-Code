﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetAid.Entities
{
    public class Sprite
    {
        public Texture2D Img;
        public float rotation = 0;
        public string ImgName;
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 origin;
        public Color color=Color.White;
        public bool visible=true;
        public Rectangle myspace
        {
            get
            {
                Rectangle myr = new Rectangle((int)position.X - (int)origin.X, (int)position.Y - (int)origin.Y, Img.Width, Img.Height);
                return myr;
            }
        }

        public Sprite()
        {
        }
        public virtual void Load(ContentManager content)
        {
            Img = content.Load<Texture2D>(ImgName);
        }
        public virtual void Update(TimeSpan ts)
        {
            position += velocity * (float)ts.TotalSeconds;
        }
        public virtual void Draw(SpriteBatch sb)
        {
            if (visible == true)
            {
                sb.Draw(Img, new Rectangle((int)position.X, (int)position.Y, Img.Width, Img.Height), null, color, rotation, origin, SpriteEffects.None, 0);
            }
        }
    }
}
