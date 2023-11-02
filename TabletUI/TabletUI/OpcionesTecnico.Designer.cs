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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(415, 144);
            button1.Name = "button1";
            button1.Size = new Size(311, 97);
            button1.TabIndex = 0;
            button1.Text = "Ver lista de miembros";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(120, 412);
            button2.Name = "button2";
            button2.Size = new Size(311, 97);
            button2.TabIndex = 1;
            button2.Text = "Reportar fallas de maquinaria";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(730, 412);
            button3.Name = "button3";
            button3.Size = new Size(311, 97);
            button3.TabIndex = 2;
            button3.Text = "Opciones de lote";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // OpcionesTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesTecnico";
            Text = "OpcionesTecnico";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}