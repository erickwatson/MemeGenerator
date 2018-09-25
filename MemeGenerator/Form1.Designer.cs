namespace MemeGenerator
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textEntry = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.layerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.layerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrowUpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picturePlacer1 = new PicturePlacer.PicturePlacer();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(516, 520);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textEntry
            // 
            this.textEntry.Location = new System.Drawing.Point(516, 451);
            this.textEntry.Multiline = true;
            this.textEntry.Name = "textEntry";
            this.textEntry.Size = new System.Drawing.Size(379, 63);
            this.textEntry.TabIndex = 4;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(516, 408);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(820, 520);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.layerNumber,
            this.layerID,
            this.xPos,
            this.yPos});
            this.listView1.Location = new System.Drawing.Point(542, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 349);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // layerNumber
            // 
            this.layerNumber.Text = "Layer #";
            this.layerNumber.Width = 52;
            // 
            // layerID
            // 
            this.layerID.Text = "ID";
            this.layerID.Width = 214;
            // 
            // xPos
            // 
            this.xPos.Text = "(x)";
            this.xPos.Width = 41;
            // 
            // yPos
            // 
            this.yPos.Text = "(y)";
            this.yPos.Width = 39;
            // 
            // arrowUpButton
            // 
            this.arrowUpButton.Location = new System.Drawing.Point(514, 53);
            this.arrowUpButton.Name = "arrowUpButton";
            this.arrowUpButton.Size = new System.Drawing.Size(22, 23);
            this.arrowUpButton.TabIndex = 8;
            this.arrowUpButton.Text = "↑";
            this.arrowUpButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "↓";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picturePlacer1
            // 
            this.picturePlacer1.AllowDrop = true;
            this.picturePlacer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picturePlacer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlacer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.picturePlacer1.Image = null;
            this.picturePlacer1.Location = new System.Drawing.Point(24, 53);
            this.picturePlacer1.Name = "picturePlacer1";
            this.picturePlacer1.Size = new System.Drawing.Size(431, 490);
            this.picturePlacer1.TabIndex = 0;
            this.picturePlacer1.Load += new System.EventHandler(this.picturePlacer1_Load);
            this.picturePlacer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturePlacer_DragDrop);
            this.picturePlacer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturePlacer_DragEnter);
            // 
            // mainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrowUpButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textEntry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.picturePlacer1);
            this.Name = "mainWindow";
            this.Text = "Meme Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PicturePlacer.PicturePlacer picturePlacer1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textEntry;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader layerNumber;
        private System.Windows.Forms.ColumnHeader layerID;
        private System.Windows.Forms.ColumnHeader xPos;
        private System.Windows.Forms.ColumnHeader yPos;
        private System.Windows.Forms.Button arrowUpButton;
        private System.Windows.Forms.Button button1;
    }
}

