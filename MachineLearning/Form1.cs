using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen blackPen;
        Timer timer = new Timer();
        List<Rocket> currentGen = new List<Rocket>();
        Target target = new Target(50,50);
        int lifespan = 200;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            blackPen = new Pen(Brushes.Black, 4);
            graphics.DrawRectangle(blackPen, new Rectangle(10, 10, 20, 20));

            timer.Interval = 16;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            for(int i=0; i<15;i++)
            {
                currentGen.Add(new Rocket(new RndVector2D(), lifespan));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateRockets();
            Draw();
            count++;
            if (count >= lifespan)
            {
                count = 0;
                nextPopulation();
            }
        }

        private void nextPopulation()
        {
            double maxFit = 0;
            for (int i = 0; i < 15; i++)
            {
                currentGen[i].calcFitness(target);
                if (currentGen[i].finalFitness > maxFit)
                {
                    maxFit = currentGen[i].finalFitness;
                }
            }

            //Build the mating pool
            List<Rocket> matingPool = new List<Rocket>();
            for (int i = 0; i < 15; i++)
            {
                double n = (currentGen[i].finalFitness / maxFit) * 500; //Nb of time a rocket is in the mating pool
                for (int j = 0; j < n; j++)
                {
                    matingPool.Add(currentGen[i]);
                }
            }

            currentGen.Clear();
            for (int i = 0; i < 15; i++)
            {
                Rocket parentA = matingPool[RandomGen.rnd.Next(0, matingPool.Count)];
                Rocket parentB = matingPool[RandomGen.rnd.Next(0, matingPool.Count)];
                Rocket child = new Rocket(lifespan);
                child.DNA = parentA.DNA.CrossOver(parentB.DNA);
                currentGen.Add(child);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawRectangle(blackPen, new Rectangle(10, 10, 20, 20));
            currentGen[0].Rotate(-45);
        }

        private void Draw()
        {
            foreach(Rocket rocket in currentGen)
            {
                rocket.Draw(graphics, blackPen);
                target.Draw(graphics, blackPen);
            }
        }

        private void UpdateRockets()
        {
            foreach (Rocket rocket in currentGen)
            {
                rocket.Update(count);
                CheckCollisions(rocket);
            }
            graphics.Clear(Color.White);
        }

        private void CheckCollisions(Rocket rocket)
        {
            if (rocket.Pos.X < target.x + target.width && rocket.Pos.X > target.x)
            {
                if (rocket.Pos.Y < target.y + target.height && rocket.Pos.Y > target.y && !rocket.Completed)
                {
                    rocket.Completed = true;
                    rocket.TimeCompleted = count;
                }
            }
        }
    }
}
