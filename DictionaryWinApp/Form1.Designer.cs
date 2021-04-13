namespace DictionaryWinApp
{
    partial class frmDictionary
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstKeysAndValues = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstValues = new System.Windows.Forms.ListBox();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(529, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Keys && Values";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstKeysAndValues
            // 
            this.lstKeysAndValues.FormattingEnabled = true;
            this.lstKeysAndValues.ItemHeight = 16;
            this.lstKeysAndValues.Location = new System.Drawing.Point(529, 78);
            this.lstKeysAndValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKeysAndValues.Name = "lstKeysAndValues";
            this.lstKeysAndValues.Size = new System.Drawing.Size(245, 324);
            this.lstKeysAndValues.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(277, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Values";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Keys";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.ItemHeight = 16;
            this.lstValues.Location = new System.Drawing.Point(277, 78);
            this.lstValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(243, 324);
            this.lstValues.TabIndex = 7;
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 16;
            this.lstKeys.Location = new System.Drawing.Point(27, 78);
            this.lstKeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(243, 324);
            this.lstKeys.TabIndex = 5;
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKeysAndValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstValues);
            this.Controls.Add(this.lstKeys);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDictionary";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.frmDictionary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstKeysAndValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstValues;
        private System.Windows.Forms.ListBox lstKeys;
    }
}

