namespace TabletUI
{
    partial class CrearLote
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
            idText = new TextBox();
            descText = new TextBox();
            productidText = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cantidadText = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // idText
            // 
            idText.Location = new Point(368, 139);
            idText.Margin = new Padding(4);
            idText.Name = "idText";
            idText.Size = new Size(569, 31);
            idText.TabIndex = 0;
            // 
            // descText
            // 
            descText.Location = new Point(368, 207);
            descText.Margin = new Padding(4);
            descText.Name = "descText";
            descText.Size = new Size(569, 31);
            descText.TabIndex = 1;
            // 
            // productidText
            // 
            productidText.Location = new Point(368, 273);
            productidText.Margin = new Padding(4);
            productidText.Name = "productidText";
            productidText.Size = new Size(569, 31);
            productidText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(458, 432);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(372, 115);
            button1.TabIndex = 3;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 211);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 6;
            label3.Text = "Id del producto:";
            // 
            // cantidadText
            // 
            cantidadText.Location = new Point(368, 346);
            cantidadText.Margin = new Padding(4);
            cantidadText.Name = "cantidadText";
            cantidadText.Size = new Size(569, 31);
            cantidadText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 8;
            label4.Text = "Cantidad requerida:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.header;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.bottom_bar;
            pictureBox1.Location = new Point(0, 627);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // CrearLote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(cantidadText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(productidText);
            Controls.Add(descText);
            Controls.Add(idText);
            Margin = new Padding(4);
            Name = "CrearLote";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private TextBox descText;
        private TextBox productidText;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox cantidadText;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}