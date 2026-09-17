namespace ejer1GA4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            jbtnAceptar = new Button();
            jbtnLimpiar = new Button();
            jbtnSalir = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 66);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // jbtnAceptar
            // 
            jbtnAceptar.Location = new Point(209, 57);
            jbtnAceptar.Name = "jbtnAceptar";
            jbtnAceptar.Size = new Size(65, 22);
            jbtnAceptar.TabIndex = 6;
            jbtnAceptar.Text = "Aceptar";
            jbtnAceptar.UseVisualStyleBackColor = true;
            jbtnAceptar.Click += jbtnAceptar_Click;
            // 
            // jbtnLimpiar
            // 
            jbtnLimpiar.Location = new Point(209, 88);
            jbtnLimpiar.Name = "jbtnLimpiar";
            jbtnLimpiar.Size = new Size(65, 22);
            jbtnLimpiar.TabIndex = 7;
            jbtnLimpiar.Text = "Limpiar";
            jbtnLimpiar.UseVisualStyleBackColor = true;
            jbtnLimpiar.Click += jbtnLimpiar_Click;
            // 
            // jbtnSalir
            // 
            jbtnSalir.Location = new Point(209, 121);
            jbtnSalir.Name = "jbtnSalir";
            jbtnSalir.Size = new Size(65, 25);
            jbtnSalir.TabIndex = 8;
            jbtnSalir.Text = "Salir";
            jbtnSalir.UseVisualStyleBackColor = true;
            jbtnSalir.Click += jbtnSalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 178);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "En letras:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 205);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 304);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(jbtnSalir);
            Controls.Add(jbtnLimpiar);
            Controls.Add(jbtnAceptar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button jbtnAceptar;
        private Button jbtnLimpiar;
        private Button jbtnSalir;
        private Label label4;
        private TextBox textBox4;
    }
}
