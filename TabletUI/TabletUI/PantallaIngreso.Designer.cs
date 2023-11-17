namespace TabletUI
{
    partial class PantallaIngreso
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
            selectLine_b = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            errorLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // selectLine_b
            // 
            selectLine_b.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectLine_b.Location = new Point(536, 425);
            selectLine_b.Margin = new Padding(3, 4, 3, 4);
            selectLine_b.Name = "selectLine_b";
            selectLine_b.Size = new Size(232, 88);
            selectLine_b.TabIndex = 0;
            selectLine_b.Text = "Ingresar";
            selectLine_b.UseVisualStyleBackColor = true;
            selectLine_b.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 222);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su código:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(352, 297);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(604, 58);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.ZoomFactor = 2F;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(484, 380);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(330, 20);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Código no es válido, por favor intentar de nuevo";
            errorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.bottom_bar;
            pictureBox2.Location = new Point(0, 636);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // PantallaIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(errorLabel);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(selectLine_b);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaIngreso";
            Text = "PantallaIngreso";
            FormClosed += PantallaIngreso_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectLine_b;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label errorLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}