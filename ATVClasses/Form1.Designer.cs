namespace ATVClasses
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_View1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(97, 294);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(148, 42);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(97, 24);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(180, 23);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(97, 82);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(180, 23);
            this.txt_Idade.TabIndex = 2;
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(97, 152);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(180, 23);
            this.txt_Rua.TabIndex = 3;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(97, 227);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(180, 23);
            this.txt_Cidade.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.txt_Cidade);
            this.panel1.Controls.Add(this.txt_Idade);
            this.panel1.Controls.Add(this.txt_Rua);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 364);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // list_View1
            // 
            this.list_View1.Location = new System.Drawing.Point(481, 46);
            this.list_View1.Name = "list_View1";
            this.list_View1.Size = new System.Drawing.Size(258, 346);
            this.list_View1.TabIndex = 6;
            this.list_View1.UseCompatibleStateImageBehavior = false;
            this.list_View1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.list_View1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Salvar;
        private TextBox txt_Nome;
        private TextBox txt_Idade;
        private TextBox txt_Rua;
        private TextBox txt_Cidade;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView list_View1;
    }
}