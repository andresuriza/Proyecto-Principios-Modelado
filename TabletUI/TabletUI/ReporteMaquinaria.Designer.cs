﻿namespace TabletUI
{
    partial class ReporteMaquinaria
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
            button1 = new Button();
            estadoButton = new Button();
            estadoLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 212);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 25);
            label1.TabIndex = 1;
            label1.Text = "El estado actual de la máquina en la línea de producción es:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(717, 435);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(173, 76);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // estadoButton
            // 
            estadoButton.Cursor = Cursors.Hand;
            estadoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            estadoButton.Location = new Point(337, 435);
            estadoButton.Margin = new Padding(4);
            estadoButton.Name = "estadoButton";
            estadoButton.Size = new Size(360, 76);
            estadoButton.TabIndex = 3;
            estadoButton.Text = "Marcar fallo";
            estadoButton.UseVisualStyleBackColor = true;
            estadoButton.MouseClick += estadoButton_MouseClick;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            estadoLabel.Location = new Point(546, 261);
            estadoLabel.Margin = new Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(160, 32);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "funcionando";
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
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // ReporteMaquinaria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(estadoLabel);
            Controls.Add(estadoButton);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "ReporteMaquinaria";
            Text = "Form1";
            FormClosed += ReporteMaquinaria_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button estadoButton;
        private Label estadoLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}