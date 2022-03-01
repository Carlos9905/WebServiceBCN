namespace WSBCN
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbx_Container = new System.Windows.Forms.GroupBox();
            this.cbx_meses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tipoDeCambio = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoDeCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Container
            // 
            this.gbx_Container.Controls.Add(this.cbx_meses);
            this.gbx_Container.Controls.Add(this.label1);
            this.gbx_Container.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Container.Location = new System.Drawing.Point(12, 12);
            this.gbx_Container.Name = "gbx_Container";
            this.gbx_Container.Size = new System.Drawing.Size(472, 100);
            this.gbx_Container.TabIndex = 0;
            this.gbx_Container.TabStop = false;
            this.gbx_Container.Text = "Tipo de Cambio del Año 2022";
            // 
            // cbx_meses
            // 
            this.cbx_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_meses.FormattingEnabled = true;
            this.cbx_meses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo"});
            this.cbx_meses.Location = new System.Drawing.Point(71, 36);
            this.cbx_meses.Name = "cbx_meses";
            this.cbx_meses.Size = new System.Drawing.Size(121, 25);
            this.cbx_meses.TabIndex = 1;
            this.cbx_meses.SelectedIndexChanged += new System.EventHandler(this.cbx_meses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes de:";
            // 
            // dgv_tipoDeCambio
            // 
            this.dgv_tipoDeCambio.AllowUserToAddRows = false;
            this.dgv_tipoDeCambio.AllowUserToDeleteRows = false;
            this.dgv_tipoDeCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoDeCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.cambio,
            this.mes});
            this.dgv_tipoDeCambio.Location = new System.Drawing.Point(68, 118);
            this.dgv_tipoDeCambio.Name = "dgv_tipoDeCambio";
            this.dgv_tipoDeCambio.ReadOnly = true;
            this.dgv_tipoDeCambio.Size = new System.Drawing.Size(342, 433);
            this.dgv_tipoDeCambio.TabIndex = 1;
            // 
            // dia
            // 
            this.dia.Frozen = true;
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // cambio
            // 
            this.cambio.Frozen = true;
            this.cambio.HeaderText = "Córdoba por USD";
            this.cambio.Name = "cambio";
            this.cambio.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.Frozen = true;
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 563);
            this.Controls.Add(this.dgv_tipoDeCambio);
            this.Controls.Add(this.gbx_Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Central de Nicaragua";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbx_Container.ResumeLayout(false);
            this.gbx_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoDeCambio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Container;
        private System.Windows.Forms.ComboBox cbx_meses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tipoDeCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
    }
}

