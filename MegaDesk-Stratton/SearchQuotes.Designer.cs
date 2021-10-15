
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
            this.searchQuotesClose = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchMaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesClose
            // 
            this.searchQuotesClose.Location = new System.Drawing.Point(793, 476);
            this.searchQuotesClose.Margin = new System.Windows.Forms.Padding(4);
            this.searchQuotesClose.Name = "searchQuotesClose";
            this.searchQuotesClose.Size = new System.Drawing.Size(100, 28);
            this.searchQuotesClose.TabIndex = 0;
            this.searchQuotesClose.Text = "Close";
            this.searchQuotesClose.UseVisualStyleBackColor = true;
            this.searchQuotesClose.Click += new System.EventHandler(this.searchQuotesClose_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchLbl.Location = new System.Drawing.Point(304, 48);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(146, 21);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search By Material: ";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchMaterialsComboBox
            // 
            this.searchMaterialsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMaterialsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMaterialsComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchMaterialsComboBox.FormattingEnabled = true;
            this.searchMaterialsComboBox.Location = new System.Drawing.Point(603, 46);
            this.searchMaterialsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchMaterialsComboBox.Name = "searchMaterialsComboBox";
            this.searchMaterialsComboBox.Size = new System.Drawing.Size(160, 28);
            this.searchMaterialsComboBox.TabIndex = 1;
            this.searchMaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.searchMaterialsComboBox_SelectedIndexChanged);
            // 
            // searchGrid
            // 
            this.searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(173, 119);
            this.searchGrid.Margin = new System.Windows.Forms.Padding(4);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.Size = new System.Drawing.Size(720, 315);
            this.searchGrid.TabIndex = 2;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.searchMaterialsComboBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchQuotesClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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