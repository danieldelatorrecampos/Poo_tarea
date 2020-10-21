namespace POO_Tarea
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
            this.btnconsola = new System.Windows.Forms.Button();
            this.btnXbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconsola
            // 
            this.btnconsola.Location = new System.Drawing.Point(137, 21);
            this.btnconsola.Name = "btnconsola";
            this.btnconsola.Size = new System.Drawing.Size(121, 84);
            this.btnconsola.TabIndex = 0;
            this.btnconsola.Text = "consola";
            this.btnconsola.UseVisualStyleBackColor = true;
            this.btnconsola.Click += new System.EventHandler(this.btnconsola_Click);
            // 
            // btnXbox
            // 
            this.btnXbox.Location = new System.Drawing.Point(137, 111);
            this.btnXbox.Name = "btnXbox";
            this.btnXbox.Size = new System.Drawing.Size(121, 84);
            this.btnXbox.TabIndex = 1;
            this.btnXbox.Text = "Xbox";
            this.btnXbox.UseVisualStyleBackColor = true;
            this.btnXbox.Click += new System.EventHandler(this.btnXbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXbox);
            this.Controls.Add(this.btnconsola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconsola;
        private System.Windows.Forms.Button btnXbox;
    }
}

