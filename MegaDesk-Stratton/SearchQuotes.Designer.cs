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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchQuotesClose = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchMaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesClose
            // 
            this.searchQuotesClose.Location = new System.Drawing.Point(1361, 762);
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
            this.searchLbl.Location = new System.Drawing.Point(456, 75);
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
            this.searchMaterialsComboBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMaterialsComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchMaterialsComboBox.FormattingEnabled = true;
            this.searchMaterialsComboBox.Location = new System.Drawing.Point(904, 73);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.searchGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.searchGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.GridColor = System.Drawing.SystemColors.Control;
            this.searchGrid.Location = new System.Drawing.Point(80, 204);
            this.searchGrid.Margin = new System.Windows.Forms.Padding(6);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.RowHeadersWidth = 82;
            this.searchGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.searchGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.searchGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.RowTemplate.DefaultCellStyle.Format = "d";
            this.searchGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.searchGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.searchGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.Size = new System.Drawing.Size(1431, 527);
            this.searchGrid.TabIndex = 3;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 912);
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