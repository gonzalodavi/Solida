namespace CapaPresentacion
{
    partial class FormTop20ProdVendCant
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTop20ProdVendCant));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.RPT_Prod_Vend_CantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPT_Prod_Vend_CantTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.RPT_Prod_Vend_CantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Prod_Vend_CantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPT_Prod_Vend_CantBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.InformeProductosMasVendidosCantidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(815, 497);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPT_Prod_Vend_CantBindingSource
            // 
            this.RPT_Prod_Vend_CantBindingSource.DataMember = "RPT_Prod_Vend_Cant";
            this.RPT_Prod_Vend_CantBindingSource.DataSource = this.dsPrincipal;
            // 
            // RPT_Prod_Vend_CantTableAdapter
            // 
            this.RPT_Prod_Vend_CantTableAdapter.ClearBeforeFill = true;
            // 
            // FormTop20ProdVendCant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 497);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTop20ProdVendCant";
            this.Text = "Productos Mas Vendidos";
            this.Load += new System.EventHandler(this.FormTop20ProdVendCant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Prod_Vend_CantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_Prod_Vend_CantBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.RPT_Prod_Vend_CantTableAdapter RPT_Prod_Vend_CantTableAdapter;
    }
}