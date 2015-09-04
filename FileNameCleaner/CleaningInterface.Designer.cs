namespace FileNameCleaner
{
    partial class CleaningInterface
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_directory = new System.Windows.Forms.Label();
            this.m_withText = new System.Windows.Forms.TextBox();
            this.m_replaceText = new System.Windows.Forms.TextBox();
            this.m_with = new System.Windows.Forms.Label();
            this.m_replace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_maskText = new System.Windows.Forms.TextBox();
            this.m_standard = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_removeUrls = new System.Windows.Forms.CheckBox();
            this.m_doPrepend = new System.Windows.Forms.CheckBox();
            this.m_doAppend = new System.Windows.Forms.CheckBox();
            this.m_doReplace = new System.Windows.Forms.CheckBox();
            this.m_dashToSpaceDashSpace = new System.Windows.Forms.CheckBox();
            this.m_underscoreToSpace = new System.Windows.Forms.CheckBox();
            this.m_doubleSpace = new System.Windows.Forms.CheckBox();
            this.m_camelCase = new System.Windows.Forms.CheckBox();
            this.m_lowerCaseExtention = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.m_directoryText = new System.Windows.Forms.TextBox();
            this.m_directoryChooser = new System.Windows.Forms.Button();
            this.m_next = new System.Windows.Forms.Button();
            this.m_prepend = new System.Windows.Forms.Label();
            this.m_output = new System.Windows.Forms.Label();
            this.m_outputText = new System.Windows.Forms.RichTextBox();
            this.m_append = new System.Windows.Forms.Label();
            this.m_prependText = new System.Windows.Forms.TextBox();
            this.m_appendText = new System.Windows.Forms.TextBox();
            this.m_vertSplitter = new System.Windows.Forms.Splitter();
            this.m_go = new System.Windows.Forms.Button();
            this.m_browser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.m_directory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_withText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_replaceText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_with, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_replace, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_maskText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_standard, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_prepend, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.m_output, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.m_outputText, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.m_append, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.m_prependText, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.m_appendText, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(400, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 589);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // m_directory
            // 
            this.m_directory.AutoSize = true;
            this.m_directory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_directory.Location = new System.Drawing.Point(3, 0);
            this.m_directory.Name = "m_directory";
            this.m_directory.Size = new System.Drawing.Size(69, 30);
            this.m_directory.TabIndex = 0;
            this.m_directory.Text = "Directory";
            // 
            // m_withText
            // 
            this.m_withText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_withText.Enabled = false;
            this.m_withText.Location = new System.Drawing.Point(78, 83);
            this.m_withText.Name = "m_withText";
            this.m_withText.Size = new System.Drawing.Size(380, 20);
            this.m_withText.TabIndex = 5;
            // 
            // m_replaceText
            // 
            this.m_replaceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_replaceText.Enabled = false;
            this.m_replaceText.Location = new System.Drawing.Point(78, 58);
            this.m_replaceText.Name = "m_replaceText";
            this.m_replaceText.Size = new System.Drawing.Size(380, 20);
            this.m_replaceText.TabIndex = 4;
            // 
            // m_with
            // 
            this.m_with.AutoSize = true;
            this.m_with.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_with.Location = new System.Drawing.Point(3, 80);
            this.m_with.Name = "m_with";
            this.m_with.Size = new System.Drawing.Size(69, 25);
            this.m_with.TabIndex = 2;
            this.m_with.Text = "With";
            // 
            // m_replace
            // 
            this.m_replace.AutoSize = true;
            this.m_replace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_replace.Location = new System.Drawing.Point(3, 55);
            this.m_replace.Name = "m_replace";
            this.m_replace.Size = new System.Drawing.Size(69, 25);
            this.m_replace.TabIndex = 1;
            this.m_replace.Text = "Replace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mask";
            // 
            // m_maskText
            // 
            this.m_maskText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_maskText.Location = new System.Drawing.Point(78, 33);
            this.m_maskText.Name = "m_maskText";
            this.m_maskText.Size = new System.Drawing.Size(380, 20);
            this.m_maskText.TabIndex = 10;
            this.m_maskText.Text = "*.*";
            // 
            // m_standard
            // 
            this.m_standard.AutoSize = true;
            this.m_standard.Location = new System.Drawing.Point(3, 105);
            this.m_standard.Name = "m_standard";
            this.m_standard.Size = new System.Drawing.Size(42, 13);
            this.m_standard.TabIndex = 11;
            this.m_standard.Text = "Actions";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.m_removeUrls);
            this.flowLayoutPanel1.Controls.Add(this.m_doPrepend);
            this.flowLayoutPanel1.Controls.Add(this.m_doAppend);
            this.flowLayoutPanel1.Controls.Add(this.m_doReplace);
            this.flowLayoutPanel1.Controls.Add(this.m_dashToSpaceDashSpace);
            this.flowLayoutPanel1.Controls.Add(this.m_underscoreToSpace);
            this.flowLayoutPanel1.Controls.Add(this.m_doubleSpace);
            this.flowLayoutPanel1.Controls.Add(this.m_camelCase);
            this.flowLayoutPanel1.Controls.Add(this.m_lowerCaseExtention);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 50);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // m_removeUrls
            // 
            this.m_removeUrls.AutoSize = true;
            this.m_removeUrls.Checked = true;
            this.m_removeUrls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_removeUrls.Location = new System.Drawing.Point(3, 3);
            this.m_removeUrls.Name = "m_removeUrls";
            this.m_removeUrls.Size = new System.Drawing.Size(49, 17);
            this.m_removeUrls.TabIndex = 5;
            this.m_removeUrls.Text = "-Url\'s";
            this.m_removeUrls.UseVisualStyleBackColor = true;
            // 
            // m_doPrepend
            // 
            this.m_doPrepend.AutoSize = true;
            this.m_doPrepend.Location = new System.Drawing.Point(58, 3);
            this.m_doPrepend.Name = "m_doPrepend";
            this.m_doPrepend.Size = new System.Drawing.Size(66, 17);
            this.m_doPrepend.TabIndex = 6;
            this.m_doPrepend.Text = "Prepend";
            this.m_doPrepend.UseVisualStyleBackColor = true;
            this.m_doPrepend.CheckedChanged += new System.EventHandler(this.m_doPrepend_CheckedChanged);
            // 
            // m_doAppend
            // 
            this.m_doAppend.AutoSize = true;
            this.m_doAppend.Location = new System.Drawing.Point(130, 3);
            this.m_doAppend.Name = "m_doAppend";
            this.m_doAppend.Size = new System.Drawing.Size(63, 17);
            this.m_doAppend.TabIndex = 7;
            this.m_doAppend.Text = "Append";
            this.m_doAppend.UseVisualStyleBackColor = true;
            this.m_doAppend.CheckedChanged += new System.EventHandler(this.m_doAppend_CheckedChanged);
            // 
            // m_doReplace
            // 
            this.m_doReplace.AutoSize = true;
            this.m_doReplace.Location = new System.Drawing.Point(199, 3);
            this.m_doReplace.Name = "m_doReplace";
            this.m_doReplace.Size = new System.Drawing.Size(83, 17);
            this.m_doReplace.TabIndex = 2;
            this.m_doReplace.Text = "Do Replace";
            this.m_doReplace.UseVisualStyleBackColor = true;
            this.m_doReplace.CheckedChanged += new System.EventHandler(this.m_doReplace_CheckedChanged);
            // 
            // m_dashToSpaceDashSpace
            // 
            this.m_dashToSpaceDashSpace.AutoSize = true;
            this.m_dashToSpaceDashSpace.Checked = true;
            this.m_dashToSpaceDashSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_dashToSpaceDashSpace.Location = new System.Drawing.Point(288, 3);
            this.m_dashToSpaceDashSpace.Name = "m_dashToSpaceDashSpace";
            this.m_dashToSpaceDashSpace.Size = new System.Drawing.Size(61, 17);
            this.m_dashToSpaceDashSpace.TabIndex = 3;
            this.m_dashToSpaceDashSpace.Text = "\'-\' -> \' - \'";
            this.m_dashToSpaceDashSpace.UseVisualStyleBackColor = true;
            // 
            // m_underscoreToSpace
            // 
            this.m_underscoreToSpace.AutoSize = true;
            this.m_underscoreToSpace.Checked = true;
            this.m_underscoreToSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_underscoreToSpace.Location = new System.Drawing.Point(3, 26);
            this.m_underscoreToSpace.Name = "m_underscoreToSpace";
            this.m_underscoreToSpace.Size = new System.Drawing.Size(58, 17);
            this.m_underscoreToSpace.TabIndex = 1;
            this.m_underscoreToSpace.Text = "\'_\' -> \' \'";
            this.m_underscoreToSpace.UseVisualStyleBackColor = true;
            // 
            // m_doubleSpace
            // 
            this.m_doubleSpace.AutoSize = true;
            this.m_doubleSpace.Checked = true;
            this.m_doubleSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_doubleSpace.Location = new System.Drawing.Point(67, 26);
            this.m_doubleSpace.Name = "m_doubleSpace";
            this.m_doubleSpace.Size = new System.Drawing.Size(58, 17);
            this.m_doubleSpace.TabIndex = 4;
            this.m_doubleSpace.Text = "\'  \' -> \' \'";
            this.m_doubleSpace.UseVisualStyleBackColor = true;
            // 
            // m_camelCase
            // 
            this.m_camelCase.AutoSize = true;
            this.m_camelCase.Location = new System.Drawing.Point(131, 26);
            this.m_camelCase.Name = "m_camelCase";
            this.m_camelCase.Size = new System.Drawing.Size(79, 17);
            this.m_camelCase.TabIndex = 0;
            this.m_camelCase.Text = "CamelCase";
            this.m_camelCase.UseVisualStyleBackColor = true;
            // 
            // m_lowerCaseExtention
            // 
            this.m_lowerCaseExtention.AutoSize = true;
            this.m_lowerCaseExtention.Checked = true;
            this.m_lowerCaseExtention.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_lowerCaseExtention.Location = new System.Drawing.Point(216, 26);
            this.m_lowerCaseExtention.Name = "m_lowerCaseExtention";
            this.m_lowerCaseExtention.Size = new System.Drawing.Size(54, 17);
            this.m_lowerCaseExtention.TabIndex = 8;
            this.m_lowerCaseExtention.Text = ".lower";
            this.m_lowerCaseExtention.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.m_directoryText, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.m_directoryChooser, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.m_next, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(75, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(386, 30);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // m_directoryText
            // 
            this.m_directoryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_directoryText.Location = new System.Drawing.Point(3, 3);
            this.m_directoryText.Name = "m_directoryText";
            this.m_directoryText.ReadOnly = true;
            this.m_directoryText.Size = new System.Drawing.Size(280, 20);
            this.m_directoryText.TabIndex = 17;
            // 
            // m_directoryChooser
            // 
            this.m_directoryChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_directoryChooser.Location = new System.Drawing.Point(289, 3);
            this.m_directoryChooser.Name = "m_directoryChooser";
            this.m_directoryChooser.Size = new System.Drawing.Size(44, 24);
            this.m_directoryChooser.TabIndex = 17;
            this.m_directoryChooser.Text = "...";
            this.m_directoryChooser.UseVisualStyleBackColor = true;
            this.m_directoryChooser.Click += new System.EventHandler(this.m_directoryChooser_Click);
            // 
            // m_next
            // 
            this.m_next.Location = new System.Drawing.Point(339, 3);
            this.m_next.Name = "m_next";
            this.m_next.Size = new System.Drawing.Size(44, 23);
            this.m_next.TabIndex = 18;
            this.m_next.Text = ">>";
            this.m_next.UseVisualStyleBackColor = true;
            this.m_next.Click += new System.EventHandler(this.m_next_Click);
            // 
            // m_prepend
            // 
            this.m_prepend.AutoSize = true;
            this.m_prepend.Location = new System.Drawing.Point(3, 155);
            this.m_prepend.Name = "m_prepend";
            this.m_prepend.Size = new System.Drawing.Size(47, 13);
            this.m_prepend.TabIndex = 14;
            this.m_prepend.Text = "Prepend";
            // 
            // m_output
            // 
            this.m_output.AutoSize = true;
            this.m_output.Location = new System.Drawing.Point(3, 205);
            this.m_output.Name = "m_output";
            this.m_output.Size = new System.Drawing.Size(39, 13);
            this.m_output.TabIndex = 8;
            this.m_output.Text = "Output";
            // 
            // m_outputText
            // 
            this.m_outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_outputText.Location = new System.Drawing.Point(78, 208);
            this.m_outputText.Name = "m_outputText";
            this.m_outputText.Size = new System.Drawing.Size(380, 378);
            this.m_outputText.TabIndex = 7;
            this.m_outputText.Text = "";
            // 
            // m_append
            // 
            this.m_append.AutoSize = true;
            this.m_append.Location = new System.Drawing.Point(3, 180);
            this.m_append.Name = "m_append";
            this.m_append.Size = new System.Drawing.Size(44, 13);
            this.m_append.TabIndex = 15;
            this.m_append.Text = "Append";
            // 
            // m_prependText
            // 
            this.m_prependText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_prependText.Enabled = false;
            this.m_prependText.Location = new System.Drawing.Point(78, 158);
            this.m_prependText.Name = "m_prependText";
            this.m_prependText.Size = new System.Drawing.Size(380, 20);
            this.m_prependText.TabIndex = 16;
            // 
            // m_appendText
            // 
            this.m_appendText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_appendText.Enabled = false;
            this.m_appendText.Location = new System.Drawing.Point(78, 183);
            this.m_appendText.Name = "m_appendText";
            this.m_appendText.Size = new System.Drawing.Size(380, 20);
            this.m_appendText.TabIndex = 17;
            // 
            // m_vertSplitter
            // 
            this.m_vertSplitter.Location = new System.Drawing.Point(461, 0);
            this.m_vertSplitter.Name = "m_vertSplitter";
            this.m_vertSplitter.Size = new System.Drawing.Size(3, 589);
            this.m_vertSplitter.TabIndex = 15;
            this.m_vertSplitter.TabStop = false;
            // 
            // m_go
            // 
            this.m_go.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_go.Location = new System.Drawing.Point(464, 557);
            this.m_go.Name = "m_go";
            this.m_go.Size = new System.Drawing.Size(529, 32);
            this.m_go.TabIndex = 16;
            this.m_go.Text = "Go";
            this.m_go.UseVisualStyleBackColor = true;
            this.m_go.Click += new System.EventHandler(this.m_go_Click);
            // 
            // m_browser
            // 
            this.m_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_browser.Location = new System.Drawing.Point(464, 0);
            this.m_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_browser.Name = "m_browser";
            this.m_browser.Size = new System.Drawing.Size(529, 557);
            this.m_browser.TabIndex = 17;
            // 
            // CleaningInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 589);
            this.Controls.Add(this.m_browser);
            this.Controls.Add(this.m_go);
            this.Controls.Add(this.m_vertSplitter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CleaningInterface";
            this.Text = "Replace File Names";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label m_directory;
        private System.Windows.Forms.Label m_replace;
        private System.Windows.Forms.Label m_with;
        private System.Windows.Forms.TextBox m_replaceText;
        private System.Windows.Forms.TextBox m_withText;
        private System.Windows.Forms.Label m_output;
        private System.Windows.Forms.RichTextBox m_outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_maskText;
        private System.Windows.Forms.Label m_standard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox m_camelCase;
        private System.Windows.Forms.CheckBox m_underscoreToSpace;
        private System.Windows.Forms.CheckBox m_doReplace;
        private System.Windows.Forms.CheckBox m_dashToSpaceDashSpace;
        private System.Windows.Forms.CheckBox m_doubleSpace;
        private System.Windows.Forms.Splitter m_vertSplitter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox m_directoryText;
        private System.Windows.Forms.Button m_directoryChooser;
        private System.Windows.Forms.Button m_go;
        private System.Windows.Forms.WebBrowser m_browser;
        private System.Windows.Forms.Button m_next;
        private System.Windows.Forms.Label m_prepend;
        private System.Windows.Forms.Label m_append;
        private System.Windows.Forms.CheckBox m_removeUrls;
        private System.Windows.Forms.TextBox m_prependText;
        private System.Windows.Forms.TextBox m_appendText;
        private System.Windows.Forms.CheckBox m_doPrepend;
        private System.Windows.Forms.CheckBox m_doAppend;
        private System.Windows.Forms.CheckBox m_lowerCaseExtention;

    }
}

