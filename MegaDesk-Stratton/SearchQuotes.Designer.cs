﻿
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
            this.searchQuotesClose = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchMaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesClose
            // 
            this.searchQuotesClose.Location = new System.Drawing.Point(713, 415);
            this.searchQuotesClose.Name = "searchQuotesClose";
            this.searchQuotesClose.Size = new System.Drawing.Size(75, 23);
            this.searchQuotesClose.TabIndex = 0;
            this.searchQuotesClose.Text = "Close";
            this.searchQuotesClose.UseVisualStyleBackColor = true;
            this.searchQuotesClose.Click += new System.EventHandler(this.searchQuotesClose_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(228, 39);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(194, 23);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search By Material: ";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchMaterialsComboBox
            // 
            this.searchMaterialsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMaterialsComboBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMaterialsComboBox.FormattingEnabled = true;
            this.searchMaterialsComboBox.Location = new System.Drawing.Point(452, 38);
            this.searchMaterialsComboBox.Name = "searchMaterialsComboBox";
            this.searchMaterialsComboBox.Size = new System.Drawing.Size(121, 28);
            this.searchMaterialsComboBox.TabIndex = 1;
            this.searchMaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.searchMaterialsComboBox_SelectedIndexChanged);
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(12, 106);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.searchGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.searchGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrid.RowTemplate.DefaultCellStyle.Format = "d";
            this.searchGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.searchGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.searchGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.Size = new System.Drawing.Size(776, 274);
            this.searchGrid.TabIndex = 3;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Stratton.Properties.Resources.woodgrain_texture_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.searchMaterialsComboBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchQuotesClose);
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