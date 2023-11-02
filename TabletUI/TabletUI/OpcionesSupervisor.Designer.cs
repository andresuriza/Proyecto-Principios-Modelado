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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(350, 137);
            button2.Name = "button2";
            button2.Size = new Size(456, 166);
            button2.TabIndex = 1;
            button2.Text = "Ver lista de miembros";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(92, 427);
            button3.Name = "button3";
            button3.Size = new Size(456, 166);
            button3.TabIndex = 2;
            button3.Text = "Opciones de lote";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(619, 427);
            button4.Name = "button4";
            button4.Size = new Size(456, 166);
            button4.TabIndex = 3;
            button4.Text = "Break general";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick;
            // 
            // OpcionesSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesSupervisor";
            Text = "OpcionesSupervisor";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
    }
}