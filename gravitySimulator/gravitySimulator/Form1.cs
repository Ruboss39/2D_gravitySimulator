using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravitySimulator
{
    public partial class Form1 : Form
    {
        private bool launch = true;
        private bool iterations = false;
        private bool simulationGo = false;
        private bool collisionEnabled = false;
        private bool changeZoomWhilePaused = false;
        private int paddingK = 350;
        private double zoomFactor = 1d;

        List<CelestialBody> celestialBodies = new List<CelestialBody>();
        
        public Form1()
        {
            InitializeComponent();
            testPlanets();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int xPos = Cursor.Position.X - Location.X;
            int yPos = Cursor.Position.Y - Location.Y;

            generateBody(60d, 9d, (xPos - 5 - paddingK) / zoomFactor,(yPos - 27 - paddingK) / zoomFactor, 300 * zoomFactor, 300 * zoomFactor);
            changeZoomFactor();
            changeCollisionEnabled();
            launch = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Graphics g = e.Graphics;
            DoubleBuffered = true;

            if (launch)
            {
                launchUpdateDraw(g);

            } else if (iterations)
            {
                calculationUpdate(g);
            } else if(changeZoomWhilePaused)
            {
                launchUpdateDraw(g);
                changeZoomWhilePaused = false;
            }

        }

        private void launchUpdateDraw(Graphics g)
        {
            for (int i = 0; i < celestialBodies.Count; i++)
            {
                celestialBodies[i].drawObject(g);
            }
            launch = false;
        }

        private void calculationUpdate(Graphics g)
        {
            double[] mass = new double[celestialBodies.Count];
            double[] x = new double[celestialBodies.Count];
            double[] y = new double[celestialBodies.Count];
            double[] vx = new double[celestialBodies.Count];
            double[] vy = new double[celestialBodies.Count];
            double[] r = new double[celestialBodies.Count];


            for (int i = 0; i < celestialBodies.Count; i++)
            {
                mass[i] = celestialBodies[i].getMass();
                x[i] = celestialBodies[i].getLocation()[0];
                y[i] = celestialBodies[i].getLocation()[1];

                vx[i] = celestialBodies[i].getVelocity()[0];
                vy[i] = celestialBodies[i].getVelocity()[1];

                r[i] = celestialBodies[i].getRadius();
            }

            for (int i = 0; i < celestialBodies.Count; i++)
            {
                celestialBodies[i].AVcalculation(mass, x, y, vx, vy, r);
            }

            for (int i = 0; i < celestialBodies.Count; i++)
            {
                celestialBodies[i].updateLocation();
                celestialBodies[i].drawObject(g);
            }

        }

        private void changeCollisionEnabled()
        {
            for (int i = 0; i < celestialBodies.Count; i++)
            {
                celestialBodies[i].setCollisionEnabled(collisionEnabled);
            }
        }

        private void changeZoomFactor()
        {
            for (int i = 0; i < celestialBodies.Count; i++)
            {
                celestialBodies[i].setZoomFactor(zoomFactor);
            }
        }

        private int[] generateRandomColor(int radius)
        {
            Random rnd = new Random();
            int[] color = new int[3];

            if (radius < 510)
            {
                color[0] = rnd.Next(0, Math.Abs(255 - radius));
                color[1] = rnd.Next(0, Math.Abs(255 - radius));
                color[2] = rnd.Next(0, Math.Abs(255 - radius));
            }
            else
            {
                color[0] = rnd.Next(0, 255);
                color[1] = rnd.Next(0, 255);
                color[2] = rnd.Next(0, 255);
            }
            return color;
        }

        private void testPlanets()
        {

            //generateBody(1000000000000000000, 15, 0, 0, 0, 0);
            //generateBody(5000, 15, 0, 0, 200, 0);
            //generateBody(50, 12, 300, 0, 0, 0);
            //generateBody(5000, 15, 600, 0, -200, 0);
            //generateBody(1000000000000000, 6, 0, -260, 300, 0);
            //generateBody(1000000000000000, 6, 0, 260, 300, 0);
            generateBody(1000000000000000000, 15, -200, 0, 0, -150);
            generateBody(1000000000000000000, 15, 200, 0, 0, 150);
            //generateBody(100, 3, 0, -255, 400, 0);
        }

        private void generateBody(double mass, double radius, double locationX, double locationY, double velocityX, double velocityY)
        {
            CelestialBody newBody = new CelestialBody(mass, radius, locationX, locationY, velocityX, velocityY, generateRandomColor((int)radius));
            celestialBodies.Add(newBody);
        }

        private void launchLoop()
        {
            while(simulationGo)
            {
                Invalidate();
                Application.DoEvents();
            }
        }

        private void launchVoid()
        {
            launch = true;
            Invalidate();
            iterations = true;
            simulationGo = true;
            launchLoop();
        }

        private void StartClick_Click(object sender, EventArgs e)
        {
            launchVoid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopSimulation_Click(object sender, EventArgs e)
        {
            simulationGo = !simulationGo;
            changeButtonText();
            launchLoop();
        }

        private void changeButtonText()
        {
            if (stopSimulation.Text == "Pause Simulation")
            {
                stopSimulation.Text = "Play Simulation";
            } else
            {
                stopSimulation.Text = "Pause Simulation";
            }

        }
        private void zoomPaused()
        {
            if (!simulationGo)
            {
                changeZoomWhilePaused = true;
                Invalidate();
            }
        }

        private void zoomIn_button_Click(object sender, EventArgs e)
        {
            zoomFactor *= 1.1d;
            zoomIndicator();
            changeZoomFactor();
            zoomPaused();
        }

        private void zoomOut_button_Click(object sender, EventArgs e)
        {
            zoomFactor *= 0.9d;
            zoomIndicator();
            changeZoomFactor();
            zoomPaused();
        }

        private void zoomIndicator()
        {
            zoomTextBox.Text = (Math.Round(100 * zoomFactor / 1d)).ToString() + "%";
        }

        private void zoomSet_button_Click(object sender, EventArgs e)
        {
            double temp;
            bool eligible = double.TryParse(zoomTextBox.Text.Split('%')[0], out temp);

            if(eligible)
            {
                zoomFactor = temp / 100;
                changeZoomFactor();
                zoomIndicator();
                zoomPaused();
            } else
            {
                zoomIndicator();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            collisionEnabled = false;
            changeCollisionEnabled();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            collisionEnabled = true;
            changeCollisionEnabled();
        }
    }
}
