using System;
using System.Drawing;
using System.Windows.Forms;

namespace DANTAIRE
{
    public static class TextHight
    {
        public static int gettexthight(Label a)
        {
            using (Graphics g = a.CreateGraphics())
            {
                SizeF size = g.MeasureString(a.Text, a.Font, 264);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
