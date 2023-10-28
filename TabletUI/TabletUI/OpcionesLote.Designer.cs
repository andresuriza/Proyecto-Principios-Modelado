namespace TabletUI
{
    partial class OpcionesLote
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
            ListViewItem listViewItem1 = new ListViewItem("Lote1");
            ListViewItem listViewItem2 = new ListViewItem("Lote2");
            listView1 = new ListView();
            d = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { d });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(41, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(539, 527);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // d
            // 
            d.Width = 1000;
            // 
            // button1
            // 
            button1.Location = new Point(739, 294);
            button1.Name = "button1";
            button1.Size = new Size(300, 78);
            button1.TabIndex = 1;
            button1.Text = "Crear lote";
            button1.UseVisualStyleBackColor = true;
            // 
            // OpcionesLote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 691);
            Controls.Add(button1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OpcionesLote";
            Text = "OpcionesLote";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader d;
        private Button button1;
    }
}