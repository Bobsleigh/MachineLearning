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

            currentGen.Add(new Rocket(50,50));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateRockets();
            Draw();

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
                rocket.Update();
                graphics.Clear(Color.White);
            }
        }
    }
}
