namespace Semana02
{
    partial class FrmPedidosDetalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CboAnios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgDetalle = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.TextBox();
            this.neptunoDataSet = new Semana02.neptunoDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Semana02.neptunoDataSetTableAdapters.PedidosTableAdapter();
            this.neptunoDataSet1 = new Semana02.neptunoDataSet1();
            this.detallesdepedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesdepedidosTableAdapter = new Semana02.neptunoDataSet1TableAdapters.detallesdepedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesdepedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // CboAnios
            // 
            this.CboAnios.FormattingEnabled = true;
            this.CboAnios.Location = new System.Drawing.Point(615, 21);
            this.CboAnios.Name = "CboAnios";
            this.CboAnios.Size = new System.Drawing.Size(192, 24);
            this.CboAnios.TabIndex = 1;
            this.CboAnios.SelectionChangeCommitted += new System.EventHandler(this.CboAnios_SelectionChangeCommitted_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // DgPedidos
            // 
            this.DgPedidos.AllowUserToAddRows = false;
            this.DgPedidos.AllowUserToDeleteRows = false;
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(12, 75);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.ReadOnly = true;
            this.DgPedidos.RowTemplate.Height = 24;
            this.DgPedidos.Size = new System.Drawing.Size(980, 148);
            this.DgPedidos.TabIndex = 3;
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "NRO PEDIDOS";
            // 
            // LblNumero
            // 
            this.LblNumero.Location = new System.Drawing.Point(686, 229);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(121, 22);
            this.LblNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "LISTA DE DETALLES";
            // 
            // DgDetalle
            // 
            this.DgDetalle.AllowUserToAddRows = false;
            this.DgDetalle.AllowUserToDeleteRows = false;
            this.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalle.Location = new System.Drawing.Point(12, 278);
            this.DgDetalle.Name = "DgDetalle";
            this.DgDetalle.ReadOnly = true;
            this.DgDetalle.RowTemplate.Height = 24;
            this.DgDetalle.Size = new System.Drawing.Size(980, 163);
            this.DgDetalle.TabIndex = 7;
            this.DgDetalle.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "MONTO DEL PEDIDO";
            // 
            // LblMonto
            // 
            this.LblMonto.Location = new System.Drawing.Point(687, 447);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(120, 22);
            this.LblMonto.TabIndex = 9;
            // 
            // neptunoDataSet
            // 
            this.neptunoDataSet.DataSetName = "neptunoDataSet";
            this.neptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.neptunoDataSet;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // neptunoDataSet1
            // 
            this.neptunoDataSet1.DataSetName = "neptunoDataSet1";
            this.neptunoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallesdepedidosBindingSource
            // 
            this.detallesdepedidosBindingSource.DataMember = "detallesdepedidos";
            this.detallesdepedidosBindingSource.DataSource = this.neptunoDataSet1;
            // 
            // detallesdepedidosTableAdapter
            // 
            this.detallesdepedidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPedidosDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 526);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboAnios);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidosDetalle";
            this.Text = "Ado Net Cep Sharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.CboAnios_SelectionChangeCommitted);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesdepedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox CboAnios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LblNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LblMonto;
        private neptunoDataSet neptunoDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private neptunoDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private neptunoDataSet1 neptunoDataSet1;
        private System.Windows.Forms.BindingSource detallesdepedidosBindingSource;
        private neptunoDataSet1TableAdapters.detallesdepedidosTableAdapter detallesdepedidosTableAdapter;
    }
}

