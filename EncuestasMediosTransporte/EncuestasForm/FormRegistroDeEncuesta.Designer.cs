namespace EncuestasForm
{
    partial class FormRegistroDeEncuesta
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
            this.cbkUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.groupBoxTransporte = new System.Windows.Forms.GroupBox();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnAceptarRegistro = new System.Windows.Forms.Button();
            this.cbkUsaTransportePublico = new System.Windows.Forms.CheckBox();
            this.cbkUsaAutomovil = new System.Windows.Forms.CheckBox();
            this.groupBoxDestinoKM = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.cbkContacto = new System.Windows.Forms.CheckBox();
            this.lbContacto = new System.Windows.Forms.Label();
            this.groupBoxTransporte.SuspendLayout();
            this.groupBoxDestinoKM.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbkUsaBicicleta
            // 
            this.cbkUsaBicicleta.AutoSize = true;
            this.cbkUsaBicicleta.Location = new System.Drawing.Point(127, 34);
            this.cbkUsaBicicleta.Name = "cbkUsaBicicleta";
            this.cbkUsaBicicleta.Size = new System.Drawing.Size(88, 17);
            this.cbkUsaBicicleta.TabIndex = 0;
            this.cbkUsaBicicleta.Text = "Usa Bicicleta";
            this.cbkUsaBicicleta.UseVisualStyleBackColor = true;
            this.cbkUsaBicicleta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxTransporte
            // 
            this.groupBoxTransporte.Controls.Add(this.cbkUsaAutomovil);
            this.groupBoxTransporte.Controls.Add(this.cbkUsaTransportePublico);
            this.groupBoxTransporte.Controls.Add(this.cbkUsaBicicleta);
            this.groupBoxTransporte.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTransporte.Name = "groupBoxTransporte";
            this.groupBoxTransporte.Size = new System.Drawing.Size(270, 131);
            this.groupBoxTransporte.TabIndex = 1;
            this.groupBoxTransporte.TabStop = false;
            this.groupBoxTransporte.Text = "Modo de transporte habitual";
            this.groupBoxTransporte.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(100, 332);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarRegistro.TabIndex = 2;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAceptarRegistro
            // 
            this.btnAceptarRegistro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptarRegistro.Location = new System.Drawing.Point(201, 332);
            this.btnAceptarRegistro.Name = "btnAceptarRegistro";
            this.btnAceptarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarRegistro.TabIndex = 3;
            this.btnAceptarRegistro.Text = "Aceptar";
            this.btnAceptarRegistro.UseVisualStyleBackColor = true;
            this.btnAceptarRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbkUsaTransportePublico
            // 
            this.cbkUsaTransportePublico.AutoSize = true;
            this.cbkUsaTransportePublico.Location = new System.Drawing.Point(127, 99);
            this.cbkUsaTransportePublico.Name = "cbkUsaTransportePublico";
            this.cbkUsaTransportePublico.Size = new System.Drawing.Size(137, 17);
            this.cbkUsaTransportePublico.TabIndex = 1;
            this.cbkUsaTransportePublico.Text = "Usa Transporte Público";
            this.cbkUsaTransportePublico.UseVisualStyleBackColor = true;
            // 
            // cbkUsaAutomovil
            // 
            this.cbkUsaAutomovil.AutoSize = true;
            this.cbkUsaAutomovil.Location = new System.Drawing.Point(127, 67);
            this.cbkUsaAutomovil.Name = "cbkUsaAutomovil";
            this.cbkUsaAutomovil.Size = new System.Drawing.Size(94, 17);
            this.cbkUsaAutomovil.TabIndex = 2;
            this.cbkUsaAutomovil.Text = "Usa Automovil";
            this.cbkUsaAutomovil.UseVisualStyleBackColor = true;
            this.cbkUsaAutomovil.CheckedChanged += new System.EventHandler(this.cbkUsaAutomovil_CheckedChanged);
            // 
            // groupBoxDestinoKM
            // 
            this.groupBoxDestinoKM.Controls.Add(this.lbDistancia);
            this.groupBoxDestinoKM.Controls.Add(this.textBox1);
            this.groupBoxDestinoKM.Controls.Add(this.groupBox2);
            this.groupBoxDestinoKM.Location = new System.Drawing.Point(12, 149);
            this.groupBoxDestinoKM.Name = "groupBoxDestinoKM";
            this.groupBoxDestinoKM.Size = new System.Drawing.Size(270, 71);
            this.groupBoxDestinoKM.TabIndex = 4;
            this.groupBoxDestinoKM.TabStop = false;
            this.groupBoxDestinoKM.Text = "Sobre el destino al trabajo/estudio";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(128, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(35, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(28, 32);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(86, 13);
            this.lbDistancia.TabIndex = 5;
            this.lbDistancia.Text = "Distancia en km ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(145, 44);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 5;
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.lbContacto);
            this.groupBoxContacto.Controls.Add(this.txtMail);
            this.groupBoxContacto.Controls.Add(this.cbkContacto);
            this.groupBoxContacto.Location = new System.Drawing.Point(12, 226);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(270, 82);
            this.groupBoxContacto.TabIndex = 6;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacto";
            this.groupBoxContacto.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cbkContacto
            // 
            this.cbkContacto.AutoSize = true;
            this.cbkContacto.Location = new System.Drawing.Point(112, 19);
            this.cbkContacto.Name = "cbkContacto";
            this.cbkContacto.Size = new System.Drawing.Size(143, 17);
            this.cbkContacto.TabIndex = 7;
            this.cbkContacto.Text = "¿Se lo puede contactar?";
            this.cbkContacto.UseVisualStyleBackColor = true;
            // 
            // lbContacto
            // 
            this.lbContacto.AutoSize = true;
            this.lbContacto.Location = new System.Drawing.Point(109, 47);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(26, 13);
            this.lbContacto.TabIndex = 6;
            this.lbContacto.Text = "Mail";
            this.lbContacto.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 367);
            this.Controls.Add(this.groupBoxContacto);
            this.Controls.Add(this.groupBoxDestinoKM);
            this.Controls.Add(this.btnAceptarRegistro);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.groupBoxTransporte);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "Registro De Encuesta";
            this.Load += new System.EventHandler(this.FormRegistroDeEncuesta_Load);
            this.groupBoxTransporte.ResumeLayout(false);
            this.groupBoxTransporte.PerformLayout();
            this.groupBoxDestinoKM.ResumeLayout(false);
            this.groupBoxDestinoKM.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Button btnAceptarRegistro;
        public System.Windows.Forms.CheckBox cbkUsaBicicleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lbContacto;
        public System.Windows.Forms.CheckBox cbkUsaAutomovil;
        public System.Windows.Forms.CheckBox cbkUsaTransportePublico;
        public System.Windows.Forms.GroupBox groupBoxTransporte;
        public System.Windows.Forms.GroupBox groupBoxDestinoKM;
        public System.Windows.Forms.Label lbDistancia;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.GroupBox groupBoxContacto;
        public System.Windows.Forms.CheckBox cbkContacto;
    }
}