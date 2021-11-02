namespace CapaPresentacion
{
    partial class FormDetalleCtaCteProveedorSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleCtaCteProveedorSimple));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.ReporteSimpleCtaCteCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteSimpleCtaCteCTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ReporteSimpleCtaCteCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteSimpleCtaCteCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteSimpleCtaCteCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.InformeDetalleCtaCteProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1087, 589);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteSimpleCtaCteCBindingSource
            // 
            this.ReporteSimpleCtaCteCBindingSource.DataMember = "ReporteSimpleCtaCteC";
            this.ReporteSimpleCtaCteCBindingSource.DataSource = this.dsPrincipal;
            // 
            // ReporteSimpleCtaCteCTableAdapter
            // 
            this.ReporteSimpleCtaCteCTableAdapter.ClearBeforeFill = true;
            // 
            // FormDetalleCtaCteProveedorSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 589);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetalleCtaCteProveedorSimple";
            this.Text = "Detalle Cuenta Corriente";
            this.Load += new System.EventHandler(this.FormDetalleCtaCteProveedorSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteSimpleCtaCteCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteSimpleCtaCteCBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.ReporteSimpleCtaCteCTableAdapter ReporteSimpleCtaCteCTableAdapter;
    }
}