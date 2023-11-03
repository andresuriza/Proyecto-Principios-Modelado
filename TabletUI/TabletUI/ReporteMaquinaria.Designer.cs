namespace TabletUI
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 220);
            label1.Name = "label1";
            label1.Size = new Size(406, 20);
            label1.TabIndex = 1;
            label1.Text = "El estado actual de la máquina en la línea de producción es:";
            // 
            // button1
            // 
            button1.Location = new Point(89, 73);
            button1.Name = "button1";
            button1.Size = new Size(126, 51);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // estadoButton
            // 
            estadoButton.Location = new Point(445, 485);
            estadoButton.Name = "estadoButton";
            estadoButton.Size = new Size(276, 81);
            estadoButton.TabIndex = 3;
            estadoButton.Text = "Marcar fallo";
            estadoButton.UseVisualStyleBackColor = true;
            estadoButton.MouseClick += estadoButton_MouseClick;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            estadoLabel.Location = new Point(732, 220);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(99, 20);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "Funcionando";
            // 
            // ReporteMaquinaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(estadoLabel);
            Controls.Add(estadoButton);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReporteMaquinaria";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button estadoButton;
        private Label estadoLabel;
    }
}