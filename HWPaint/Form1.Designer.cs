namespace HWPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Widtht = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Y_cord = new System.Windows.Forms.TextBox();
            this.X_cord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pan_Col = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Fill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 298);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.Fill);
            this.groupBox1.Controls.Add(this.Widtht);
            this.groupBox1.Controls.Add(this.Height);
            this.groupBox1.Controls.Add(this.Y_cord);
            this.groupBox1.Controls.Add(this.X_cord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Pen);
            this.groupBox1.Controls.Add(this.Erase);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.pan_Col);
            this.groupBox1.Location = new System.Drawing.Point(13, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // Widtht
            // 
            this.Widtht.Location = new System.Drawing.Point(617, 76);
            this.Widtht.Name = "Widtht";
            this.Widtht.Size = new System.Drawing.Size(100, 20);
            this.Widtht.TabIndex = 13;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(617, 56);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 20);
            this.Height.TabIndex = 12;
            // 
            // Y_cord
            // 
            this.Y_cord.Location = new System.Drawing.Point(617, 37);
            this.Y_cord.Name = "Y_cord";
            this.Y_cord.Size = new System.Drawing.Size(100, 20);
            this.Y_cord.TabIndex = 11;
            // 
            // X_cord
            // 
            this.X_cord.Location = new System.Drawing.Point(617, 17);
            this.X_cord.Name = "X_cord";
            this.X_cord.Size = new System.Drawing.Size(100, 20);
            this.X_cord.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(350, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.Location = new System.Drawing.Point(266, 59);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(36, 33);
            this.Clear.TabIndex = 4;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Pen
            // 
            this.Pen.BackColor = System.Drawing.Color.White;
            this.Pen.Image = ((System.Drawing.Image)(resources.GetObject("Pen.Image")));
            this.Pen.Location = new System.Drawing.Point(308, 20);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(36, 33);
            this.Pen.TabIndex = 3;
            this.Pen.UseVisualStyleBackColor = false;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // Erase
            // 
            this.Erase.BackColor = System.Drawing.Color.White;
            this.Erase.Image = ((System.Drawing.Image)(resources.GetObject("Erase.Image")));
            this.Erase.Location = new System.Drawing.Point(266, 20);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(36, 33);
            this.Erase.TabIndex = 2;
            this.Erase.UseVisualStyleBackColor = false;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(68, 20);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 3;
            // 
            // pan_Col
            // 
            this.pan_Col.BackColor = System.Drawing.Color.Black;
            this.pan_Col.Location = new System.Drawing.Point(7, 20);
            this.pan_Col.Name = "pan_Col";
            this.pan_Col.Size = new System.Drawing.Size(54, 61);
            this.pan_Col.TabIndex = 0;
            this.pan_Col.DoubleClick += new System.EventHandler(this.pan_Col_DoubleClick);
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.Color.White;
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.Location = new System.Drawing.Point(350, 56);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(36, 33);
            this.Fill.TabIndex = 14;
            this.Fill.UseVisualStyleBackColor = false;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Simple Paint";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel pan_Col;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Widtht;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Y_cord;
        private System.Windows.Forms.TextBox X_cord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fill;
    }
}

