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
            this.busqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.nuevo = new System.Windows.Forms.ToolStripButton();
            this.aceptar = new System.Windows.Forms.ToolStripButton();
            this.anular = new System.Windows.Forms.ToolStripButton();
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
            resources.ApplyResources(this.TabMasterDetails, "TabMasterDetails");
            this.TabMasterDetails.Controls.Add(this.tabPage1);
            this.TabMasterDetails.Controls.Add(this.tabPage2);
            this.TabMasterDetails.Name = "TabMasterDetails";
            this.TabMasterDetails.SelectedIndex = 0;
            this.TabMasterDetails.SelectedIndexChanged += new System.EventHandler(this.TabMasterDetails_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.busqueda);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listado);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // busqueda
            // 
            resources.ApplyResources(this.busqueda, "busqueda");
            this.busqueda.Name = "busqueda";
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.busqueda_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // listado
            // 
            resources.ApplyResources(this.listado, "listado");
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Name = "listado";
            this.listado.ReadOnly = true;
            this.listado.RowTemplate.Height = 24;
            this.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // retirar
            // 
            resources.ApplyResources(this.retirar, "retirar");
            this.retirar.Name = "retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // agregar
            // 
            resources.ApplyResources(this.agregar, "agregar");
            this.agregar.Name = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // precio
            // 
            resources.ApplyResources(this.precio, "precio");
            this.precio.Name = "precio";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cantidad
            // 
            resources.ApplyResources(this.cantidad, "cantidad");
            this.cantidad.Name = "cantidad";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // producto
            // 
            resources.ApplyResources(this.producto, "producto");
            this.producto.Name = "producto";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // detalle
            // 
            this.detalle.AllowUserToAddRows = false;
            this.detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.detalle, "detalle");
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.RowTemplate.Height = 24;
            this.detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalle_CellClick);
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.fecha, "fecha");
            this.fecha.Name = "fecha";
            this.fecha.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cliente
            // 
            resources.ApplyResources(this.cliente, "cliente");
            this.cliente.Name = "cliente";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.codigo, "codigo");
            this.codigo.Name = "codigo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo,
            this.aceptar,
            this.anular});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // nuevo
            // 
            resources.ApplyResources(this.nuevo, "nuevo");
            this.nuevo.Name = "nuevo";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // aceptar
            // 
            resources.ApplyResources(this.aceptar, "aceptar");
            this.aceptar.Name = "aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // anular
            // 
            resources.ApplyResources(this.anular, "anular");
            this.anular.Name = "anular";
            this.anular.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MasterDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TabMasterDetails);
            this.KeyPreview = true;
            this.Name = "MasterDetails";
            this.Load += new System.EventHandler(this.MasterDetails_Load);
            this.TabMasterDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton nuevo;
        private System.Windows.Forms.ToolStripButton aceptar;
        private System.Windows.Forms.ToolStripButton anular;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.Label label7;
    }
}

