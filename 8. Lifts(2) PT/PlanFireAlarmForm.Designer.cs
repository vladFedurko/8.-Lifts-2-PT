namespace _8.Lifts_2__PT
{
    partial class PlanFireAlarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanFireAlarmForm));
            this.planFireAlarmTable = new System.Windows.Forms.TableLayoutPanel();
            this.finiteFloorLabel = new System.Windows.Forms.Label();
            this.initialFlootLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.planFireAlarmTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // planFireAlarmTable
            // 
            this.planFireAlarmTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planFireAlarmTable.AutoScroll = true;
            this.planFireAlarmTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.planFireAlarmTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.planFireAlarmTable.ColumnCount = 2;
            this.planFireAlarmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.planFireAlarmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.planFireAlarmTable.Controls.Add(this.finiteFloorLabel, 1, 0);
            this.planFireAlarmTable.Controls.Add(this.initialFlootLabel, 0, 0);
            this.planFireAlarmTable.Location = new System.Drawing.Point(11, 11);
            this.planFireAlarmTable.Margin = new System.Windows.Forms.Padding(2);
            this.planFireAlarmTable.Name = "planFireAlarmTable";
            this.planFireAlarmTable.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.planFireAlarmTable.RowCount = 2;
            this.planFireAlarmTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.planFireAlarmTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.planFireAlarmTable.Size = new System.Drawing.Size(457, 325);
            this.planFireAlarmTable.TabIndex = 0;
            // 
            // finiteFloorLabel
            // 
            this.finiteFloorLabel.AutoSize = true;
            this.finiteFloorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finiteFloorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.finiteFloorLabel.Location = new System.Drawing.Point(228, 1);
            this.finiteFloorLabel.Name = "finiteFloorLabel";
            this.finiteFloorLabel.Size = new System.Drawing.Size(217, 20);
            this.finiteFloorLabel.TabIndex = 15;
            this.finiteFloorLabel.Text = "Finite at (seconds)";
            this.finiteFloorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialFlootLabel
            // 
            this.initialFlootLabel.AutoSize = true;
            this.initialFlootLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialFlootLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.initialFlootLabel.Location = new System.Drawing.Point(4, 1);
            this.initialFlootLabel.Name = "initialFlootLabel";
            this.initialFlootLabel.Size = new System.Drawing.Size(217, 20);
            this.initialFlootLabel.TabIndex = 14;
            this.initialFlootLabel.Text = "Start at (seconds)";
            this.initialFlootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Location = new System.Drawing.Point(256, 342);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(136, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete plan...";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.Location = new System.Drawing.Point(32, 342);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add plan...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(375, 342);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlanFireAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 376);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.planFireAlarmTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlanFireAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanFireAlarmForm";
            this.planFireAlarmTable.ResumeLayout(false);
            this.planFireAlarmTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label finiteFloorLabel;
        private System.Windows.Forms.Label initialFlootLabel;
        private System.Windows.Forms.TableLayoutPanel planFireAlarmTable;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}