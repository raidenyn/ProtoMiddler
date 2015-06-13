namespace ProtoMiddler
{
    partial class ProtoBufInspectorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtoFile = new System.Windows.Forms.TextBox();
            this.bnBrowse = new System.Windows.Forms.Button();
            this.protoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMessageType = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProtoPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRaw = new System.Windows.Forms.TabPage();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.tabPageTree = new System.Windows.Forms.TabPage();
            this.treeView = new System.Windows.Forms.TreeView();
            this.protoPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRaw.SuspendLayout();
            this.tabPageTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Protofile:";
            // 
            // txtProtoFile
            // 
            this.txtProtoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProtoFile.Location = new System.Drawing.Point(81, 36);
            this.txtProtoFile.Name = "txtProtoFile";
            this.txtProtoFile.Size = new System.Drawing.Size(662, 20);
            this.txtProtoFile.TabIndex = 2;
            this.txtProtoFile.TextChanged += new System.EventHandler(this.txtProtoFile_TextChanged);
            // 
            // bnBrowse
            // 
            this.bnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBrowse.Location = new System.Drawing.Point(749, 34);
            this.bnBrowse.Name = "bnBrowse";
            this.bnBrowse.Size = new System.Drawing.Size(75, 23);
            this.bnBrowse.TabIndex = 3;
            this.bnBrowse.Text = "Browse...";
            this.bnBrowse.UseVisualStyleBackColor = true;
            this.bnBrowse.Click += new System.EventHandler(this.bnBrowse_Click);
            // 
            // protoFileDialog
            // 
            this.protoFileDialog.Filter = "Proto Files|*.proto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // cbMessageType
            // 
            this.cbMessageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMessageType.FormattingEnabled = true;
            this.cbMessageType.Location = new System.Drawing.Point(81, 73);
            this.cbMessageType.Name = "cbMessageType";
            this.cbMessageType.Size = new System.Drawing.Size(662, 21);
            this.cbMessageType.TabIndex = 5;
            this.cbMessageType.SelectedIndexChanged += new System.EventHandler(this.cbMessageType_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectPath);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtProtoPath);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbMessageType);
            this.splitContainer1.Panel1.Controls.Add(this.txtProtoFile);
            this.splitContainer1.Panel1.Controls.Add(this.bnBrowse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(827, 401);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPath.Location = new System.Drawing.Point(749, 8);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 9;
            this.btnSelectPath.Text = "Browse...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proto Path:";
            // 
            // txtProtoPath
            // 
            this.txtProtoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProtoPath.Location = new System.Drawing.Point(81, 10);
            this.txtProtoPath.Name = "txtProtoPath";
            this.txtProtoPath.Size = new System.Drawing.Size(662, 20);
            this.txtProtoPath.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRaw);
            this.tabControl1.Controls.Add(this.tabPageTree);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 293);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageRaw
            // 
            this.tabPageRaw.Controls.Add(this.rtbData);
            this.tabPageRaw.Location = new System.Drawing.Point(4, 22);
            this.tabPageRaw.Name = "tabPageRaw";
            this.tabPageRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaw.Size = new System.Drawing.Size(819, 267);
            this.tabPageRaw.TabIndex = 0;
            this.tabPageRaw.Text = "Text";
            this.tabPageRaw.UseVisualStyleBackColor = true;
            // 
            // rtbData
            // 
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbData.Location = new System.Drawing.Point(3, 3);
            this.rtbData.Name = "rtbData";
            this.rtbData.ReadOnly = true;
            this.rtbData.Size = new System.Drawing.Size(813, 261);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            // 
            // tabPageTree
            // 
            this.tabPageTree.Controls.Add(this.treeView);
            this.tabPageTree.Location = new System.Drawing.Point(4, 22);
            this.tabPageTree.Name = "tabPageTree";
            this.tabPageTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTree.Size = new System.Drawing.Size(819, 267);
            this.tabPageTree.TabIndex = 1;
            this.tabPageTree.Text = "Tree";
            this.tabPageTree.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(813, 261);
            this.treeView.TabIndex = 0;
            // 
            // protoPathDialog
            // 
            this.protoPathDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.protoPathDialog.ShowNewFolderButton = false;
            // 
            // ProtoBufInspectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProtoBufInspectorControl";
            this.Size = new System.Drawing.Size(827, 401);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRaw.ResumeLayout(false);
            this.tabPageTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtoFile;
        private System.Windows.Forms.Button bnBrowse;
        private System.Windows.Forms.OpenFileDialog protoFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMessageType;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FolderBrowserDialog protoPathDialog;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProtoPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRaw;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.TabPage tabPageTree;
        private System.Windows.Forms.TreeView treeView;
    }
}
