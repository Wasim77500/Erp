namespace ERP.Inventory
{
    partial class frmCatagoriesTree
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatagoriesTree));
            this.tvItemsTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.btnGetNode = new ERP.myBottun();
            this.txtNodeName = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvItemsTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(77, 34);
            // 
            // tvItemsTree
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            treeNodeAdvStyleInfo1.ShowCheckBox = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.tvItemsTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvItemsTree.BeforeTouchSize = new System.Drawing.Size(322, 399);
            this.tvItemsTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvItemsTree.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvItemsTree.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tvItemsTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvItemsTree.HelpTextControl.Name = "helpText";
            this.tvItemsTree.HelpTextControl.TabIndex = 0;
            this.tvItemsTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvItemsTree.Location = new System.Drawing.Point(0, 64);
            this.tvItemsTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvItemsTree.Name = "tvItemsTree";
            this.tvItemsTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvItemsTree.Size = new System.Drawing.Size(322, 399);
            this.tvItemsTree.TabIndex = 7;
            // 
            // 
            // 
            this.tvItemsTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvItemsTree.ToolTipControl.Name = "toolTip";
            this.tvItemsTree.ToolTipControl.TabIndex = 1;
            this.tvItemsTree.NodeMouseDoubleClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.tvItemsTree_NodeMouseDoubleClick);
            // 
            // btnGetNode
            // 
            this.btnGetNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetNode.BackgroundImage")));
            this.btnGetNode.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetNode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.FlatAppearance.BorderSize = 0;
            this.btnGetNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetNode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.Image = ((System.Drawing.Image)(resources.GetObject("btnGetNode.Image")));
            this.btnGetNode.IsBackStageButton = false;
            this.btnGetNode.Location = new System.Drawing.Point(252, 34);
            this.btnGetNode.Name = "btnGetNode";
            this.btnGetNode.Size = new System.Drawing.Size(28, 27);
            this.btnGetNode.TabIndex = 247;
            this.btnGetNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetNode.UseVisualStyleBackColor = true;
            this.btnGetNode.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetNode.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetNode.Click += new System.EventHandler(this.btnGetNode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtNodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNodeName.Location = new System.Drawing.Point(70, 34);
            this.txtNodeName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(176, 25);
            this.txtNodeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNodeName.TabIndex = 246;
            this.txtNodeName.W_Clear = true;
            this.txtNodeName.W_ColArName = "اسم دخول المستخدم";
            this.txtNodeName.W_ColEgName = "USER_LOGIN";
            this.txtNodeName.W_OldValue = "";
            this.txtNodeName.W_TableName = "USERINFO";
            this.txtNodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNodeName_KeyDown);
            // 
            // frmCatagoriesTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(322, 463);
            this.Controls.Add(this.btnGetNode);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.tvItemsTree);
            this.Name = "frmCatagoriesTree";
            this.Load += new System.EventHandler(this.frmCatagoriesTree_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.tvItemsTree, 0);
            this.Controls.SetChildIndex(this.txtNodeName, 0);
            this.Controls.SetChildIndex(this.btnGetNode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvItemsTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvItemsTree;
        private myText txtNodeName;
        private myBottun btnGetNode;
    }
}
