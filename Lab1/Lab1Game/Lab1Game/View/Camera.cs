using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Game.View
{
    class Camera
    {
        private int sizeY;
        private int sizeX;
        private int borderSizeX;
        private int borderSizeY;
        private int maxSizeX;
        private int maxSizeY;

        public Camera(Viewport port)
        {
            this.sizeX = port.Width;
            this.sizeY = port.Height;
            this.maxSizeX = port.Width;
            this.maxSizeY = port.Height;
            this.borderSizeX = (int)(0.04 * this.sizeX);
            this.borderSizeY = (int)(0.04 * this.sizeY);
        }

        internal int LogConverterX(float logical)
        {
            int ret = (int)(logical * this.sizeX + borderSizeX);

            return ret;
        }

        internal int LogConverterY(float logical)
        {
            int ret = (int)(logical * this.sizeY + borderSizeY);

            return ret;
        }

        internal int LogConverterXNoBorder(float logical)
        {
            int ret = (int)(logical * this.sizeX);

            return ret;
        }

        internal int LogConverterYNoBorder(float logical)
        {
            int ret = (int)(logical * this.sizeY);

            return ret;
        }

        internal int ReversConverterX(float logical)
        {
            int ret = (int)(maxSizeX - (logical * sizeX));

            return ret;
        }

        internal int ReversConverterY(float logical)
        {
            int ret = (int)(maxSizeY - (logical * sizeY));

            return ret;
        }

        internal int ballSizeX() 
        {
            int ret = (int)(0.1 * this.sizeX);

            return ret;
        }

        internal int ballSizeY()
        {
            int ret = (int)(0.1 * this.sizeY);

            return ret;
        }

    }
}
