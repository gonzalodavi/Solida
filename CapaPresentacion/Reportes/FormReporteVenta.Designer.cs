namespace CapaPresentacion
{
    partial class FormReporteVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVenta));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.ReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVentasTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ReporteVentasTableAdapter();
            this.bd2DataSet = new CapaPresentacion.bd2DataSet();
            this.DatosEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosEmpresaTableAdapter = new CapaPresentacion.bd2DataSetTableAdapters.DatosEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteVentasBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DatosEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptComprobanteVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(707, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteVentasBindingSource
            // 
            this.ReporteVentasBindingSource.DataMember = "ReporteVentas";
            this.ReporteVentasBindingSource.DataSource = this.dsPrincipal;
            // 
            // ReporteVentasTableAdapter
            // 
            this.ReporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // bd2DataSet
            // 
            this.bd2DataSet.DataSetName = "bd2DataSet";
            this.bd2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosEmpresaBindingSource
            // 
            this.DatosEmpresaBindingSource.DataMember = "DatosEmpresa";
            this.DatosEmpresaBindingSource.DataSource = this.bd2DataSet;
            // 
            // DatosEmpresaTableAdapter
            // 
            this.DatosEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 592);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA DE VENTA";
            this.Load += new System.EventHandler(this.FormReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteVentasBindingSource;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource DatosEmpresaBindingSource;
        private bd2DataSet bd2DataSet;
        private dsPrincipalTableAdapters.ReporteVentasTableAdapter ReporteVentasTableAdapter;
        private bd2DataSetTableAdapters.DatosEmpresaTableAdapter DatosEmpresaTableAdapter;
    }
}