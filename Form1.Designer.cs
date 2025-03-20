namespace Leitura_de_solicitação_de_cliente
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
            LblClienteFiel = new Label();
            LblBoasVindas = new Label();
            label1 = new Label();
            BtnCadastrodeClientes = new Button();
            BtnConsultadeClientes = new Button();
            BtnConfigurações = new Button();
            BtnSair = new Button();
            BtnPáginaInicial = new Button();
            SuspendLayout();
            // 
            // LblClienteFiel
            // 
            LblClienteFiel.AutoSize = true;
            LblClienteFiel.Location = new Point(282, 9);
            LblClienteFiel.Name = "LblClienteFiel";
            LblClienteFiel.Size = new Size(182, 32);
            LblClienteFiel.TabIndex = 0;
            LblClienteFiel.Text = "Cliente Fiel";
            // 
            // LblBoasVindas
            // 
            LblBoasVindas.AutoSize = true;
            LblBoasVindas.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBoasVindas.Location = new Point(305, 51);
            LblBoasVindas.Name = "LblBoasVindas";
            LblBoasVindas.Size = new Size(141, 23);
            LblBoasVindas.TabIndex = 1;
            LblBoasVindas.Text = "Boas Vindas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 83);
            label1.Name = "label1";
            label1.Size = new Size(508, 18);
            label1.TabIndex = 2;
            label1.Text = "\"Parceria de confiança para um atendimento acolhedor.\"";
            label1.Click += label1_Click;
            // 
            // BtnCadastrodeClientes
            // 
            BtnCadastrodeClientes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCadastrodeClientes.ForeColor = Color.DarkOrange;
            BtnCadastrodeClientes.Location = new Point(268, 104);
            BtnCadastrodeClientes.Name = "BtnCadastrodeClientes";
            BtnCadastrodeClientes.Size = new Size(196, 42);
            BtnCadastrodeClientes.TabIndex = 3;
            BtnCadastrodeClientes.Text = "Cadastro de Clientes";
            BtnCadastrodeClientes.UseVisualStyleBackColor = true;
            // 
            // BtnConsultadeClientes
            // 
            BtnConsultadeClientes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConsultadeClientes.ForeColor = Color.DarkOrange;
            BtnConsultadeClientes.Location = new Point(268, 152);
            BtnConsultadeClientes.Name = "BtnConsultadeClientes";
            BtnConsultadeClientes.Size = new Size(196, 39);
            BtnConsultadeClientes.TabIndex = 4;
            BtnConsultadeClientes.Text = "Consulta de Clientes";
            BtnConsultadeClientes.UseVisualStyleBackColor = true;
            // 
            // BtnConfigurações
            // 
            BtnConfigurações.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfigurações.ForeColor = Color.DarkOrange;
            BtnConfigurações.Location = new Point(268, 197);
            BtnConfigurações.Name = "BtnConfigurações";
            BtnConfigurações.Size = new Size(196, 42);
            BtnConfigurações.TabIndex = 5;
            BtnConfigurações.Text = "Configurações";
            BtnConfigurações.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            BtnSair.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.DarkOrange;
            BtnSair.Location = new Point(268, 245);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(196, 39);
            BtnSair.TabIndex = 6;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnPáginaInicial
            // 
            BtnPáginaInicial.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPáginaInicial.ForeColor = Color.DarkOrange;
            BtnPáginaInicial.Location = new Point(268, 290);
            BtnPáginaInicial.Name = "BtnPáginaInicial";
            BtnPáginaInicial.Size = new Size(196, 46);
            BtnPáginaInicial.TabIndex = 7;
            BtnPáginaInicial.Text = "Página Inicial";
            BtnPáginaInicial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 387);
            Controls.Add(BtnPáginaInicial);
            Controls.Add(BtnSair);
            Controls.Add(BtnConfigurações);
            Controls.Add(BtnConsultadeClientes);
            Controls.Add(BtnCadastrodeClientes);
            Controls.Add(label1);
            Controls.Add(LblBoasVindas);
            Controls.Add(LblClienteFiel);
            Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 6, 8, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblClienteFiel;
        private Label LblBoasVindas;
        private Label label1;
        private Button BtnCadastrodeClientes;
        private Button BtnConsultadeClientes;
        private Button BtnConfigurações;
        private Button BtnSair;
        private Button BtnPáginaInicial;
    }
}
