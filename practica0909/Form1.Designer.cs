
namespace practica0909
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
            this.btaGetName = new System.Windows.Forms.Button();
            this.btaGetData = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btaBorrar = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btaGetName
            // 
            this.btaGetName.BackColor = System.Drawing.Color.Beige;
            this.btaGetName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btaGetName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaGetName.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btaGetName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btaGetName.Location = new System.Drawing.Point(12, 355);
            this.btaGetName.Name = "btaGetName";
            this.btaGetName.Size = new System.Drawing.Size(90, 46);
            this.btaGetName.TabIndex = 0;
            this.btaGetName.Text = "Obtener Nombre";
            this.btaGetName.UseVisualStyleBackColor = false;
            this.btaGetName.Click += new System.EventHandler(this.btaGetName_Click);
            // 
            // btaGetData
            // 
            this.btaGetData.BackColor = System.Drawing.Color.Beige;
            this.btaGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaGetData.Location = new System.Drawing.Point(531, 355);
            this.btaGetData.Name = "btaGetData";
            this.btaGetData.Size = new System.Drawing.Size(90, 46);
            this.btaGetData.TabIndex = 1;
            this.btaGetData.Text = "Obtener Datos";
            this.btaGetData.UseVisualStyleBackColor = false;
            this.btaGetData.Click += new System.EventHandler(this.btaGetData_Click);
            // 
            // lstName
            // 
            this.lstName.BackColor = System.Drawing.SystemColors.Info;
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(29, 33);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(153, 316);
            this.lstName.TabIndex = 2;
            // 
            // btaBorrar
            // 
            this.btaBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btaBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btaBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btaBorrar.Location = new System.Drawing.Point(108, 355);
            this.btaBorrar.Name = "btaBorrar";
            this.btaBorrar.Size = new System.Drawing.Size(90, 46);
            this.btaBorrar.TabIndex = 3;
            this.btaBorrar.Text = "Borrar";
            this.btaBorrar.UseVisualStyleBackColor = true;
            this.btaBorrar.Click += new System.EventHandler(this.btaBorrar_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(267, 33);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(547, 300);
            this.dgData.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(855, 407);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btaBorrar);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btaGetData);
            this.Controls.Add(this.btaGetName);
            this.Name = "Form1";
            this.Text = "Estudiante";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btaGetName;
        private System.Windows.Forms.Button btaGetData;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btaBorrar;
        private System.Windows.Forms.DataGridView dgData;
    }
}

