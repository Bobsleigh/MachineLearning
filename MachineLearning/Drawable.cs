using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineLearning
{
    abstract public class Drawable
    {
        public virtual void Draw(Graphics graphics, Pen pen)
        {
        }

    }
}
