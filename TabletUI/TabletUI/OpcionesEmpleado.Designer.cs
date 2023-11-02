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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 113);
            label1.Name = "label1";
            label1.Size = new Size(272, 20);
            label1.TabIndex = 0;
            label1.Text = "Hola, empleado: Seleccione una opción";
            // 
            // terminarButton
            // 
            terminarButton.Location = new Point(211, 276);
            terminarButton.Name = "terminarButton";
            terminarButton.Size = new Size(216, 84);
            terminarButton.TabIndex = 1;
            terminarButton.Text = "Terminar turno";
            terminarButton.UseVisualStyleBackColor = true;
            terminarButton.MouseClick += terminarButton_MouseClick;
            // 
            // breakButton
            // 
            breakButton.Location = new Point(696, 276);
            breakButton.Name = "breakButton";
            breakButton.Size = new Size(216, 84);
            breakButton.TabIndex = 2;
            breakButton.Text = "Break";
            breakButton.UseVisualStyleBackColor = true;
            breakButton.MouseClick += breakButton_MouseClick;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(460, 440);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(216, 84);
            returnButton.TabIndex = 3;
            returnButton.Text = "Regresar";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.MouseClick += returnButton_MouseClick;
            // 
            // OpcionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(returnButton);
            Controls.Add(breakButton);
            Controls.Add(terminarButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesEmpleado";
            Text = "OpcionesEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button terminarButton;
        private Button breakButton;
        private Button returnButton;
    }
}