using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Game.Model
{
    class BallSimulation
    {
        bool checkX = false;
        bool checkY = false;
        float posX;
        float posY;
        float speedX;
        float speedY;
        Ball ball;

        internal void update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            posX = ball.GetX();
            posY = ball.GetY();
            speedX = ball.GetSpeedX();
            speedY = ball.GetSpeedY();

            if (checkX == true)
            {
                posX -= time * speedX;
                ball.setX(posX);
                if (posX < 0)
                {
                    checkX = false;
                }
            }
            else
            {
                posX += time * speedX;
                ball.setX(posX);
                if (posX > 0.82f)
                {
                    checkX = true;
                }
            }

            if (checkY == true)
            {
                posY -= time * speedY;
                ball.setY(posY);
                if (posY < 0)
                {
                    checkY = false;
                }
            }
            else
            {
                posY += time * speedY;
                ball.setY(posY);
                if (posY > 0.82f)
                {
                    checkY = true;
                }
            }

        }

        public BallSimulation(Ball theBall)
        {
            ball = theBall;
        }
    }
}
