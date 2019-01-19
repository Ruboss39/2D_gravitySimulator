using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gravitySimulator
{
    class CelestialBody
    {
        private double G = 6.673 * Math.Pow(10, -11);
        private double timeUnit = 0.001d;
        private double mass;
        private double radius;
        private double locationX;
        private double locationY;
        private int[] color;
        private double velocityX;
        private double velocityY;
        private double velocityTot;
        private double accelerationX;
        private double accelerationY;
        private bool drawVelVec;
        private bool drawAccVec;
        private int paddingK = 350;
        private double zoomFactor = 1d;
        private bool enableCollision = false;

        public CelestialBody(double mass, double radius, double locationX, double locationY, double velocityX, double velocityY, int[] color)
        {
            this.mass = mass;
            this.radius = radius;
            this.locationX = locationX;
            this.locationY = locationY;
            this.velocityX = velocityX;
            this.velocityY = velocityY;
            this.color = color;
        }

        private double calculationX(double mass, double x1, double y1, double x2, double y2)
        {
            double distance = (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double temp = G * mass * (x2 - x1) / (Math.Pow(distance, 3));

            return temp;
        }

        private double calculationY(double mass, double x1, double y1, double x2, double y2)
        {
            double distance = (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double temp = G * mass * (y2 -y1) / (Math.Pow(distance,3));

            return temp;
        }

        private double collisionX(double x1, double x2, double mass1, double mass2, double v0, double u0, double r1, double r2)
        {
            double velocity =  ((2 * u0 + v0 * (mass1 / mass2 - 1)) / (1 + mass1 / mass2));
            return velocity;
        }

        private double collisionY(double y1, double y2, double mass1, double mass2, double v0, double u0, double r1, double r2)
        {
            double velocity =  ((2 * u0 + v0 * (mass1 / mass2 - 1)) / (1 + mass1 / mass2));
            return velocity;
        }

        private bool collisionTrue(double x1, double x2, double y1, double y2, double r1, double r2)
        {
            bool collision = false;

            if (Math.Sqrt(Math.Pow(x1 - x2 , 2)) <= r1 +r2 && Math.Sqrt(Math.Pow(y1 - y2, 2)) <= r1 + r2)
            {
                collision = true;
            }
            return collision;
        }

        public void AVcalculation(double[] mass, double[] locationX, double[] locationY, double[] velX, double[] velY, double[] radius)
        {
            double accX = 0;
            double accY = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (this.mass == mass[i] && this.locationX == locationX[i] && this.locationY == locationY[i])
                {
                    continue;
                } else
                {
                    accX += calculationX(mass[i], this.locationX, this.locationY, locationX[i], locationY[i]);
                    accY += calculationY(mass[i], this.locationX, this.locationY, locationX[i], locationY[i]);

                    if (enableCollision)
                    {
                        if (collisionTrue(this.locationX, locationX[i], this.locationY, locationY[i], this.radius, radius[i]))
                        {
                            this.velocityX = collisionX(this.locationX, locationX[i], this.mass, mass[i], velocityX, velX[i], this.radius, radius[i]);
                            this.velocityY = collisionY(this.locationY, locationY[i], this.mass, mass[i], velocityY, velY[i], this.radius, radius[i]);
                        }
                    }
                }
            }
            velocityX += accX * timeUnit;
            velocityY += accY * timeUnit;
            accelerationX = accX;
            accelerationY = accY;
        }

        public void updateLocation()
        {
            this.locationX += velocityX * timeUnit;
            this.locationY += velocityY * timeUnit;
        }

        public double getRadius()
        {
            return this.radius;
        }

        public double getMass()
        {
            return this.mass;
        }
        public double[] getLocation()
        {
            double[] temp = { locationX, locationY };
            return temp;
        }

        public double[] getVelocity()
        {
            double[] temp = { velocityX, velocityY };
            return temp;
        }

        public double getZoomFactor()
        {
            return zoomFactor;
        }

        public bool getCollisionEnabled()
        {
            return enableCollision;
        }

        public void setCollisionEnabled(bool inputBool)
        {
            enableCollision = inputBool;
        }

        public void setZoomFactor(double zoomFactor)
        {
            this.zoomFactor = zoomFactor;
        }

        public void drawObject(Graphics g)
        {
            Color objectColor = Color.FromArgb(color[0], color[1], color[2]);
            SolidBrush objectFillColor = new SolidBrush(objectColor);
            Pen outline = new Pen(objectColor);

            g.FillEllipse(objectFillColor, (int)((locationX - radius) * zoomFactor) + paddingK,(int)((locationY - radius) * zoomFactor)  + paddingK, (float)(radius * 2 * zoomFactor), (float)(radius * 2 * zoomFactor));

            drawObjectVector(g);
            drawACCObjectVector(g);
        }

        private void drawObjectVector(Graphics g)
        {
            Color objectColor = Color.FromArgb(0, 0, 0);
            SolidBrush objectFillColor = new SolidBrush(objectColor);
            Pen outline = new Pen(objectColor);

            Point point2 = new Point { X = (int)(locationX * zoomFactor) + (int)(velocityX/5 * zoomFactor) + paddingK, Y = (int)(locationY * zoomFactor) + (int)(velocityY/5 * zoomFactor) + paddingK};
            Point point1 = new Point { X = (int)(locationX * zoomFactor) + paddingK , Y = (int)(locationY * zoomFactor) + paddingK };

            g.DrawLine(outline, point1, point2);
        }

        private void drawACCObjectVector(Graphics g)
        {
            Color objectColor = Color.FromArgb(0, 254, 240);
            SolidBrush objectFillColor = new SolidBrush(objectColor);
            Pen outline = new Pen(objectColor);

            Point point2 = new Point { X = (int)(locationX * zoomFactor) + (int)(accelerationX / 20 * zoomFactor) + paddingK, Y = (int)(locationY * zoomFactor) + (int)(accelerationY / 20 * zoomFactor) + paddingK };
            Point point1 = new Point { X = (int)(locationX * zoomFactor) + paddingK, Y = (int)(locationY * zoomFactor) + paddingK };

            g.DrawLine(outline, point1, point2);
        }
    }
}