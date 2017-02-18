namespace BuscaminasVentana
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
            this.buscaminasTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn_dificultad_alta = new System.Windows.Forms.RadioButton();
            this.rbtn_dificultad_media = new System.Windows.Forms.RadioButton();
            this.rbtn_dificultad_baja = new System.Windows.Forms.RadioButton();
            this.lbl_dificultad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscaminasTableLayout
            // 
            this.buscaminasTableLayout.AutoSize = true;
            this.buscaminasTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscaminasTableLayout.ColumnCount = 2;
            this.buscaminasTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buscaminasTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buscaminasTableLayout.Location = new System.Drawing.Point(31, 54);
            this.buscaminasTableLayout.Name = "buscaminasTableLayout";
            this.buscaminasTableLayout.RowCount = 2;
            this.buscaminasTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buscaminasTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buscaminasTableLayout.Size = new System.Drawing.Size(0, 0);
            this.buscaminasTableLayout.TabIndex = 0;
            // 
            // rbtn_dificultad_alta
            // 
            this.rbtn_dificultad_alta.AutoSize = true;
            this.rbtn_dificultad_alta.Location = new System.Drawing.Point(187, 21);
            this.rbtn_dificultad_alta.Name = "rbtn_dificultad_alta";
            this.rbtn_dificultad_alta.Size = new System.Drawing.Size(43, 17);
            this.rbtn_dificultad_alta.TabIndex = 1;
            this.rbtn_dificultad_alta.Tag = "A";
            this.rbtn_dificultad_alta.Text = "Alta";
            this.rbtn_dificultad_alta.UseVisualStyleBackColor = true;
            this.rbtn_dificultad_alta.Click += new System.EventHandler(this.handleGame);
            // 
            // rbtn_dificultad_media
            // 
            this.rbtn_dificultad_media.AutoSize = true;
            this.rbtn_dificultad_media.Location = new System.Drawing.Point(127, 21);
            this.rbtn_dificultad_media.Name = "rbtn_dificultad_media";
            this.rbtn_dificultad_media.Size = new System.Drawing.Size(54, 17);
            this.rbtn_dificultad_media.TabIndex = 2;
            this.rbtn_dificultad_media.Tag = "M";
            this.rbtn_dificultad_media.Text = "Media";
            this.rbtn_dificultad_media.UseVisualStyleBackColor = true;
            this.rbtn_dificultad_media.Click += new System.EventHandler(this.handleGame);
            // 
            // rbtn_dificultad_baja
            // 
            this.rbtn_dificultad_baja.AutoSize = true;
            this.rbtn_dificultad_baja.Location = new System.Drawing.Point(75, 21);
            this.rbtn_dificultad_baja.Name = "rbtn_dificultad_baja";
            this.rbtn_dificultad_baja.Size = new System.Drawing.Size(46, 17);
            this.rbtn_dificultad_baja.TabIndex = 3;
            this.rbtn_dificultad_baja.Tag = "B";
            this.rbtn_dificultad_baja.Text = "Baja";
            this.rbtn_dificultad_baja.UseVisualStyleBackColor = true;
            this.rbtn_dificultad_baja.Click += new System.EventHandler(this.handleGame);
            // 
            // lbl_dificultad
            // 
            this.lbl_dificultad.AutoSize = true;
            this.lbl_dificultad.Location = new System.Drawing.Point(12, 21);
            this.lbl_dificultad.Name = "lbl_dificultad";
            this.lbl_dificultad.Size = new System.Drawing.Size(57, 13);
            this.lbl_dificultad.TabIndex = 4;
            this.lbl_dificultad.Text = "Dificultad: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_dificultad);
            this.Controls.Add(this.rbtn_dificultad_baja);
            this.Controls.Add(this.rbtn_dificultad_media);
            this.Controls.Add(this.rbtn_dificultad_alta);
            this.Controls.Add(this.buscaminasTableLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buscaminasTableLayout;
        private System.Windows.Forms.RadioButton rbtn_dificultad_alta;
        private System.Windows.Forms.RadioButton rbtn_dificultad_media;
        private System.Windows.Forms.RadioButton rbtn_dificultad_baja;
        private System.Windows.Forms.Label lbl_dificultad;
    }
}

