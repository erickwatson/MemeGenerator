using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace MemeGenerator
{
    public partial class mainWindow : Form
    {



        public mainWindow()
        {
            InitializeComponent();
        }

        private void picturePlacer1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void picturePlacer1_MouseDown(object sender, MouseEventArgs e)
        {

        }



        private void picturePlacer_DragEnter(object sender, DragEventArgs e)
        {

        }




        private void picturePlacer_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.CheckFileExists == true)
                {
                    Image image = Image.FromFile(dlg.FileName);
                    picturePlacer1.BackgroundImage = image;

                }
            }
        }

        private void loadImage()
        {


        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            PicturePlacer.PicturePlacer.MemeText memeText = new PicturePlacer.PicturePlacer.MemeText();
            memeText.text = textEntry.Text;
            memeText.position = new Point(50, 50);
            picturePlacer1.texts.Add(memeText);
            picturePlacer1.Invalidate();
            // Add it to the ListBox
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = memeText.text;
            listView1.Items.Add(listViewItem);
        }
    }
}


