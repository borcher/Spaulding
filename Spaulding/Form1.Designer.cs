
namespace Spaulding
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgrSalesPerState = new System.Windows.Forms.DataGridView();
            this.dgrSales = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgrSalesIncr = new System.Windows.Forms.DataGridView();
            this.dgrSalesPerStateIncr = new System.Windows.Forms.DataGridView();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesPerState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSales)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesIncr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesPerStateIncr)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 537);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalSales);
            this.tabPage1.Controls.Add(this.dgrSalesPerState);
            this.tabPage1.Controls.Add(this.dgrSales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Location = new System.Drawing.Point(7, 483);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(537, 23);
            this.lblTotalSales.TabIndex = 3;
            // 
            // dgrSalesPerState
            // 
            this.dgrSalesPerState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSalesPerState.Location = new System.Drawing.Point(6, 216);
            this.dgrSalesPerState.Name = "dgrSalesPerState";
            this.dgrSalesPerState.Size = new System.Drawing.Size(394, 260);
            this.dgrSalesPerState.TabIndex = 2;
            // 
            // dgrSales
            // 
            this.dgrSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSales.Location = new System.Drawing.Point(6, 33);
            this.dgrSales.Name = "dgrSales";
            this.dgrSales.Size = new System.Drawing.Size(394, 177);
            this.dgrSales.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtPercentage);
            this.tabPage2.Controls.Add(this.dgrSalesPerStateIncr);
            this.tabPage2.Controls.Add(this.dgrSalesIncr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgrSalesIncr
            // 
            this.dgrSalesIncr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSalesIncr.Location = new System.Drawing.Point(3, 71);
            this.dgrSalesIncr.Name = "dgrSalesIncr";
            this.dgrSalesIncr.Size = new System.Drawing.Size(539, 204);
            this.dgrSalesIncr.TabIndex = 0;
            // 
            // dgrSalesPerStateIncr
            // 
            this.dgrSalesPerStateIncr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSalesPerStateIncr.Location = new System.Drawing.Point(3, 281);
            this.dgrSalesPerStateIncr.Name = "dgrSalesPerStateIncr";
            this.dgrSalesPerStateIncr.Size = new System.Drawing.Size(538, 224);
            this.dgrSalesPerStateIncr.TabIndex = 1;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(7, 19);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 2;
            this.txtPercentage.Text = "0";
            this.txtPercentage.TextChanged += new System.EventHandler(this.txtPercentage_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesPerState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSales)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesIncr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSalesPerStateIncr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgrSales;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dgrSalesPerState;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgrSalesPerStateIncr;
        private System.Windows.Forms.DataGridView dgrSalesIncr;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

