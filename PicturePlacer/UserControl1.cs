using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace PicturePlacer
{
    public partial class PicturePlacer: UserControl
    {

        public class MemeText
        {
            public int ID;
            public string text;
            public Point position;
        };

        public static bool InDistance(Point Old, Point Current, int distance)
        {
            int diffX = Math.Abs(Old.X - Current.X);
            int diffY = Math.Abs(Old.Y - Current.Y);
            return diffX <= distance && diffY <= distance;
        }
        // banging head on this:
        // https://stackoverflow.com/questions/13032331/determine-if-two-points-are-near


        public List<MemeText> texts= new List<MemeText>();

        // the index of the memetext we're currently dragging around or editing
        int currentIndex = -1;

        public PicturePlacer()
        {
            InitializeComponent();
            MemeText text = new MemeText();
            //text.text = "hello";
            //text.position = new Point(100, 100);
            //texts.Add(text);
        }

        


        private void PicturePlacer_Load(object sender, EventArgs e)
        {

        }

        private void PicturePlacer_Paint(object sender, PaintEventArgs e)
        {
            foreach (MemeText mt in texts)
            {
                e.Graphics.DrawString(mt.text, SystemFonts.MenuFont, SystemBrushes.ControlDarkDark, mt.position);
            }
        }

        private void PicturePlacer_MouseDown(object sender, MouseEventArgs e)
        {
            currentIndex = -1;
            for (int i = 0; i < texts.Count; i++)
            {
                // Want to compare these 
                if (e.Location == texts[currentIndex].position)
                {
                    currentIndex = i;
                }
            }
        }

        private void PicturePlacer_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentIndex != -1)
            {
                texts[currentIndex].position = e.Location;
            }
        }

        private void PicturePlacer_MouseUp(object sender, MouseEventArgs e)
        {
            currentIndex = -1;
        }
    }
}
