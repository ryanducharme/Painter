
namespace Painter
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.brushSizeTextBox = new System.Windows.Forms.TextBox();
            this.labelBrushSize = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.incrementTextBox = new System.Windows.Forms.TextBox();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(406, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 1;
            this.button1.Tag = "Red";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ColorSelectorButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(432, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 2;
            this.button2.Tag = "Green";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ColorSelectorButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(458, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 3;
            this.button3.Tag = "Blue";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ColorSelectorButton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(484, 638);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 4;
            this.button4.Tag = "Black";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ColorSelectorButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 692);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(616, 636);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // brushSizeTextBox
            // 
            this.brushSizeTextBox.Location = new System.Drawing.Point(510, 636);
            this.brushSizeTextBox.Name = "brushSizeTextBox";
            this.brushSizeTextBox.Size = new System.Drawing.Size(34, 23);
            this.brushSizeTextBox.TabIndex = 10;
            this.brushSizeTextBox.Text = "4";
            // 
            // labelBrushSize
            // 
            this.labelBrushSize.AutoSize = true;
            this.labelBrushSize.Location = new System.Drawing.Point(550, 639);
            this.labelBrushSize.Name = "labelBrushSize";
            this.labelBrushSize.Size = new System.Drawing.Size(60, 15);
            this.labelBrushSize.TabIndex = 11;
            this.labelBrushSize.Text = "Brush Size";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Text = "Save";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 27);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 13;
            this.button5.Text = "Go!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(817, 53);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(110, 23);
            this.lengthTextBox.TabIndex = 14;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(817, 78);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(110, 23);
            this.widthTextBox.TabIndex = 15;
            // 
            // incrementTextBox
            // 
            this.incrementTextBox.Location = new System.Drawing.Point(817, 103);
            this.incrementTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incrementTextBox.Name = "incrementTextBox";
            this.incrementTextBox.Size = new System.Drawing.Size(110, 23);
            this.incrementTextBox.TabIndex = 16;
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(817, 128);
            this.offsetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(110, 23);
            this.offsetTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(932, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Length";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(932, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Increment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(932, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Offset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 741);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.incrementTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelBrushSize);
            this.Controls.Add(this.brushSizeTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox brushSizeTextBox;
        private System.Windows.Forms.Label labelBrushSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox incrementTextBox;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

