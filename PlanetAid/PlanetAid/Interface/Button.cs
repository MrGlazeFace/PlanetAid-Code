﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetAid
{
    public class Button
    {
        private Texture2D image;
        private string imageName;
        public Rectangle bRect;
        public bool clicked=false;

        public Button(int x, int y, int width, int height, string name)
        {
            imageName = name;
            bRect.X = x;
            bRect.Y = y;
            bRect.Width = width;
            bRect.Height =height;
            clicked = false;
        }

        public void Load(ContentManager content)
        {
            image = content.Load<Texture2D>(imageName);
        }

        public void Update()
        {
            MouseState mouse = Mouse.GetState();
            Rectangle clickArea = new Rectangle(mouse.X, mouse.Y, 1, 1);
            if (clickArea.Intersects(bRect) && mouse.LeftButton == ButtonState.Pressed)
                clicked = true;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, bRect, Color.White);
        }
    }
}