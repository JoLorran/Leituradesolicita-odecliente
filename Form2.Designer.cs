namespace Leitura_de_solicitação_de_cliente
{
    partial class Form2
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
            LblCadastrodeClientes = new Label();
            SuspendLayout();
            // 
            // LblCadastrodeClientes
            // 
            LblCadastrodeClientes.AutoSize = true;
            LblCadastrodeClientes.Location = new Point(336, 40);
            LblCadastrodeClientes.Name = "LblCadastrodeClientes";
            LblCadastrodeClientes.Size = new Size(115, 15);
            LblCadastrodeClientes.TabIndex = 0;
            LblCadastrodeClientes.Text = "Cadastro de Clientes";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblCadastrodeClientes);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCadastrodeClientes;
    }
}