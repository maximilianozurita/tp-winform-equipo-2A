namespace tp_winform_equipo_2A
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addProductButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.detailProductButton = new System.Windows.Forms.Button();
            this.dataGridViewArticulo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameCategoria = new System.Windows.Forms.ComboBox();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameMarca = new System.Windows.Forms.ComboBox();
            this.ListCategorias = new System.Windows.Forms.Button();
            this.ListMarcas = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            resources.ApplyResources(this.addProductButton, "addProductButton");
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Name = "panel1";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Name = "titleLabel";
            // 
            // detailProductButton
            // 
            resources.ApplyResources(this.detailProductButton, "detailProductButton");
            this.detailProductButton.Name = "detailProductButton";
            this.detailProductButton.UseVisualStyleBackColor = true;
            this.detailProductButton.Click += new System.EventHandler(this.detailProductButton_Click);
            // 
            // dataGridViewArticulo
            // 
            resources.ApplyResources(this.dataGridViewArticulo, "dataGridViewArticulo");
            this.dataGridViewArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewArticulo.MultiSelect = false;
            this.dataGridViewArticulo.Name = "dataGridViewArticulo";
            this.dataGridViewArticulo.RowTemplate.Height = 24;
            this.dataGridViewArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulo.SelectionChanged += new System.EventHandler(this.dataGridViewArticulo_SelectionChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // deleteProductButton
            // 
            resources.ApplyResources(this.deleteProductButton, "deleteProductButton");
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // textFiltro
            // 
            resources.ApplyResources(this.textFiltro, "textFiltro");
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // filterButton
            // 
            resources.ApplyResources(this.filterButton, "filterButton");
            this.filterButton.Name = "filterButton";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nameCategoria
            // 
            resources.ApplyResources(this.nameCategoria, "nameCategoria");
            this.nameCategoria.FormattingEnabled = true;
            this.nameCategoria.Name = "nameCategoria";
            // 
            // modifyProductButton
            // 
            resources.ApplyResources(this.modifyProductButton, "modifyProductButton");
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // pictureBoxArticulo
            // 
            resources.ApplyResources(this.pictureBoxArticulo, "pictureBoxArticulo");
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // nameMarca
            // 
            this.nameMarca.FormattingEnabled = true;
            resources.ApplyResources(this.nameMarca, "nameMarca");
            this.nameMarca.Name = "nameMarca";
            // 
            // ListCategorias
            // 
            resources.ApplyResources(this.ListCategorias, "ListCategorias");
            this.ListCategorias.Name = "ListCategorias";
            this.ListCategorias.UseVisualStyleBackColor = true;
            this.ListCategorias.Click += new System.EventHandler(this.ListCategorias_Click);
            // 
            // ListMarcas
            // 
            resources.ApplyResources(this.ListMarcas, "ListMarcas");
            this.ListMarcas.Name = "ListMarcas";
            this.ListMarcas.UseVisualStyleBackColor = true;
            this.ListMarcas.Click += new System.EventHandler(this.ListMarcas_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.ListMarcas);
            this.flowLayoutPanel1.Controls.Add(this.ListCategorias);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.nameMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.nameCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewArticulo);
            this.Controls.Add(this.detailProductButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button detailProductButton;
        private System.Windows.Forms.DataGridView dataGridViewArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nameCategoria;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nameMarca;
        private System.Windows.Forms.Button ListCategorias;
        private System.Windows.Forms.Button ListMarcas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
    }
}

