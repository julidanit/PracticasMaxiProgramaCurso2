namespace App_practica_WF
{
    partial class form1_Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1_Formulario));
            this.btn_Boton = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.tbx_Texto = new System.Windows.Forms.TextBox();
            this.tbx_Nuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Boton
            // 
            this.btn_Boton.BackColor = System.Drawing.Color.Salmon;
            this.btn_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Boton.Image = ((System.Drawing.Image)(resources.GetObject("btn_Boton.Image")));
            this.btn_Boton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Boton.Location = new System.Drawing.Point(338, 238);
            this.btn_Boton.Name = "btn_Boton";
            this.btn_Boton.Size = new System.Drawing.Size(65, 27);
            this.btn_Boton.TabIndex = 0;
            this.btn_Boton.Text = "Botón";
            this.btn_Boton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Boton.UseVisualStyleBackColor = false;
            this.btn_Boton.Click += new System.EventHandler(this.btn_Boton_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.Red;
            this.lblEtiqueta.Location = new System.Drawing.Point(191, 125);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(76, 25);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Etiqueta";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta_MouseMove);
            // 
            // tbx_Texto
            // 
            this.tbx_Texto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Texto.Location = new System.Drawing.Point(162, 348);
            this.tbx_Texto.MaxLength = 50;
            this.tbx_Texto.Name = "tbx_Texto";
            this.tbx_Texto.Size = new System.Drawing.Size(100, 20);
            this.tbx_Texto.TabIndex = 2;
            this.tbx_Texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Texto_KeyPress);
            // 
            // tbx_Nuevo
            // 
            this.tbx_Nuevo.Location = new System.Drawing.Point(455, 347);
            this.tbx_Nuevo.Multiline = true;
            this.tbx_Nuevo.Name = "tbx_Nuevo";
            this.tbx_Nuevo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Nuevo.Size = new System.Drawing.Size(100, 20);
            this.tbx_Nuevo.TabIndex = 3;
            this.tbx_Nuevo.Leave += new System.EventHandler(this.tbx_Nuevo_Leave);
            // 
            // form1_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.tbx_Nuevo);
            this.Controls.Add(this.tbx_Texto);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btn_Boton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form1_Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form1_Formulario_FormClosed);
            this.Load += new System.EventHandler(this.form1_Formulario_Load);
            this.Click += new System.EventHandler(this.form1_Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Boton;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox tbx_Texto;
        private System.Windows.Forms.TextBox tbx_Nuevo;
    }
}

