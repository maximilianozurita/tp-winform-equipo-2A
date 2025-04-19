namespace tp_winform_equipo_2A
{
    partial class ListCategoria
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
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.AgregarCategoria = new System.Windows.Forms.Button();
            this.ModificarCategoria = new System.Windows.Forms.Button();
            this.eliminarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.Size = new System.Drawing.Size(288, 334);
            this.dataGridViewCategoria.TabIndex = 0;
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.Location = new System.Drawing.Point(12, 393);
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.AgregarCategoria.TabIndex = 1;
            this.AgregarCategoria.Text = "Agregar";
            this.AgregarCategoria.UseVisualStyleBackColor = true;
            this.AgregarCategoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
            // 
            // ModificarCategoria
            // 
            this.ModificarCategoria.Location = new System.Drawing.Point(112, 393);
            this.ModificarCategoria.Name = "ModificarCategoria";
            this.ModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.ModificarCategoria.TabIndex = 2;
            this.ModificarCategoria.Text = "Modificar";
            this.ModificarCategoria.UseVisualStyleBackColor = true;
            this.ModificarCategoria.Click += new System.EventHandler(this.ModificarCategoria_Click);
            // 
            // eliminarCategoria
            // 
            this.eliminarCategoria.Location = new System.Drawing.Point(225, 393);
            this.eliminarCategoria.Name = "eliminarCategoria";
            this.eliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.eliminarCategoria.TabIndex = 3;
            this.eliminarCategoria.Text = "Eliminar";
            this.eliminarCategoria.UseVisualStyleBackColor = true;
            this.eliminarCategoria.Click += new System.EventHandler(this.EliminarCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorias";
            // 
            // ListCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarCategoria);
            this.Controls.Add(this.ModificarCategoria);
            this.Controls.Add(this.AgregarCategoria);
            this.Controls.Add(this.dataGridViewCategoria);
            this.Name = "ListCategoria";
            this.Text = "ListCategoria";
            this.Load += new System.EventHandler(this.ListCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Button AgregarCategoria;
        private System.Windows.Forms.Button ModificarCategoria;
        private System.Windows.Forms.Button eliminarCategoria;
        private System.Windows.Forms.Label label1;
    }
}