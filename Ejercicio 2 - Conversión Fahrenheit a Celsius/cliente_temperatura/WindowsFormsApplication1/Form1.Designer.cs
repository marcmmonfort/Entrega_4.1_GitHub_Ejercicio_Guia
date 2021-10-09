namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.FaC = new System.Windows.Forms.RadioButton();
            this.CaF = new System.Windows.Forms.RadioButton();
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.temperatura);
            this.groupBox1.Controls.Add(this.FaC);
            this.groupBox1.Controls.Add(this.CaF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(113, 99);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(139, 20);
            this.temperatura.TabIndex = 10;
            // 
            // FaC
            // 
            this.FaC.AutoSize = true;
            this.FaC.Location = new System.Drawing.Point(96, 167);
            this.FaC.Name = "FaC";
            this.FaC.Size = new System.Drawing.Size(120, 17);
            this.FaC.TabIndex = 7;
            this.FaC.TabStop = true;
            this.FaC.Text = "Fahrenheit a Celsius";
            this.FaC.UseVisualStyleBackColor = true;
            // 
            // CaF
            // 
            this.CaF.AutoSize = true;
            this.CaF.Location = new System.Drawing.Point(96, 144);
            this.CaF.Name = "CaF";
            this.CaF.Size = new System.Drawing.Size(120, 17);
            this.CaF.TabIndex = 8;
            this.CaF.TabStop = true;
            this.CaF.Text = "Celsius a Fahrenheit";
            this.CaF.UseVisualStyleBackColor = true;
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(12, 12);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(363, 34);
            this.Conectar.TabIndex = 7;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(12, 52);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(363, 34);
            this.Desconectar.TabIndex = 8;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 410);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FaC;
        private System.Windows.Forms.RadioButton CaF;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
    }
}

