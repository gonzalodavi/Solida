namespace CapaPresentacion
{
    partial class FormTop20ProdCompImporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTop20ProdCompImporte));
            this.RPT_Prod_Compra_PrecioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPT_Prod_Compra_PrecioTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.RPT_Prod_Compra_PrecioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Prod_Compra_PrecioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_Prod_Compra_PrecioBindingSource
            // 
            this.RPT_Prod_Compra_PrecioBindingSource.DataMember = "RPT_Prod_Compra_Precio";
            this.RPT_Prod_Compra_PrecioBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPT_Prod_Compra_PrecioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptProductosCompradosxImporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(860, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPT_Prod_Compra_PrecioTableAdapter
            // 
            this.RPT_Prod_Compra_PrecioTableAdapter.ClearBeforeFill = true;
            // 
            // FormTop20ProdCompImporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 590);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTop20ProdCompImporte";
            this.Text = "Listado de Productos Comprados";
            this.Load += new System.EventHandler(this.FormTop20ProdCompImporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Prod_Compra_PrecioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_Prod_Compra_PrecioBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.RPT_Prod_Compra_PrecioTableAdapter RPT_Prod_Compra_PrecioTableAdapter;
    }
}