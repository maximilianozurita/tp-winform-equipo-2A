﻿namespace tp_winform_equipo_2A
{
    partial class AddForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.codeValidationLabel = new System.Windows.Forms.Label();
            this.nameValidationLabel = new System.Windows.Forms.Label();
            this.brandValidationLabel = new System.Windows.Forms.Label();
            this.categoryValidationLabel = new System.Windows.Forms.Label();
            this.priceValidationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Menu;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(129, 378);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 29);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Añadir";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Menu;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(303, 378);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImagePictureBox.Location = new System.Drawing.Point(329, 40);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(169, 183);
            this.ImagePictureBox.TabIndex = 2;
            this.ImagePictureBox.TabStop = false;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(30, 40);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(46, 15);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Codigo";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(30, 81);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(30, 123);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Descripcion";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.BackColor = System.Drawing.SystemColors.Control;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(30, 202);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(42, 15);
            this.brandLabel.TabIndex = 6;
            this.brandLabel.Text = "Marca";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(30, 239);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 15);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Categoria";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Location = new System.Drawing.Point(30, 280);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(49, 15);
            this.imageLabel.TabIndex = 8;
            this.imageLabel.Text = "Imagen";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(30, 322);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(42, 15);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Precio";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(138, 37);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeTextBox.MaxLength = 32;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(92, 21);
            this.codeTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(138, 79);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.MaxLength = 32;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(92, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(138, 120);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.MaxLength = 1024;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(138, 67);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // imageTextBox
            // 
            this.imageTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.imageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTextBox.Location = new System.Drawing.Point(138, 278);
            this.imageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageTextBox.MaxLength = 512;
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(92, 21);
            this.imageTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(138, 319);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.MaxLength = 16;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(92, 21);
            this.priceTextBox.TabIndex = 6;
            // 
            // brandComboBox
            // 
            this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(138, 200);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(92, 23);
            this.brandComboBox.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(138, 236);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(92, 23);
            this.categoryComboBox.TabIndex = 4;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.addCategoryButton.Enabled = false;
            this.addCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.Location = new System.Drawing.Point(233, 236);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(28, 24);
            this.addCategoryButton.TabIndex = 18;
            this.addCategoryButton.Text = "...";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // codeValidationLabel
            // 
            this.codeValidationLabel.AutoSize = true;
            this.codeValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeValidationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.codeValidationLabel.Location = new System.Drawing.Point(233, 40);
            this.codeValidationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeValidationLabel.Name = "codeValidationLabel";
            this.codeValidationLabel.Size = new System.Drawing.Size(61, 15);
            this.codeValidationLabel.TabIndex = 21;
            this.codeValidationLabel.Text = "Validation";
            // 
            // nameValidationLabel
            // 
            this.nameValidationLabel.AutoSize = true;
            this.nameValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValidationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.nameValidationLabel.Location = new System.Drawing.Point(233, 81);
            this.nameValidationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameValidationLabel.Name = "nameValidationLabel";
            this.nameValidationLabel.Size = new System.Drawing.Size(61, 15);
            this.nameValidationLabel.TabIndex = 22;
            this.nameValidationLabel.Text = "Validation";
            // 
            // brandValidationLabel
            // 
            this.brandValidationLabel.AutoSize = true;
            this.brandValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandValidationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.brandValidationLabel.Location = new System.Drawing.Point(233, 202);
            this.brandValidationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandValidationLabel.Name = "brandValidationLabel";
            this.brandValidationLabel.Size = new System.Drawing.Size(61, 15);
            this.brandValidationLabel.TabIndex = 23;
            this.brandValidationLabel.Text = "Validation";
            // 
            // categoryValidationLabel
            // 
            this.categoryValidationLabel.AutoSize = true;
            this.categoryValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryValidationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.categoryValidationLabel.Location = new System.Drawing.Point(266, 241);
            this.categoryValidationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryValidationLabel.Name = "categoryValidationLabel";
            this.categoryValidationLabel.Size = new System.Drawing.Size(61, 15);
            this.categoryValidationLabel.TabIndex = 24;
            this.categoryValidationLabel.Text = "Validation";
            // 
            // priceValidationLabel
            // 
            this.priceValidationLabel.AutoSize = true;
            this.priceValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceValidationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.priceValidationLabel.Location = new System.Drawing.Point(233, 324);
            this.priceValidationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceValidationLabel.Name = "priceValidationLabel";
            this.priceValidationLabel.Size = new System.Drawing.Size(61, 15);
            this.priceValidationLabel.TabIndex = 25;
            this.priceValidationLabel.Text = "Validation";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(518, 434);
            this.Controls.Add(this.priceValidationLabel);
            this.Controls.Add(this.categoryValidationLabel);
            this.Controls.Add(this.brandValidationLabel);
            this.Controls.Add(this.nameValidationLabel);
            this.Controls.Add(this.codeValidationLabel);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label codeValidationLabel;
        private System.Windows.Forms.Label nameValidationLabel;
        private System.Windows.Forms.Label brandValidationLabel;
        private System.Windows.Forms.Label categoryValidationLabel;
        private System.Windows.Forms.Label priceValidationLabel;
    }
}