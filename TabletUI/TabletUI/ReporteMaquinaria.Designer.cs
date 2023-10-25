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
            listView1 = new ListView();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(204, 206);
            listView1.Name = "listView1";
            listView1.Size = new Size(761, 450);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 156);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 1;
            label1.Text = "Lista de máquinas en línea de producción:";
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
            // ReporteMaquinaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReporteMaquinaria";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button button1;
    }
}