namespace TabletUI
{
    partial class OpcionesEmpleado
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
            label1 = new Label();
            terminarButton = new Button();
            breakButton = new Button();
            returnButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 158);
            label1.Name = "label1";
            label1.Size = new Size(259, 20);
            label1.TabIndex = 0;
            label1.Text = "Hola operario, seleccione una opción:";
            // 
            // terminarButton
            // 
            terminarButton.Location = new Point(289, 274);
            terminarButton.Name = "terminarButton";
            terminarButton.Size = new Size(216, 84);
            terminarButton.TabIndex = 1;
            terminarButton.Text = "Terminar turno";
            terminarButton.UseVisualStyleBackColor = true;
            terminarButton.MouseClick += terminarButton_MouseClick;
            // 
            // breakButton
            // 
            breakButton.Location = new Point(774, 274);
            breakButton.Name = "breakButton";
            breakButton.Size = new Size(216, 84);
            breakButton.TabIndex = 2;
            breakButton.Text = "Break";
            breakButton.UseVisualStyleBackColor = true;
            breakButton.MouseClick += breakButton_MouseClick;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(538, 438);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(216, 84);
            returnButton.TabIndex = 3;
            returnButton.Text = "Regresar";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.MouseClick += returnButton_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.bottom_bar;
            pictureBox2.Location = new Point(-4, 636);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // OpcionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 673);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(returnButton);
            Controls.Add(breakButton);
            Controls.Add(terminarButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesEmpleado";
            Text = "OpcionesEmpleado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button terminarButton;
        private Button breakButton;
        private Button returnButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}