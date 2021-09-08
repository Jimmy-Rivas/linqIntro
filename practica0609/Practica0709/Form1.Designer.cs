
namespace Practica0709
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
            this.DataDg = new System.Windows.Forms.DataGridView();
            this.btnfull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDg)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDg
            // 
            this.DataDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDg.Location = new System.Drawing.Point(314, 48);
            this.DataDg.Name = "DataDg";
            this.DataDg.RowHeadersWidth = 51;
            this.DataDg.RowTemplate.Height = 24;
            this.DataDg.Size = new System.Drawing.Size(404, 288);
            this.DataDg.TabIndex = 0;
            this.DataDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(113, 171);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(145, 23);
            this.btnfull.TabIndex = 1;
            this.btnfull.Text = "GET student";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(789, 437);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.DataDg);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgData;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.DataGridView DataDg;
        private System.Windows.Forms.Button btnfull;
    }
}

