namespace gestiondecontactoswinforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl3 = new System.Windows.Forms.Label();
            this.nameLbl4 = new System.Windows.Forms.Label();
            this.phLbl4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchContact = new System.Windows.Forms.TextBox();
            this.btnSearchContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de contactos";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(73, 103);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(40, 33);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "id";
            // 
            // nameLbl3
            // 
            this.nameLbl3.AutoSize = true;
            this.nameLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl3.Location = new System.Drawing.Point(73, 171);
            this.nameLbl3.Name = "nameLbl3";
            this.nameLbl3.Size = new System.Drawing.Size(97, 33);
            this.nameLbl3.TabIndex = 3;
            this.nameLbl3.Text = "Name";
            // 
            // nameLbl4
            // 
            this.nameLbl4.AutoSize = true;
            this.nameLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl4.Location = new System.Drawing.Point(79, 251);
            this.nameLbl4.Name = "nameLbl4";
            this.nameLbl4.Size = new System.Drawing.Size(94, 33);
            this.nameLbl4.TabIndex = 4;
            this.nameLbl4.Text = "Email";
            // 
            // phLbl4
            // 
            this.phLbl4.AutoSize = true;
            this.phLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phLbl4.Location = new System.Drawing.Point(79, 330);
            this.phLbl4.Name = "phLbl4";
            this.phLbl4.Size = new System.Drawing.Size(103, 33);
            this.phLbl4.TabIndex = 5;
            this.phLbl4.Text = "Phone";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(79, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 6;
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(79, 207);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(120, 29);
            this.txtB1.TabIndex = 7;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(79, 287);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(120, 29);
            this.txtB2.TabIndex = 8;
            // 
            // txtB3
            // 
            this.txtB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB3.Location = new System.Drawing.Point(79, 366);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(120, 35);
            this.txtB3.TabIndex = 9;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(565, 298);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(223, 47);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contactos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(293, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 316);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnDelete.Location = new System.Drawing.Point(565, 397);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(223, 41);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "ActualizarContacto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchContact
            // 
            this.SearchContact.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchContact.Location = new System.Drawing.Point(576, 124);
            this.SearchContact.Name = "SearchContact";
            this.SearchContact.Size = new System.Drawing.Size(172, 33);
            this.SearchContact.TabIndex = 17;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.Location = new System.Drawing.Point(576, 164);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(172, 40);
            this.btnSearchContact.TabIndex = 18;
            this.btnSearchContact.Text = "Buscar contacto";
            this.btnSearchContact.UseVisualStyleBackColor = false;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.SearchContact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.phLbl4);
            this.Controls.Add(this.nameLbl4);
            this.Controls.Add(this.nameLbl3);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión de contactos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl3;
        private System.Windows.Forms.Label nameLbl4;
        private System.Windows.Forms.Label phLbl4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchContact;
        private System.Windows.Forms.Button btnSearchContact;
    }
}

