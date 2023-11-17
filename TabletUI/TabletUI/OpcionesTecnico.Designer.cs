namespace TabletUI
{
    partial class OpcionesTecnico
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(510, 300);
            button1.Name = "button1";
            button1.Size = new Size(248, 114);
            button1.TabIndex = 0;
            button1.Text = "Ver lista de miembros";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(207, 300);
            button2.Name = "button2";
            button2.Size = new Size(248, 114);
            button2.TabIndex = 1;
            button2.Text = "Reportar fallas de maquinaria";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(817, 300);
            button3.Name = "button3";
            button3.Size = new Size(248, 114);
            button3.TabIndex = 2;
            button3.Text = "Opciones de lote";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(1067, 560);
            button4.Name = "button4";
            button4.Size = new Size(164, 58);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 186);
            label1.Name = "label1";
            label1.Size = new Size(250, 20);
            label1.TabIndex = 4;
            label1.Text = "Hola técnico, seleccione una opción:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.bottom_bar;
            pictureBox2.Location = new Point(0, 636);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // OpcionesTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesTecnico";
            Text = "OpcionesTecnico";
            FormClosed += OpcionesTecnico_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}