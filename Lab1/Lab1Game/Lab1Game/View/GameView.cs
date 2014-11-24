using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Lab1Game.Model;

namespace Lab1Game.View
{
    class GameView
    {
        private Model.Ball model;
        private View.Camera cam;
        private SpriteBatch spriteBatch;
        private Texture2D balltexture;
        private Texture2D lvltexture;
        private const float scaleX = 64.0f;
        private const float scaleY = 64.0f;
        private const float displaceX = 2.0f;
        private const float displaceY = 2.0f;

        public GameView(Lab1Game.Model.Ball model, SpriteBatch spriteBatch, Texture2D textureball, Texture2D texturelevel, Camera cam)
        {
            this.model = model;
            this.spriteBatch = spriteBatch;
            this.balltexture = textureball;
            this.lvltexture = texturelevel;
            this.cam = cam;
        }

        internal void Draw(Ball ball)
        {
            float logicalX = this.model.GetX();
            float logicalY = this.model.GetY();

            int screenX = cam.LogConverterX(logicalX);
            int screenY = cam.LogConverterY(logicalY);

            Rectangle top = new Rectangle(cam.LogConverterXNoBorder(0.03f), cam.LogConverterYNoBorder(0.03f), cam.LogConverterXNoBorder(0.94f), cam.LogConverterYNoBorder(0.01f));
            Rectangle bottom = new Rectangle(cam.LogConverterXNoBorder(0.03f), cam.LogConverterYNoBorder(0.96f), cam.LogConverterXNoBorder(0.94f), cam.LogConverterYNoBorder(0.01f));
            Rectangle left = new Rectangle(cam.LogConverterXNoBorder(0.03f), cam.LogConverterYNoBorder(0.03f), cam.LogConverterXNoBorder(0.01f), cam.LogConverterYNoBorder(0.93f));
            Rectangle right = new Rectangle(cam.LogConverterXNoBorder(0.96f), cam.LogConverterYNoBorder(0.03f), cam.LogConverterXNoBorder(0.01f), cam.LogConverterYNoBorder(0.93f));

            Rectangle ballSquare = new Rectangle(screenX, screenY, cam.ballSizeX(), cam.ballSizeY());

            spriteBatch.Begin();
            spriteBatch.Draw(lvltexture, top, Color.White);
            spriteBatch.Draw(lvltexture, bottom, Color.White);
            spriteBatch.Draw(lvltexture, left, Color.White);
            spriteBatch.Draw(lvltexture, right, Color.White);
            spriteBatch.Draw(balltexture, ballSquare, Color.White);
            spriteBatch.End();

        }

    }
}
