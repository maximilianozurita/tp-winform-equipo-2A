namespace tp_winform_equipo_2A
{
    partial class AgregarCategoria
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
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.nombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(52, 264);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Aceptar";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(157, 264);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Location = new System.Drawing.Point(122, 183);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(100, 20);
            this.nombreCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreCategoria);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            this.Load += new System.EventHandler(this.AgregarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox nombreCategoria;
        private System.Windows.Forms.Label label1;
    }
}