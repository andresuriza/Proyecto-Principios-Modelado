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
            breakButton = new Button();
            returnButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            terminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 213);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 25);
            label1.TabIndex = 0;
            label1.Text = "Hola operario, seleccione una opción:";
            // 
            // breakButton
            // 
            breakButton.Cursor = Cursors.Hand;
            breakButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            breakButton.Location = new Point(700, 342);
            breakButton.Margin = new Padding(4);
            breakButton.Name = "breakButton";
            breakButton.Size = new Size(270, 105);
            breakButton.TabIndex = 2;
            breakButton.Text = "Break";
            breakButton.UseVisualStyleBackColor = true;
            breakButton.MouseClick += breakButton_MouseClick;
            // 
            // returnButton
            // 
            returnButton.Cursor = Cursors.Hand;
            returnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            returnButton.Location = new Point(962, 511);
            returnButton.Margin = new Padding(4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(205, 72);
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
            pictureBox1.Margin = new Padding(4);
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
            pictureBox2.Location = new Point(0, 627);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // terminarButton
            // 
            terminarButton.Cursor = Cursors.Hand;
            terminarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            terminarButton.Location = new Point(302, 342);
            terminarButton.Margin = new Padding(4);
            terminarButton.Name = "terminarButton";
            terminarButton.Size = new Size(270, 105);
            terminarButton.TabIndex = 1;
            terminarButton.Text = "Terminar turno";
            terminarButton.UseVisualStyleBackColor = true;
            terminarButton.MouseClick += terminarButton_MouseClick;
            // 
            // OpcionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(returnButton);
            Controls.Add(breakButton);
            Controls.Add(terminarButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "OpcionesEmpleado";
            Text = "OpcionesEmpleado";
            FormClosed += OpcionesEmpleado_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button breakButton;
        private Button returnButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button terminarButton;
    }
}