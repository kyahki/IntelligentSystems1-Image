﻿namespace CS345
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openForImage2ToolStripMenuItem = new ToolStripMenuItem();
            saveForImage3ToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            mirrorHoToolStripMenuItem = new ToolStripMenuItem();
            mirrorVerticalToolStripMenuItem = new ToolStripMenuItem();
            serpiaToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            smoothToolStripMenuItem = new ToolStripMenuItem();
            guassianToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            horzVerticalToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox3 = new PictureBox();
            openFileDialog2 = new OpenFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            button1 = new Button();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, openForImage2ToolStripMenuItem, saveForImage3ToolStripMenuItem, cameraToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(159, 22);
            openToolStripMenuItem.Text = "OpenForImage1";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(159, 22);
            saveToolStripMenuItem.Text = "SaveForImage2";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openForImage2ToolStripMenuItem
            // 
            openForImage2ToolStripMenuItem.Name = "openForImage2ToolStripMenuItem";
            openForImage2ToolStripMenuItem.Size = new Size(159, 22);
            openForImage2ToolStripMenuItem.Text = "OpenForImage2";
            openForImage2ToolStripMenuItem.Click += openForImage2ToolStripMenuItem_Click;
            // 
            // saveForImage3ToolStripMenuItem
            // 
            saveForImage3ToolStripMenuItem.Name = "saveForImage3ToolStripMenuItem";
            saveForImage3ToolStripMenuItem.Size = new Size(159, 22);
            saveForImage3ToolStripMenuItem.Text = "SaveForImage3";
            saveForImage3ToolStripMenuItem.Click += saveForImage3ToolStripMenuItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(159, 22);
            cameraToolStripMenuItem.Text = "Camera";
            cameraToolStripMenuItem.Click += cameraToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, greyscalingToolStripMenuItem, inversionToolStripMenuItem, mirrorHoToolStripMenuItem, mirrorVerticalToolStripMenuItem, serpiaToolStripMenuItem, histogramToolStripMenuItem, smoothToolStripMenuItem, guassianToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem, edgeDetectToolStripMenuItem, verticalToolStripMenuItem, horizontalOnlyToolStripMenuItem, horzVerticalToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(28, 20);
            dIPToolStripMenuItem.Text = "O";
            dIPToolStripMenuItem.Click += dIPToolStripMenuItem_Click;
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(180, 22);
            pixelCopyToolStripMenuItem.Text = "pixel copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // greyscalingToolStripMenuItem
            // 
            greyscalingToolStripMenuItem.Name = "greyscalingToolStripMenuItem";
            greyscalingToolStripMenuItem.Size = new Size(180, 22);
            greyscalingToolStripMenuItem.Text = "Grayscaling";
            greyscalingToolStripMenuItem.Click += greyscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(180, 22);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // mirrorHoToolStripMenuItem
            // 
            mirrorHoToolStripMenuItem.Name = "mirrorHoToolStripMenuItem";
            mirrorHoToolStripMenuItem.Size = new Size(180, 22);
            mirrorHoToolStripMenuItem.Text = "Mirror Horizontal";
            mirrorHoToolStripMenuItem.Click += mirrorHoToolStripMenuItem_Click;
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            mirrorVerticalToolStripMenuItem.Size = new Size(180, 22);
            mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            mirrorVerticalToolStripMenuItem.Click += mirrorVerticalToolStripMenuItem_Click;
            // 
            // serpiaToolStripMenuItem
            // 
            serpiaToolStripMenuItem.Name = "serpiaToolStripMenuItem";
            serpiaToolStripMenuItem.Size = new Size(180, 22);
            serpiaToolStripMenuItem.Text = "Serpia";
            serpiaToolStripMenuItem.Click += serpiaToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(180, 22);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // smoothToolStripMenuItem
            // 
            smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            smoothToolStripMenuItem.Size = new Size(180, 22);
            smoothToolStripMenuItem.Text = "Smooth";
            smoothToolStripMenuItem.Click += smoothToolStripMenuItem_Click;
            // 
            // guassianToolStripMenuItem
            // 
            guassianToolStripMenuItem.Name = "guassianToolStripMenuItem";
            guassianToolStripMenuItem.Size = new Size(180, 22);
            guassianToolStripMenuItem.Text = "Guassian";
            guassianToolStripMenuItem.Click += guassianToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(180, 22);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(180, 22);
            meanRemovalToolStripMenuItem.Text = "MeanRemoval";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(180, 22);
            embossingToolStripMenuItem.Text = "Embossing";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // edgeDetectToolStripMenuItem
            // 
            edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            edgeDetectToolStripMenuItem.Size = new Size(180, 22);
            edgeDetectToolStripMenuItem.Text = "EdgeDetect";
            edgeDetectToolStripMenuItem.Click += edgeDetectToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(180, 22);
            verticalToolStripMenuItem.Text = "VerticalOnly";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(180, 22);
            horizontalOnlyToolStripMenuItem.Text = "HorizontalOnly";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // horzVerticalToolStripMenuItem
            // 
            horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            horzVerticalToolStripMenuItem.Size = new Size(180, 22);
            horzVerticalToolStripMenuItem.Text = "HorzVertical";
            horzVerticalToolStripMenuItem.Click += horzVerticalToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(180, 22);
            allDirectionsToolStripMenuItem.Text = "AllDirections";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(375, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(732, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(298, 274);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk_2;
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.FileOk += saveFileDialog2_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(839, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Subtract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(180, 22);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 492);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "fa";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem mirrorHoToolStripMenuItem;
        private ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog2;
        private ToolStripMenuItem openForImage2ToolStripMenuItem;
        private ToolStripMenuItem saveForImage3ToolStripMenuItem;
        private SaveFileDialog saveFileDialog2;
        private ToolStripMenuItem serpiaToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem smoothToolStripMenuItem;
        private ToolStripMenuItem guassianToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem edgeDetectToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem horzVerticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
    }
}
