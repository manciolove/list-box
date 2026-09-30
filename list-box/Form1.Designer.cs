namespace list_box
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAnimali = new ListBox();
            buttonAgg = new Button();
            buttonRim = new Button();
            buttonMod = new Button();
            lblAgg = new Label();
            txtAgg = new TextBox();
            txtMod = new TextBox();
            lblMod = new Label();
            lblLista = new Label();
            buttonSalva = new Button();
            SuspendLayout();
            // 
            // listBoxAnimali
            // 
            listBoxAnimali.FormattingEnabled = true;
            listBoxAnimali.ItemHeight = 15;
            listBoxAnimali.Location = new Point(62, 56);
            listBoxAnimali.Name = "listBoxAnimali";
            listBoxAnimali.Size = new Size(140, 109);
            listBoxAnimali.TabIndex = 0;
            listBoxAnimali.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonAgg
            // 
            buttonAgg.Location = new Point(62, 237);
            buttonAgg.Name = "buttonAgg";
            buttonAgg.Size = new Size(75, 23);
            buttonAgg.TabIndex = 1;
            buttonAgg.Text = "aggiungi";
            buttonAgg.UseVisualStyleBackColor = true;
            buttonAgg.Click += buttonAgg_Click;
            // 
            // buttonRim
            // 
            buttonRim.Location = new Point(254, 82);
            buttonRim.Name = "buttonRim";
            buttonRim.Size = new Size(75, 23);
            buttonRim.TabIndex = 2;
            buttonRim.Text = "rimuovi";
            buttonRim.UseVisualStyleBackColor = true;
            buttonRim.Click += buttonRim_Click;
            // 
            // buttonMod
            // 
            buttonMod.Location = new Point(276, 237);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(75, 23);
            buttonMod.TabIndex = 3;
            buttonMod.Text = "modifica";
            buttonMod.UseVisualStyleBackColor = true;
            buttonMod.Click += buttonMod_Click;
            // 
            // lblAgg
            // 
            lblAgg.AutoSize = true;
            lblAgg.Location = new Point(62, 190);
            lblAgg.Name = "lblAgg";
            lblAgg.Size = new Size(107, 15);
            lblAgg.TabIndex = 4;
            lblAgg.Text = "aggiungi elemento";
            lblAgg.Click += label1_Click;
            // 
            // txtAgg
            // 
            txtAgg.Location = new Point(62, 208);
            txtAgg.Name = "txtAgg";
            txtAgg.Size = new Size(100, 23);
            txtAgg.TabIndex = 5;
            // 
            // txtMod
            // 
            txtMod.Location = new Point(276, 208);
            txtMod.Name = "txtMod";
            txtMod.Size = new Size(100, 23);
            txtMod.TabIndex = 9;
            txtMod.TextChanged += txtMod_TextChanged;
            // 
            // lblMod
            // 
            lblMod.AutoSize = true;
            lblMod.Location = new Point(276, 190);
            lblMod.Name = "lblMod";
            lblMod.Size = new Size(107, 15);
            lblMod.TabIndex = 8;
            lblMod.Text = "modifica elemento";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(60, 38);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(77, 15);
            lblLista.TabIndex = 10;
            lblLista.Text = "lista elementi";
            // 
            // buttonSalva
            // 
            buttonSalva.Location = new Point(173, 322);
            buttonSalva.Name = "buttonSalva";
            buttonSalva.Size = new Size(89, 42);
            buttonSalva.TabIndex = 11;
            buttonSalva.Text = "salva";
            buttonSalva.UseVisualStyleBackColor = true;
            buttonSalva.Click += buttonSalva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalva);
            Controls.Add(lblLista);
            Controls.Add(txtMod);
            Controls.Add(lblMod);
            Controls.Add(txtAgg);
            Controls.Add(lblAgg);
            Controls.Add(buttonMod);
            Controls.Add(buttonRim);
            Controls.Add(buttonAgg);
            Controls.Add(listBoxAnimali);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAnimali;
        private Button buttonAgg;
        private Button buttonRim;
        private Button buttonMod;
        private Label lblAgg;
        private TextBox txtAgg;
        private TextBox txtMod;
        private Label lblMod;
        private Label lblLista;
        private Button buttonSalva;
    }
}
