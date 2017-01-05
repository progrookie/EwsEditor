﻿namespace EWSEditor.Forms
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmboSearchType = new System.Windows.Forms.ComboBox();
            this.txtAQS = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.chkBody = new System.Windows.Forms.CheckBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.chkCC = new System.Windows.Forms.CheckBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.chkTo = new System.Windows.Forms.CheckBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.chkSubject = new System.Windows.Forms.CheckBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoAqsSearch = new System.Windows.Forms.RadioButton();
            this.rdoFindItemSearch = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numPageSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.chkClass = new System.Windows.Forms.CheckBox();
            this.cmboSearchDepth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboSubjectConditional = new System.Windows.Forms.ComboBox();
            this.cmboToConditional = new System.Windows.Forms.ComboBox();
            this.cmboCCConditional = new System.Windows.Forms.ComboBox();
            this.cmboBodyConditional = new System.Windows.Forms.ComboBox();
            this.cmboClassConditional = new System.Windows.Forms.ComboBox();
            this.cmboLogicalOperation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmboUidConditional = new System.Windows.Forms.ComboBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.chkUID = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Type:";
            // 
            // cmboSearchType
            // 
            this.cmboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSearchType.FormattingEnabled = true;
            this.cmboSearchType.Items.AddRange(new object[] {
            "Direct",
            "More Available"});
            this.cmboSearchType.Location = new System.Drawing.Point(124, 12);
            this.cmboSearchType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboSearchType.Name = "cmboSearchType";
            this.cmboSearchType.Size = new System.Drawing.Size(151, 24);
            this.cmboSearchType.TabIndex = 1;
            // 
            // txtAQS
            // 
            this.txtAQS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAQS.Enabled = false;
            this.txtAQS.Location = new System.Drawing.Point(36, 94);
            this.txtAQS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAQS.Multiline = true;
            this.txtAQS.Name = "txtAQS";
            this.txtAQS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAQS.Size = new System.Drawing.Size(785, 57);
            this.txtAQS.TabIndex = 8;
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Enabled = false;
            this.txtBody.Location = new System.Drawing.Point(122, 318);
            this.txtBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(500, 22);
            this.txtBody.TabIndex = 20;
            // 
            // chkBody
            // 
            this.chkBody.AutoSize = true;
            this.chkBody.Enabled = false;
            this.chkBody.Location = new System.Drawing.Point(36, 319);
            this.chkBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBody.Name = "chkBody";
            this.chkBody.Size = new System.Drawing.Size(62, 21);
            this.chkBody.TabIndex = 19;
            this.chkBody.Text = "Body";
            this.chkBody.UseVisualStyleBackColor = true;
            this.chkBody.CheckedChanged += new System.EventHandler(this.chkBody_CheckedChanged);
            // 
            // txtCC
            // 
            this.txtCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCC.Enabled = false;
            this.txtCC.Location = new System.Drawing.Point(122, 286);
            this.txtCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(500, 22);
            this.txtCC.TabIndex = 17;
            // 
            // chkCC
            // 
            this.chkCC.AutoSize = true;
            this.chkCC.Enabled = false;
            this.chkCC.Location = new System.Drawing.Point(37, 287);
            this.chkCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCC.Name = "chkCC";
            this.chkCC.Size = new System.Drawing.Size(48, 21);
            this.chkCC.TabIndex = 16;
            this.chkCC.Text = "CC";
            this.chkCC.UseVisualStyleBackColor = true;
            this.chkCC.CheckedChanged += new System.EventHandler(this.chkCC_CheckedChanged);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(122, 256);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(500, 22);
            this.txtTo.TabIndex = 14;
            // 
            // chkTo
            // 
            this.chkTo.AutoSize = true;
            this.chkTo.Enabled = false;
            this.chkTo.Location = new System.Drawing.Point(37, 257);
            this.chkTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTo.Name = "chkTo";
            this.chkTo.Size = new System.Drawing.Size(47, 21);
            this.chkTo.TabIndex = 13;
            this.chkTo.Text = "To";
            this.chkTo.UseVisualStyleBackColor = true;
            this.chkTo.CheckedChanged += new System.EventHandler(this.chkTo_CheckedChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Enabled = false;
            this.txtSubject.Location = new System.Drawing.Point(122, 224);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(500, 22);
            this.txtSubject.TabIndex = 11;
            // 
            // chkSubject
            // 
            this.chkSubject.AutoSize = true;
            this.chkSubject.Enabled = false;
            this.chkSubject.Location = new System.Drawing.Point(37, 222);
            this.chkSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSubject.Name = "chkSubject";
            this.chkSubject.Size = new System.Drawing.Size(77, 21);
            this.chkSubject.TabIndex = 10;
            this.chkSubject.Text = "Subject";
            this.chkSubject.UseVisualStyleBackColor = true;
            this.chkSubject.CheckedChanged += new System.EventHandler(this.chkSubject_CheckedChanged);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.Location = new System.Drawing.Point(37, 451);
            this.lvItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(787, 90);
            this.lvItems.TabIndex = 26;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            this.lvItems.DoubleClick += new System.EventHandler(this.lvItems_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 414);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 29);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoAqsSearch
            // 
            this.rdoAqsSearch.AutoSize = true;
            this.rdoAqsSearch.Checked = true;
            this.rdoAqsSearch.Location = new System.Drawing.Point(11, 67);
            this.rdoAqsSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoAqsSearch.Name = "rdoAqsSearch";
            this.rdoAqsSearch.Size = new System.Drawing.Size(107, 21);
            this.rdoAqsSearch.TabIndex = 7;
            this.rdoAqsSearch.TabStop = true;
            this.rdoAqsSearch.Text = "AQS Search";
            this.rdoAqsSearch.UseVisualStyleBackColor = true;
            this.rdoAqsSearch.CheckedChanged += new System.EventHandler(this.rdoAqsSearch_CheckedChanged);
            // 
            // rdoFindItemSearch
            // 
            this.rdoFindItemSearch.AutoSize = true;
            this.rdoFindItemSearch.Location = new System.Drawing.Point(12, 159);
            this.rdoFindItemSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFindItemSearch.Name = "rdoFindItemSearch";
            this.rdoFindItemSearch.Size = new System.Drawing.Size(135, 21);
            this.rdoFindItemSearch.TabIndex = 9;
            this.rdoFindItemSearch.Text = "Find Item Search";
            this.rdoFindItemSearch.UseVisualStyleBackColor = true;
            this.rdoFindItemSearch.CheckedChanged += new System.EventHandler(this.rdoFindItemSearch_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Page Size:";
            // 
            // numPageSize
            // 
            this.numPageSize.Location = new System.Drawing.Point(380, 10);
            this.numPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPageSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPageSize.Name = "numPageSize";
            this.numPageSize.Size = new System.Drawing.Size(150, 22);
            this.numPageSize.TabIndex = 3;
            this.numPageSize.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note:  Exchange Online may limit AQS results to 250 items due to default policy s" +
    "ettings.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Note:  Double click a result for more properties and options.";
            // 
            // txtClass
            // 
            this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(124, 350);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(500, 22);
            this.txtClass.TabIndex = 23;
            // 
            // chkClass
            // 
            this.chkClass.AutoSize = true;
            this.chkClass.Enabled = false;
            this.chkClass.Location = new System.Drawing.Point(36, 351);
            this.chkClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkClass.Name = "chkClass";
            this.chkClass.Size = new System.Drawing.Size(64, 21);
            this.chkClass.TabIndex = 22;
            this.chkClass.Text = "Class";
            this.chkClass.UseVisualStyleBackColor = true;
            this.chkClass.CheckedChanged += new System.EventHandler(this.chkClass_CheckedChanged);
            // 
            // cmboSearchDepth
            // 
            this.cmboSearchDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSearchDepth.FormattingEnabled = true;
            this.cmboSearchDepth.Items.AddRange(new object[] {
            "Shallow",
            "ItemTraversal",
            "SoftDeleted"});
            this.cmboSearchDepth.Location = new System.Drawing.Point(639, 12);
            this.cmboSearchDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboSearchDepth.Name = "cmboSearchDepth";
            this.cmboSearchDepth.Size = new System.Drawing.Size(126, 24);
            this.cmboSearchDepth.TabIndex = 5;
            this.cmboSearchDepth.SelectedIndexChanged += new System.EventHandler(this.cmboSearchDepth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depth:";
            // 
            // cmboSubjectConditional
            // 
            this.cmboSubjectConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboSubjectConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSubjectConditional.FormattingEnabled = true;
            this.cmboSubjectConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboSubjectConditional.Location = new System.Drawing.Point(639, 222);
            this.cmboSubjectConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboSubjectConditional.Name = "cmboSubjectConditional";
            this.cmboSubjectConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboSubjectConditional.TabIndex = 12;
            // 
            // cmboToConditional
            // 
            this.cmboToConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboToConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboToConditional.FormattingEnabled = true;
            this.cmboToConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboToConditional.Location = new System.Drawing.Point(639, 254);
            this.cmboToConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboToConditional.Name = "cmboToConditional";
            this.cmboToConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboToConditional.TabIndex = 15;
            // 
            // cmboCCConditional
            // 
            this.cmboCCConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboCCConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCCConditional.FormattingEnabled = true;
            this.cmboCCConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboCCConditional.Location = new System.Drawing.Point(639, 284);
            this.cmboCCConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboCCConditional.Name = "cmboCCConditional";
            this.cmboCCConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboCCConditional.TabIndex = 18;
            // 
            // cmboBodyConditional
            // 
            this.cmboBodyConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBodyConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBodyConditional.FormattingEnabled = true;
            this.cmboBodyConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboBodyConditional.Location = new System.Drawing.Point(639, 316);
            this.cmboBodyConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboBodyConditional.Name = "cmboBodyConditional";
            this.cmboBodyConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboBodyConditional.TabIndex = 21;
            // 
            // cmboClassConditional
            // 
            this.cmboClassConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboClassConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboClassConditional.FormattingEnabled = true;
            this.cmboClassConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboClassConditional.Location = new System.Drawing.Point(639, 348);
            this.cmboClassConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboClassConditional.Name = "cmboClassConditional";
            this.cmboClassConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboClassConditional.TabIndex = 24;
            // 
            // cmboLogicalOperation
            // 
            this.cmboLogicalOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLogicalOperation.FormattingEnabled = true;
            this.cmboLogicalOperation.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.cmboLogicalOperation.Location = new System.Drawing.Point(163, 382);
            this.cmboLogicalOperation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboLogicalOperation.Name = "cmboLogicalOperation";
            this.cmboLogicalOperation.Size = new System.Drawing.Size(126, 24);
            this.cmboLogicalOperation.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Logical Operation:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmboUidConditional
            // 
            this.cmboUidConditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboUidConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboUidConditional.FormattingEnabled = true;
            this.cmboUidConditional.Items.AddRange(new object[] {
            "ContainsSubstring",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsNotEqualTo"});
            this.cmboUidConditional.Location = new System.Drawing.Point(639, 190);
            this.cmboUidConditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboUidConditional.Name = "cmboUidConditional";
            this.cmboUidConditional.Size = new System.Drawing.Size(185, 24);
            this.cmboUidConditional.TabIndex = 36;
            // 
            // txtUID
            // 
            this.txtUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUID.Enabled = false;
            this.txtUID.Location = new System.Drawing.Point(122, 194);
            this.txtUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(500, 22);
            this.txtUID.TabIndex = 35;
            // 
            // chkUID
            // 
            this.chkUID.AutoSize = true;
            this.chkUID.Location = new System.Drawing.Point(37, 192);
            this.chkUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUID.Name = "chkUID";
            this.chkUID.Size = new System.Drawing.Size(53, 21);
            this.chkUID.TabIndex = 34;
            this.chkUID.Text = "UID";
            this.chkUID.UseVisualStyleBackColor = true;
            this.chkUID.CheckedChanged += new System.EventHandler(this.chkUID_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(838, 562);
            this.Controls.Add(this.cmboUidConditional);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.chkUID);
            this.Controls.Add(this.cmboLogicalOperation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmboClassConditional);
            this.Controls.Add(this.cmboBodyConditional);
            this.Controls.Add(this.cmboCCConditional);
            this.Controls.Add(this.cmboToConditional);
            this.Controls.Add(this.cmboSubjectConditional);
            this.Controls.Add(this.cmboSearchDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.chkClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoFindItemSearch);
            this.Controls.Add(this.rdoAqsSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboSearchType);
            this.Controls.Add(this.txtAQS);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.chkBody);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.chkCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.chkTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.chkSubject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchForm";
            this.Text = "Search Items Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmboSearchType;
        public System.Windows.Forms.TextBox txtAQS;
        public System.Windows.Forms.TextBox txtBody;
        public System.Windows.Forms.CheckBox chkBody;
        public System.Windows.Forms.TextBox txtCC;
        public System.Windows.Forms.CheckBox chkCC;
        public System.Windows.Forms.TextBox txtTo;
        public System.Windows.Forms.CheckBox chkTo;
        public System.Windows.Forms.TextBox txtSubject;
        public System.Windows.Forms.CheckBox chkSubject;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoAqsSearch;
        private System.Windows.Forms.RadioButton rdoFindItemSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPageSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtClass;
        public System.Windows.Forms.CheckBox chkClass;
        public System.Windows.Forms.ComboBox cmboSearchDepth;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmboSubjectConditional;
        public System.Windows.Forms.ComboBox cmboToConditional;
        public System.Windows.Forms.ComboBox cmboCCConditional;
        public System.Windows.Forms.ComboBox cmboBodyConditional;
        public System.Windows.Forms.ComboBox cmboClassConditional;
        public System.Windows.Forms.ComboBox cmboLogicalOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ComboBox cmboUidConditional;
        public System.Windows.Forms.TextBox txtUID;
        public System.Windows.Forms.CheckBox chkUID;
    }
}