
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
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(54, 38);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(150, 25);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search By Material: ";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchMaterialsComboBox
            // 
            this.searchMaterialsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMaterialsComboBox.FormattingEnabled = true;
            this.searchMaterialsComboBox.Location = new System.Drawing.Point(210, 38);
            this.searchMaterialsComboBox.Name = "searchMaterialsComboBox";
            this.searchMaterialsComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchMaterialsComboBox.TabIndex = 2;
            this.searchMaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.searchMaterialsComboBox_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Stratton.Properties.Resources.woodgrain_texture_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchMaterialsComboBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchQuotesClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchQuotesClose;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ComboBox searchMaterialsComboBox;
    }
}