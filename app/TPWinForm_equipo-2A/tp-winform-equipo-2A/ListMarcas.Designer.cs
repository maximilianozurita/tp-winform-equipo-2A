namespace tp_winform_equipo_2A
{
    partial class ListMarcas
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
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.AgregarMarcas = new System.Windows.Forms.Button();
            this.ModificarMarcas = new System.Windows.Forms.Button();
            this.EliminarMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMarca.Location = new System.Drawing.Point(47, 74);
            this.dataGridViewMarca.MultiSelect = false;
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarca.Size = new System.Drawing.Size(270, 273);
            this.dataGridViewMarca.TabIndex = 0;
            // 
            // AgregarMarcas
            // 
            this.AgregarMarcas.Location = new System.Drawing.Point(47, 367);
            this.AgregarMarcas.Name = "AgregarMarcas";
            this.AgregarMarcas.Size = new System.Drawing.Size(75, 23);
            this.AgregarMarcas.TabIndex = 1;
            this.AgregarMarcas.Text = "Agregar";
            this.AgregarMarcas.UseVisualStyleBackColor = true;
            this.AgregarMarcas.Click += new System.EventHandler(this.AgregarMarcas_Click);
            // 
            // ModificarMarcas
            // 
            this.ModificarMarcas.Location = new System.Drawing.Point(145, 367);
            this.ModificarMarcas.Name = "ModificarMarcas";
            this.ModificarMarcas.Size = new System.Drawing.Size(75, 23);
            this.ModificarMarcas.TabIndex = 2;
            this.ModificarMarcas.Text = "Modificar";
            this.ModificarMarcas.UseVisualStyleBackColor = true;
            this.ModificarMarcas.Click += new System.EventHandler(this.ModificarMarcas_Click);
            // 
            // EliminarMarca
            // 
            this.EliminarMarca.Location = new System.Drawing.Point(242, 367);
            this.EliminarMarca.Name = "EliminarMarca";
            this.EliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.EliminarMarca.TabIndex = 3;
            this.EliminarMarca.Text = "Eliminar";
            this.EliminarMarca.UseVisualStyleBackColor = true;
            this.EliminarMarca.Click += new System.EventHandler(this.EliminarMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marcas";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(145, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ListMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarMarca);
            this.Controls.Add(this.ModificarMarcas);
            this.Controls.Add(this.AgregarMarcas);
            this.Controls.Add(this.dataGridViewMarca);
            this.Name = "ListMarcas";
            this.Text = "ListMarcas";
            this.Load += new System.EventHandler(this.ListMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.Button AgregarMarcas;
        private System.Windows.Forms.Button ModificarMarcas;
        private System.Windows.Forms.Button EliminarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}