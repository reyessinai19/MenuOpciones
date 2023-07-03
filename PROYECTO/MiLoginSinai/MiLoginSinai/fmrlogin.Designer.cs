namespace MiLoginSinai
{
    partial class fmrlogin
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
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontrasena = new TextBox();
            btncancelar = new Button();
            btningresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(150, 35);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(136, 23);
            txtusuario.TabIndex = 2;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(150, 89);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(136, 23);
            txtcontrasena.TabIndex = 3;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(192, 255, 192);
            btncancelar.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.Location = new Point(29, 163);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(98, 33);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(255, 192, 255);
            btningresar.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.Location = new Point(162, 163);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(98, 33);
            btningresar.TabIndex = 5;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // fmrlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 287);
            Controls.Add(btningresar);
            Controls.Add(btncancelar);
            Controls.Add(txtcontrasena);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmrlogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontrasena;
        private Button btncancelar;
        private Button btningresar;
    }
}