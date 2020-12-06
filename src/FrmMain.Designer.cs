namespace FileMental
{
    partial class FrmMain
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
            this.olvFileList = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFileList
            // 
            this.olvFileList.AllColumns.Add(this.olvColumn1);
            this.olvFileList.AllColumns.Add(this.olvColumn2);
            this.olvFileList.AllColumns.Add(this.olvColumn3);
            this.olvFileList.AllColumns.Add(this.olvColumn4);
            this.olvFileList.AllColumns.Add(this.olvColumn5);
            this.olvFileList.CellEditUseWholeCell = false;
            this.olvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.olvFileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFileList.FullRowSelect = true;
            this.olvFileList.GridLines = true;
            this.olvFileList.HideSelection = false;
            this.olvFileList.IsSimpleDropSink = true;
            this.olvFileList.Location = new System.Drawing.Point(15, 85);
            this.olvFileList.Name = "olvFileList";
            this.olvFileList.ShowGroups = false;
            this.olvFileList.Size = new System.Drawing.Size(695, 419);
            this.olvFileList.TabIndex = 0;
            this.olvFileList.UseCompatibleStateImageBehavior = false;
            this.olvFileList.UseHotItem = true;
            this.olvFileList.View = System.Windows.Forms.View.Details;
            this.olvFileList.VirtualMode = true;
            this.olvFileList.CanDrop += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.olvFileList_CanDrop);
            this.olvFileList.Dropped += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.olvFileList_DroppedAsync);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 200;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Ext";
            this.olvColumn2.Text = "Ext";
            this.olvColumn2.Width = 40;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Size";
            this.olvColumn3.AspectToStringFormat = "{0:n0}";
            this.olvColumn3.Text = "Size";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn3.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "DateChanged";
            this.olvColumn4.Text = "Modified Date";
            this.olvColumn4.Width = 120;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "DateCreated";
            this.olvColumn5.Text = "Created Date";
            this.olvColumn5.Width = 120;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 519);
            this.Controls.Add(this.olvFileList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView olvFileList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
    }
}

