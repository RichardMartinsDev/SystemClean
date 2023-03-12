namespace DeletarArquivos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExibirArquivos = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.chklbArquivos = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibirArquivos
            // 
            this.btnExibirArquivos.AccessibleDescription = "";
            this.btnExibirArquivos.AccessibleName = "";
            this.btnExibirArquivos.BackColor = System.Drawing.Color.White;
            this.btnExibirArquivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirArquivos.Location = new System.Drawing.Point(12, 106);
            this.btnExibirArquivos.Name = "btnExibirArquivos";
            this.btnExibirArquivos.Size = new System.Drawing.Size(211, 33);
            this.btnExibirArquivos.TabIndex = 2;
            this.btnExibirArquivos.Text = "Limpar Arquivos Temporários ";
            this.toolTip1.SetToolTip(this.btnExibirArquivos, "Excluir arquivos temporários ");
            this.btnExibirArquivos.UseVisualStyleBackColor = false;
            this.btnExibirArquivos.Click += new System.EventHandler(this.btnExibirArquivos_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(171, 299);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(194, 36);
            this.btnEncerrar.TabIndex = 4;
            this.btnEncerrar.Text = "Encerrar Programa";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // chklbArquivos
            // 
            this.chklbArquivos.FormattingEnabled = true;
            this.chklbArquivos.Location = new System.Drawing.Point(28, 117);
            this.chklbArquivos.Name = "chklbArquivos";
            this.chklbArquivos.Size = new System.Drawing.Size(10, 4);
            this.chklbArquivos.TabIndex = 7;
            this.chklbArquivos.SelectedIndexChanged += new System.EventHandler(this.chklbArquivos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(317, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Executar Desfragmentador de Disco";
            this.toolTip1.SetToolTip(this.button1, "Abre o programa de desfragmentação de Disco para reparar erros no sistema.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(317, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Escanear Disco (HD)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpar Cache Windows";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 33);
            this.button4.TabIndex = 14;
            this.button4.Text = "Limpar  Prefetch";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(14, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "Limpar Arquivos AppData";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(317, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 33);
            this.button6.TabIndex = 16;
            this.button6.Text = "Otimizar Internet";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(317, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 33);
            this.button7.TabIndex = 17;
            this.button7.Text = "Teste de Internet";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(453, 322);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Sobre";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label1.Location = new System.Drawing.Point(0, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Richard Martins - Copyright ©  2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Otimização de discos (HD/SSD) / Internet  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "  Limpeza de arquivos temporários";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DimGray;
            this.button9.Location = new System.Drawing.Point(515, -2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 27);
            this.button9.TabIndex = 23;
            this.button9.Text = "X";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.DimGray;
            this.button10.Location = new System.Drawing.Point(489, -20);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button10.Size = new System.Drawing.Size(26, 45);
            this.button10.TabIndex = 24;
            this.button10.Text = "_";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 351);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnExibirArquivos);
            this.Controls.Add(this.chklbArquivos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Clean";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExibirArquivos;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.CheckedListBox chklbArquivos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

