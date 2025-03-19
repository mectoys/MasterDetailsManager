namespace UI
{
    partial class MasterDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetails));
            this.TabMasterDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.retirar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.aceptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.TabMasterDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMasterDetails
            // 
            this.TabMasterDetails.Controls.Add(this.tabPage1);
            this.TabMasterDetails.Controls.Add(this.tabPage2);
            this.TabMasterDetails.Location = new System.Drawing.Point(12, 36);
            this.TabMasterDetails.Name = "TabMasterDetails";
            this.TabMasterDetails.SelectedIndex = 0;
            this.TabMasterDetails.Size = new System.Drawing.Size(776, 435);
            this.TabMasterDetails.TabIndex = 0;
            this.TabMasterDetails.SelectedIndexChanged += new System.EventHandler(this.TabMasterDetails_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(6, 95);
            this.listado.Name = "listado";
            this.listado.ReadOnly = true;
            this.listado.RowHeadersWidth = 51;
            this.listado.RowTemplate.Height = 24;
            this.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listado.Size = new System.Drawing.Size(756, 304);
            this.listado.TabIndex = 11;
            this.listado.DoubleClick += new System.EventHandler(this.listado_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.retirar);
            this.tabPage2.Controls.Add(this.agregar);
            this.tabPage2.Controls.Add(this.precio);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cantidad);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.producto);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.detalle);
            this.tabPage2.Controls.Add(this.fecha);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cliente);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.codigo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(654, 267);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(71, 40);
            this.retirar.TabIndex = 24;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(654, 207);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(71, 40);
            this.agregar.TabIndex = 23;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(481, 158);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(80, 22);
            this.precio.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(329, 158);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(80, 22);
            this.cantidad.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad:";
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(93, 158);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(136, 22);
            this.producto.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Producto:";
            // 
            // detalle
            // 
            this.detalle.AllowUserToAddRows = false;
            this.detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle.Location = new System.Drawing.Point(27, 194);
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.RowHeadersWidth = 51;
            this.detalle.RowTemplate.Height = 24;
            this.detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle.Size = new System.Drawing.Size(605, 139);
            this.detalle.TabIndex = 16;
            this.detalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalle_CellClick);
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(96, 114);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(93, 22);
            this.fecha.TabIndex = 11;
            this.fecha.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(96, 70);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(228, 22);
            this.cliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(96, 18);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(54, 22);
            this.codigo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.aceptar,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 24);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // aceptar
            // 
            this.aceptar.Image = ((System.Drawing.Image)(resources.GetObject("aceptar.Image")));
            this.aceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(85, 24);
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 24);
            this.toolStripButton3.Text = "Anular";
            // 
            // MasterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TabMasterDetails);
            this.Name = "MasterDetails";
            this.Text = "MasterDetails";
            this.Load += new System.EventHandler(this.MasterDetails_Load);
            this.TabMasterDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabMasterDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView detalle;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton aceptar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

