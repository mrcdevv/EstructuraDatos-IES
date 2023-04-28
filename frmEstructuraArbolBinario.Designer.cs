namespace pryEstructuraDatos
{
    partial class frmEstructuraArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraArbolBinario));
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.gbEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.lstCodigo);
            this.gbEliminado.Controls.Add(this.btnEliminar);
            this.gbEliminado.Controls.Add(this.label6);
            this.gbEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbEliminado.Location = new System.Drawing.Point(473, 10);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Size = new System.Drawing.Size(228, 118);
            this.gbEliminado.TabIndex = 24;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Elemento a eliminar";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(77, 27);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(133, 28);
            this.lstCodigo.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(47, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.tramite});
            this.dgvDatos.Location = new System.Drawing.Point(226, 245);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(475, 164);
            this.dgvDatos.TabIndex = 23;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // tramite
            // 
            this.tramite.HeaderText = "Tramite";
            this.tramite.Name = "tramite";
            // 
            // lstDatos
            // 
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(19, 245);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(182, 164);
            this.lstDatos.TabIndex = 22;
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbNuevo.Location = new System.Drawing.Point(226, 10);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(228, 225);
            this.gbNuevo.TabIndex = 21;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 169);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 39);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(76, 117);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(136, 26);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(4, 120);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(66, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // picImagen
            // 
            this.picImagen.Image = ((System.Drawing.Image)(resources.GetObject("picImagen.Image")));
            this.picImagen.Location = new System.Drawing.Point(19, 10);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(182, 217);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 20;
            this.picImagen.TabStop = false;
            // 
            // frmEstructuraArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 419);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.picImagen);
            this.Name = "frmEstructuraArbolBinario";
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramite;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox picImagen;
    }
}