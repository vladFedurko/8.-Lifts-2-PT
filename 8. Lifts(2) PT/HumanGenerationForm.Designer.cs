namespace _8.Lifts_2__PT
{
    partial class HumanGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanGenerationForm));
            this.humanGenerationTable = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.num_of_humansLabel = new System.Windows.Forms.Label();
            this.finite_floorLabel = new System.Windows.Forms.Label();
            this.initial_floorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.humanGenerationTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // humanGenerationTable
            // 
            this.humanGenerationTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.humanGenerationTable.AutoScroll = true;
            this.humanGenerationTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.humanGenerationTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.humanGenerationTable.ColumnCount = 4;
            this.humanGenerationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.humanGenerationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.humanGenerationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.humanGenerationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.humanGenerationTable.Controls.Add(this.timeLabel, 3, 0);
            this.humanGenerationTable.Controls.Add(this.num_of_humansLabel, 0, 0);
            this.humanGenerationTable.Controls.Add(this.finite_floorLabel, 2, 0);
            this.humanGenerationTable.Controls.Add(this.initial_floorLabel, 1, 0);
            this.humanGenerationTable.Location = new System.Drawing.Point(9, 10);
            this.humanGenerationTable.Margin = new System.Windows.Forms.Padding(2);
            this.humanGenerationTable.Name = "humanGenerationTable";
            this.humanGenerationTable.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.humanGenerationTable.RowCount = 2;
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.humanGenerationTable.Size = new System.Drawing.Size(821, 145);
            this.humanGenerationTable.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(612, 1);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(198, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "In (seconds)";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_humansLabel
            // 
            this.num_of_humansLabel.AutoSize = true;
            this.num_of_humansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_of_humansLabel.Location = new System.Drawing.Point(3, 1);
            this.num_of_humansLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num_of_humansLabel.Name = "num_of_humansLabel";
            this.num_of_humansLabel.Size = new System.Drawing.Size(198, 20);
            this.num_of_humansLabel.TabIndex = 1;
            this.num_of_humansLabel.Text = "Number of generated people";
            this.num_of_humansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finite_floorLabel
            // 
            this.finite_floorLabel.AutoSize = true;
            this.finite_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finite_floorLabel.Location = new System.Drawing.Point(409, 1);
            this.finite_floorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finite_floorLabel.Name = "finite_floorLabel";
            this.finite_floorLabel.Size = new System.Drawing.Size(198, 20);
            this.finite_floorLabel.TabIndex = 3;
            this.finite_floorLabel.Text = "Finite floor";
            this.finite_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initial_floorLabel
            // 
            this.initial_floorLabel.AutoSize = true;
            this.initial_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initial_floorLabel.Location = new System.Drawing.Point(206, 1);
            this.initial_floorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initial_floorLabel.Name = "initial_floorLabel";
            this.initial_floorLabel.Size = new System.Drawing.Size(198, 20);
            this.initial_floorLabel.TabIndex = 2;
            this.initial_floorLabel.Text = "Initial floor";
            this.initial_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.Location = new System.Drawing.Point(255, 161);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add rule...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Location = new System.Drawing.Point(461, 161);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(560, 161);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(353, 161);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete rule...";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HumanGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 189);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.humanGenerationTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HumanGenerationForm";
            this.Text = "HumanGenerationForm";
            this.Deactivate += new System.EventHandler(this.HumanGenerationForm_Deactivate);
            this.Load += new System.EventHandler(this.HumanGenerationForm_Load);
            this.humanGenerationTable.ResumeLayout(false);
            this.humanGenerationTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel humanGenerationTable;
        private System.Windows.Forms.Label num_of_humansLabel;
        private System.Windows.Forms.Label initial_floorLabel;
        private System.Windows.Forms.Label finite_floorLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
    }
}