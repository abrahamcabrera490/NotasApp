namespace NotasApp
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
            this.components = new System.ComponentModel.Container();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(99, 58);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(317, 26);
            this.txttitle.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(99, 117);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(317, 325);
            this.txtdescription.TabIndex = 1;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AutoGenerateColumns = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn});
            this.dgvTask.DataSource = this.noteBindingSource;
            this.dgvTask.Location = new System.Drawing.Point(505, 58);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersWidth = 62;
            this.dgvTask.RowTemplate.Height = 28;
            this.dgvTask.Size = new System.Drawing.Size(361, 384);
            this.dgvTask.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(12, 64);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(47, 20);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Titulo";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 117);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 20);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Nota";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(99, 456);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 33);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "Nuevo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(341, 456);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 33);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(576, 456);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 33);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Leer";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(791, 456);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(NotasApp.Note);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(905, 501);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttitle);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource noteBindingSource;
    }
}

