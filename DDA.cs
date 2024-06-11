using System;

namespace graphics_project
{
    public class DDA
    {
        public float X, Y, XEnd, YEnd;
        float dy, dx, m;
        public float cx, cy;
        public int speed = 10;
        public void calc()
        {
            dy = YEnd - Y;
            dx = XEnd - X;
            m = dy / dx;
            cx = X;
            cy = Y;
        }
        public bool CalcNextPoint()
        {
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (X < XEnd)
                {
                    cx += speed;
                    cy += m * speed;
                    if (cx >= XEnd && speed > 0)
                    {
                        speed *= -1;
                        return false;
                    }
                    else
                    {
                        if (speed < 0 && cx <= X)
                            speed *= -1;
                    }
                }
                else
                {
                    cx -= speed;
                    cy -= m * speed;
                    if (cx <= XEnd)
                    {
                        speed *= -1;
                        return false;
                    }
                    else
                    {
                        if (speed < 0 && cx >= X)
                            speed *= -1;
                    }
                }
            }
            else
            {
                if (Y < YEnd)
                {
                    cy += speed;
                    cx += 1 / m * speed;
                    if (cy >= YEnd && speed > 0)
                    {
                        speed *= -1;
                        return false;
                    }
                    else
                    {
                        if (speed < 0 && cy <= Y)
                            speed *= -1;
                    }
                }
                else
                {
                    cy -= speed;
                    cx -= 1 / m * speed;
                    if (cy <= YEnd)
                    {
                        speed *= -1;
                        return false;
                    }
                    else
                    {
                        if (speed < 0 && cy >= Y)
                            speed *= -1;
                    }
                }
            }
            return true;
        }

    }
}
