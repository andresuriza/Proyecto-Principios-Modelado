namespace TabletUI
{
    partial class OpcionesSupervisor
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(510, 300);
            button2.Name = "button2";
            button2.Size = new Size(248, 114);
            button2.TabIndex = 1;
            button2.Text = "Ver lista de miembros";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(207, 300);
            button3.Name = "button3";
            button3.Size = new Size(248, 114);
            button3.TabIndex = 2;
            button3.Text = "Opciones de lote";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(817, 300);
            button4.Name = "button4";
            button4.Size = new Size(248, 114);
            button4.TabIndex = 3;
            button4.Text = "Break general";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(1067, 560);
            button1.Name = "button1";
            button1.Size = new Size(164, 58);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 191);
            label1.Name = "label1";
            label1.Size = new Size(269, 20);
            label1.TabIndex = 5;
            label1.Text = "Hola supervisor, seleccione una opción:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.bottom_bar;
            pictureBox2.Location = new Point(-9, 636);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // OpcionesSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesSupervisor";
            Text = "OpcionesSupervisor";
            FormClosed += OpcionesSupervisor_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}