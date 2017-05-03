namespace Stok_Takip.Siparis
{
    partial class Siparis_İzle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid_siparis_izle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.mayaStokDataSet1 = new Stok_Takip.MayaStokDataSet1();
            this.siparisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisDetayTableAdapter = new Stok_Takip.MayaStokDataSet1TableAdapters.SiparisDetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_siparis_izle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaStokDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grid_siparis_izle);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 641);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 0;
            // 
            // grid_siparis_izle
            // 
            this.grid_siparis_izle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_siparis_izle.Location = new System.Drawing.Point(0, 0);
            this.grid_siparis_izle.MainView = this.gridView1;
            this.grid_siparis_izle.Name = "grid_siparis_izle";
            this.grid_siparis_izle.Size = new System.Drawing.Size(1036, 586);
            this.grid_siparis_izle.TabIndex = 0;
            this.grid_siparis_izle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_siparis_izle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // mayaStokDataSet1
            // 
            this.mayaStokDataSet1.DataSetName = "MayaStokDataSet1";
            this.mayaStokDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisDetayBindingSource
            // 
            this.siparisDetayBindingSource.DataMember = "SiparisDetay";
            this.siparisDetayBindingSource.DataSource = this.mayaStokDataSet1;
            // 
            // siparisDetayTableAdapter
            // 
            this.siparisDetayTableAdapter.ClearBeforeFill = true;
            // 
            // Siparis_İzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Siparis_İzle";
            this.Text = "Siparis_İzle";
            this.Load += new System.EventHandler(this.Siparis_İzle_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_siparis_izle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaStokDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDetayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private MayaStokDataSet1 mayaStokDataSet1;
        private System.Windows.Forms.BindingSource siparisDetayBindingSource;
        private MayaStokDataSet1TableAdapters.SiparisDetayTableAdapter siparisDetayTableAdapter;
        private DevExpress.XtraGrid.GridControl grid_siparis_izle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}