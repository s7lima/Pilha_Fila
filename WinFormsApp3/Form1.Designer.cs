namespace WinFormsApp3
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
            LbxPilha = new ListBox();
            LbxFila = new ListBox();
            Pilha = new Label();
            Fila = new Label();
            textPilha = new TextBox();
            AddBtnPilha = new Button();
            RmBtnPilha = new Button();
            textFila = new TextBox();
            RmBtnFila = new Button();
            AddBtnFila = new Button();
            SuspendLayout();
            // 
            // LbxPilha
            // 
            LbxPilha.Font = new Font("Segoe UI", 15F);
            LbxPilha.FormattingEnabled = true;
            LbxPilha.ItemHeight = 28;
            LbxPilha.Location = new Point(12, 60);
            LbxPilha.Name = "LbxPilha";
            LbxPilha.Size = new Size(334, 284);
            LbxPilha.TabIndex = 0;
            // 
            // LbxFila
            // 
            LbxFila.Font = new Font("Segoe UI", 15F);
            LbxFila.FormattingEnabled = true;
            LbxFila.ItemHeight = 28;
            LbxFila.Location = new Point(454, 60);
            LbxFila.Name = "LbxFila";
            LbxFila.Size = new Size(334, 284);
            LbxFila.TabIndex = 1;
            // 
            // Pilha
            // 
            Pilha.AutoSize = true;
            Pilha.Font = new Font("Segoe UI", 15F);
            Pilha.Location = new Point(12, 29);
            Pilha.Name = "Pilha";
            Pilha.Size = new Size(54, 28);
            Pilha.TabIndex = 2;
            Pilha.Text = "Pilha";
            // 
            // Fila
            // 
            Fila.AutoSize = true;
            Fila.Font = new Font("Segoe UI", 15F);
            Fila.Location = new Point(454, 29);
            Fila.Name = "Fila";
            Fila.Size = new Size(42, 28);
            Fila.TabIndex = 3;
            Fila.Text = "Fila";
            // 
            // textPilha
            // 
            textPilha.Location = new Point(12, 350);
            textPilha.Multiline = true;
            textPilha.Name = "textPilha";
            textPilha.Size = new Size(174, 35);
            textPilha.TabIndex = 4;
            // 
            // AddBtnPilha
            // 
            AddBtnPilha.Font = new Font("Segoe UI", 14F);
            AddBtnPilha.Location = new Point(230, 349);
            AddBtnPilha.Name = "AddBtnPilha";
            AddBtnPilha.Size = new Size(55, 41);
            AddBtnPilha.TabIndex = 6;
            AddBtnPilha.Text = "+";
            AddBtnPilha.UseVisualStyleBackColor = true;
            AddBtnPilha.Click += AddBtnPilha_Click;
            // 
            // RmBtnPilha
            // 
            RmBtnPilha.Font = new Font("Segoe UI", 14F);
            RmBtnPilha.Location = new Point(291, 349);
            RmBtnPilha.Name = "RmBtnPilha";
            RmBtnPilha.Size = new Size(55, 41);
            RmBtnPilha.TabIndex = 7;
            RmBtnPilha.Text = "-";
            RmBtnPilha.UseVisualStyleBackColor = true;
            RmBtnPilha.Click += RmBtnPilha_Click;
            // 
            // textFila
            // 
            textFila.Location = new Point(454, 350);
            textFila.Multiline = true;
            textFila.Name = "textFila";
            textFila.Size = new Size(174, 35);
            textFila.TabIndex = 8;
            // 
            // RmBtnFila
            // 
            RmBtnFila.Font = new Font("Segoe UI", 14F);
            RmBtnFila.Location = new Point(733, 349);
            RmBtnFila.Name = "RmBtnFila";
            RmBtnFila.Size = new Size(55, 41);
            RmBtnFila.TabIndex = 10;
            RmBtnFila.Text = "-";
            RmBtnFila.UseVisualStyleBackColor = true;
            RmBtnFila.Click += RmBtnFila_Click;
            // 
            // AddBtnFila
            // 
            AddBtnFila.Font = new Font("Segoe UI", 14F);
            AddBtnFila.Location = new Point(672, 349);
            AddBtnFila.Name = "AddBtnFila";
            AddBtnFila.Size = new Size(55, 41);
            AddBtnFila.TabIndex = 9;
            AddBtnFila.Text = "+";
            AddBtnFila.UseVisualStyleBackColor = true;
            AddBtnFila.Click += AddBtnFila_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RmBtnFila);
            Controls.Add(AddBtnFila);
            Controls.Add(textFila);
            Controls.Add(RmBtnPilha);
            Controls.Add(AddBtnPilha);
            Controls.Add(textPilha);
            Controls.Add(Fila);
            Controls.Add(Pilha);
            Controls.Add(LbxFila);
            Controls.Add(LbxPilha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbxPilha;
        private ListBox LbxFila;
        private Label Pilha;
        private Label Fila;
        private TextBox textPilha;
        private Button AddBtnPilha;
        private Button RmBtnPilha;
        private TextBox textFila;
        private Button RmBtnFila;
        private Button AddBtnFila;
    }
}
