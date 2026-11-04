namespace Biblioteca1
{
    partial class FormBiblioteca
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.Label();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textAnio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnsgte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(132, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre Libro";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.AutoSize = true;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAutor.Location = new System.Drawing.Point(128, 179);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(108, 20);
            this.txtAutor.TabIndex = 1;
            this.txtAutor.Text = "Nombre Autor";
            // 
            // txtAnio
            // 
            this.txtAnio.AutoSize = true;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAnio.Location = new System.Drawing.Point(132, 243);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(38, 20);
            this.txtAnio.TabIndex = 2;
            this.txtAnio.Text = "Año";
            // 
            // textAutor
            // 
            this.textAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAutor.Location = new System.Drawing.Point(296, 169);
            this.textAutor.Multiline = true;
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(202, 30);
            this.textAutor.TabIndex = 3;
            // 
            // textAnio
            // 
            this.textAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnio.Location = new System.Drawing.Point(296, 232);
            this.textAnio.Multiline = true;
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(202, 31);
            this.textAnio.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(296, 108);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(202, 29);
            this.textNombre.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Location = new System.Drawing.Point(722, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(331, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsgte
            // 
            this.btnsgte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsgte.Location = new System.Drawing.Point(594, 316);
            this.btnsgte.Name = "btnsgte";
            this.btnsgte.Size = new System.Drawing.Size(98, 33);
            this.btnsgte.TabIndex = 8;
            this.btnsgte.Text = "Siguiente";
            this.btnsgte.UseVisualStyleBackColor = true;
            this.btnsgte.Click += new System.EventHandler(this.btnsgte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(326, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Biblioteca";
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsgte);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormBiblioteca";
            this.Text = "FormBiblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtAutor;
        private System.Windows.Forms.Label txtAnio;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textAnio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnsgte;
        private System.Windows.Forms.Label label4;
    }
}