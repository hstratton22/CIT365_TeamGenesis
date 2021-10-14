
namespace MegaDesk_Stratton
{
    partial class SearchQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchQuotesClose = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchMaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesClose
            // 
            this.searchQuotesClose.Location = new System.Drawing.Point(1230, 787);
            this.searchQuotesClose.Margin = new System.Windows.Forms.Padding(6);
            this.searchQuotesClose.Name = "searchQuotesClose";
            this.searchQuotesClose.Size = new System.Drawing.Size(150, 44);
            this.searchQuotesClose.TabIndex = 0;
            this.searchQuotesClose.Text = "Close";
            this.searchQuotesClose.UseVisualStyleBackColor = true;
            this.searchQuotesClose.Click += new System.EventHandler(this.searchQuotesClose_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchLbl.Location = new System.Drawing.Point(205, 65);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(267, 40);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search By Material: ";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchMaterialsComboBox
            // 
            this.searchMaterialsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMaterialsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchMaterialsComboBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMaterialsComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchMaterialsComboBox.FormattingEnabled = true;
            this.searchMaterialsComboBox.Location = new System.Drawing.Point(756, 65);
            this.searchMaterialsComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchMaterialsComboBox.Name = "searchMaterialsComboBox";
            this.searchMaterialsComboBox.Size = new System.Drawing.Size(238, 48);
            this.searchMaterialsComboBox.TabIndex = 1;
            this.searchMaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.searchMaterialsComboBox_SelectedIndexChanged);
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.searchGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.searchGrid.Location = new System.Drawing.Point(50, 156);
            this.searchGrid.Margin = new System.Windows.Forms.Padding(6);
            this.searchGrid.Name = "searchGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.RowHeadersWidth = 100;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(12);
            this.searchGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.searchGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.searchGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.searchGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.RowTemplate.DefaultCellStyle.Format = "d";
            this.searchGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.searchGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.searchGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.Size = new System.Drawing.Size(1330, 598);
            this.searchGrid.TabIndex = 3;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 884);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.searchMaterialsComboBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchQuotesClose);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchQuotesClose;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ComboBox searchMaterialsComboBox;
        private System.Windows.Forms.DataGridView searchGrid;
    }
}