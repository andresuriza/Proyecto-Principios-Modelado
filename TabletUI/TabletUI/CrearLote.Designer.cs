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
            SuspendLayout();
            // 
            // idText
            // 
            idText.Location = new Point(192, 43);
            idText.Name = "idText";
            idText.Size = new Size(456, 27);
            idText.TabIndex = 0;
            // 
            // descText
            // 
            descText.Location = new Point(192, 98);
            descText.Name = "descText";
            descText.Size = new Size(456, 27);
            descText.TabIndex = 1;
            // 
            // productidText
            // 
            productidText.Location = new Point(192, 150);
            productidText.Name = "productidText";
            productidText.Size = new Size(456, 27);
            productidText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(236, 323);
            button1.Name = "button1";
            button1.Size = new Size(298, 92);
            button1.TabIndex = 3;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 46);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 153);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 6;
            label3.Text = "Id del producto:";
            // 
            // cantidadText
            // 
            cantidadText.Location = new Point(192, 209);
            cantidadText.Name = "cantidadText";
            cantidadText.Size = new Size(456, 27);
            cantidadText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 212);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad requerida:";
            // 
            // CrearLote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cantidadText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(productidText);
            Controls.Add(descText);
            Controls.Add(idText);
            Name = "CrearLote";
            Text = "Form1";
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
    }
}