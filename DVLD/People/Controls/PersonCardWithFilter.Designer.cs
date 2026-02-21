namespace DVLD.People.Controls
{
    partial class PersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.Filter = new System.Windows.Forms.TextBox();
            this.FilterCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonCard = new DVLD.People.Controls.PersonCard();
            this.Search = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.FilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.SystemColors.Control;
            this.FilterBox.Controls.Add(this.Search);
            this.FilterBox.Controls.Add(this.AddPerson);
            this.FilterBox.Controls.Add(this.Filter);
            this.FilterBox.Controls.Add(this.FilterCategories);
            this.FilterBox.Controls.Add(this.label2);
            this.FilterBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.FilterBox.Location = new System.Drawing.Point(22, 12);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(875, 86);
            this.FilterBox.TabIndex = 0;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Filter:";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(443, 32);
            this.Filter.Multiline = true;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(173, 29);
            this.Filter.TabIndex = 1;
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // FilterCategories
            // 
            this.FilterCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCategories.FormattingEnabled = true;
            this.FilterCategories.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.FilterCategories.Location = new System.Drawing.Point(251, 32);
            this.FilterCategories.Name = "FilterCategories";
            this.FilterCategories.Size = new System.Drawing.Size(177, 29);
            this.FilterCategories.TabIndex = 0;
            this.FilterCategories.SelectedIndexChanged += new System.EventHandler(this.FilterCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(126, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter By:";
            // 
            // PersonCard
            // 
            this.PersonCard.Location = new System.Drawing.Point(3, 104);
            this.PersonCard.Name = "PersonCard";
            this.PersonCard.Size = new System.Drawing.Size(911, 487);
            this.PersonCard.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.Search.Location = new System.Drawing.Point(637, 19);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 50);
            this.Search.TabIndex = 2;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPerson.Image = global::DVLD.Properties.Resources.AddPerson;
            this.AddPerson.Location = new System.Drawing.Point(693, 19);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(50, 50);
            this.AddPerson.TabIndex = 3;
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.PersonCard);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(914, 591);
            this.Load += new System.EventHandler(this.PersonCardWithFilter_Load);
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD.People.Controls.PersonCard PersonCard;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.ComboBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button Search;
    }
}
