namespace EncuestasForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistroDeEncuesta = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnListadoContactables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            this.btnRegistroDeEncuesta.Location = new System.Drawing.Point(175, 90);
            this.btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            this.btnRegistroDeEncuesta.Size = new System.Drawing.Size(169, 47);
            this.btnRegistroDeEncuesta.TabIndex = 0;
            this.btnRegistroDeEncuesta.Text = "Registro de Encuesta";
            this.btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroDeEncuesta.Click += new System.EventHandler(this.btnRegistroDeEncuesta_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(175, 157);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(169, 45);
            this.btnResultados.TabIndex = 1;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnListadoContactables
            // 
            this.btnListadoContactables.Location = new System.Drawing.Point(175, 227);
            this.btnListadoContactables.Name = "btnListadoContactables";
            this.btnListadoContactables.Size = new System.Drawing.Size(169, 46);
            this.btnListadoContactables.TabIndex = 2;
            this.btnListadoContactables.Text = "Listado de Contactables";
            this.btnListadoContactables.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 366);
            this.Controls.Add(this.btnListadoContactables);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnRegistroDeEncuesta);
            this.Name = "Form1";
            this.Text = "Secretaría de Transporte de su Majestad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeEncuesta;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnListadoContactables;
    }
}

