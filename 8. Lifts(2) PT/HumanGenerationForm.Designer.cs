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
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            this.deleteButton = new System.Windows.Forms.Button();
            this.humanGenerationTable.SuspendLayout();
            this.SuspendLayout();
            
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberOfGeneratedPeopleolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialFloorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finiteFloorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inSecondsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.Location = new System.Drawing.Point(178, 198);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 28);
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

            this.saveButton.Location = new System.Drawing.Point(364, 198);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
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
            this.cancelButton.Location = new System.Drawing.Point(491, 198);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfGeneratedPeopleolumn,
            this.initialFloorColumn,
            this.finiteFloorColumn,
            this.inSecondsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // numberOfGeneratedPeopleolumn
            // 
            this.numberOfGeneratedPeopleolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfGeneratedPeopleolumn.HeaderText = "Number of generated people";
            this.numberOfGeneratedPeopleolumn.MinimumWidth = 6;
            this.numberOfGeneratedPeopleolumn.Name = "numberOfGeneratedPeopleolumn";
            this.numberOfGeneratedPeopleolumn.ReadOnly = true;
            // 
            // initialFloorColumn
            // 
            this.initialFloorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.initialFloorColumn.HeaderText = "Initial floor";
            this.initialFloorColumn.MinimumWidth = 6;
            this.initialFloorColumn.Name = "initialFloorColumn";
            // 
            // finiteFloorColumn
            // 
            this.finiteFloorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finiteFloorColumn.HeaderText = "Finite floor";
            this.finiteFloorColumn.MinimumWidth = 6;
            this.finiteFloorColumn.Name = "finiteFloorColumn";
            // 
            // inSecondsColumn
            // 
            this.inSecondsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inSecondsColumn.HeaderText = "In (seconds)";
            this.inSecondsColumn.MinimumWidth = 6;
            this.inSecondsColumn.Name = "inSecondsColumn";

            // 
            // HumanGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 233);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HumanGenerationForm";
            this.Text = "HumanGenerationForm";
            this.Deactivate += new System.EventHandler(this.HumanGenerationForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfGeneratedPeopleolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialFloorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finiteFloorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inSecondsColumn;
    }
}