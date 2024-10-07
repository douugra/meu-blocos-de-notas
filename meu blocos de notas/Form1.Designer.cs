namespace meu_blocos_de_notas
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
            buttonAbrir = new Button();
            Salvarbutton = new Button();
            Encriptarbutton = new Button();
            Dsencriptarbutton = new Button();
            labelNomeDoArquivo = new Label();
            textBoxConteudo = new TextBox();
            SuspendLayout();
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(12, 21);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir\r\n\r\n\r\n";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // Salvarbutton
            // 
            Salvarbutton.Location = new Point(104, 21);
            Salvarbutton.Name = "Salvarbutton";
            Salvarbutton.Size = new Size(75, 23);
            Salvarbutton.TabIndex = 1;
            Salvarbutton.Text = "Salvar";
            Salvarbutton.UseVisualStyleBackColor = true;
            Salvarbutton.Click += Salvarbutton_Click;
            // 
            // Encriptarbutton
            // 
            Encriptarbutton.Location = new Point(196, 21);
            Encriptarbutton.Name = "Encriptarbutton";
            Encriptarbutton.Size = new Size(75, 23);
            Encriptarbutton.TabIndex = 2;
            Encriptarbutton.Text = "Encriptar";
            Encriptarbutton.UseVisualStyleBackColor = true;
            Encriptarbutton.Click += Encriptarbutton_Click;
            // 
            // Dsencriptarbutton
            // 
            Dsencriptarbutton.Location = new Point(289, 21);
            Dsencriptarbutton.Name = "Dsencriptarbutton";
            Dsencriptarbutton.Size = new Size(75, 23);
            Dsencriptarbutton.TabIndex = 3;
            Dsencriptarbutton.Text = "Desencriptar";
            Dsencriptarbutton.UseVisualStyleBackColor = true;
            Dsencriptarbutton.Click += Dsencriptarbutton_Click;
            // 
            // labelNomeDoArquivo
            // 
            labelNomeDoArquivo.AutoSize = true;
            labelNomeDoArquivo.Location = new Point(390, 25);
            labelNomeDoArquivo.Name = "labelNomeDoArquivo";
            labelNomeDoArquivo.Size = new Size(108, 15);
            labelNomeDoArquivo.TabIndex = 4;
            labelNomeDoArquivo.Text = "*nome do arquivo*";
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConteudo.Location = new Point(12, 50);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(486, 388);
            textBoxConteudo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 450);
            Controls.Add(textBoxConteudo);
            Controls.Add(labelNomeDoArquivo);
            Controls.Add(Dsencriptarbutton);
            Controls.Add(Encriptarbutton);
            Controls.Add(Salvarbutton);
            Controls.Add(buttonAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbrir;
        private Button Salvarbutton;
        private Button Encriptarbutton;
        private Button Dsencriptarbutton;
        private Label labelNomeDoArquivo;
        private TextBox textBoxConteudo;
    }
}
