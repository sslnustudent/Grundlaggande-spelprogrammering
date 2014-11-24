using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Game.Model
{
    class Ball
    {
        float speedX = 0.5f;
        float speedY = 0.6f;
        float posX = 0.0f;
        float posY = 0.5f;

        internal float GetX() 
        {
            return posX;
        }

        internal float GetY() 
        {
            return posY;
        }

        internal void setX(float x) 
        {
            posX = x;
        }
        internal void setY(float y) 
        {
            posY = y;
        }

        internal float GetSpeedX()
        {
            return speedX;
        }

        internal float GetSpeedY()
        {
            return speedY;
        }

    }
}
