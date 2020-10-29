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
            this.humanGenerationTable = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.num_of_humansLabel = new System.Windows.Forms.Label();
            this.finite_floorLabel = new System.Windows.Forms.Label();
            this.initial_floorLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            this.humanGenerationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // humanGenerationTable
            // 
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
            this.humanGenerationTable.Controls.Add(this.numericUpDown1, 0, 1);
            this.humanGenerationTable.Controls.Add(this.numericUpDown2, 1, 1);
            this.humanGenerationTable.Controls.Add(this.numericUpDown3, 2, 1);
            this.humanGenerationTable.Controls.Add(this.numericUpDown4, 3, 1);
            this.humanGenerationTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.humanGenerationTable.Location = new System.Drawing.Point(0, 0);
            this.humanGenerationTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.humanGenerationTable.Name = "humanGenerationTable";
            this.humanGenerationTable.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.humanGenerationTable.RowCount = 2;
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.humanGenerationTable.Size = new System.Drawing.Size(847, 87);
            this.humanGenerationTable.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(633, 13);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(196, 23);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Через (секунд)";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_humansLabel
            // 
            this.num_of_humansLabel.AutoSize = true;
            this.num_of_humansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_of_humansLabel.Location = new System.Drawing.Point(18, 13);
            this.num_of_humansLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_of_humansLabel.Name = "num_of_humansLabel";
            this.num_of_humansLabel.Size = new System.Drawing.Size(196, 23);
            this.num_of_humansLabel.TabIndex = 1;
            this.num_of_humansLabel.Text = "Число создаваемых людей";
            this.num_of_humansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finite_floorLabel
            // 
            this.finite_floorLabel.AutoSize = true;
            this.finite_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finite_floorLabel.Location = new System.Drawing.Point(428, 13);
            this.finite_floorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finite_floorLabel.Name = "finite_floorLabel";
            this.finite_floorLabel.Size = new System.Drawing.Size(196, 23);
            this.finite_floorLabel.TabIndex = 3;
            this.finite_floorLabel.Text = "Конечный этаж";
            this.finite_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initial_floorLabel
            // 
            this.initial_floorLabel.AutoSize = true;
            this.initial_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initial_floorLabel.Location = new System.Drawing.Point(223, 13);
            this.initial_floorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initial_floorLabel.Name = "initial_floorLabel";
            this.initial_floorLabel.Size = new System.Drawing.Size(196, 23);
            this.initial_floorLabel.TabIndex = 2;
            this.initial_floorLabel.Text = "Начальный этаж";
            this.initial_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(18, 41);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(223, 41);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown3.Location = new System.Drawing.Point(428, 41);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown4.Location = new System.Drawing.Point(633, 41);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown4.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(160, 127);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 28);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить правило...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(372, 127);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.Location = new System.Drawing.Point(533, 126);
            this.denyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(100, 28);
            this.denyButton.TabIndex = 3;
            this.denyButton.Text = "Отмена";
            this.denyButton.UseVisualStyleBackColor = true;
            this.denyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // HumanGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 170);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.humanGenerationTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HumanGenerationForm";
            this.Text = "HumanGenerationForm";
            this.Deactivate += new System.EventHandler(this.HumanGenerationForm_Deactivate);
            this.Load += new System.EventHandler(this.HumanGenerationForm_Load);
            this.humanGenerationTable.ResumeLayout(false);
            this.humanGenerationTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel humanGenerationTable;
        private System.Windows.Forms.Label num_of_humansLabel;
        private System.Windows.Forms.Label initial_floorLabel;
        private System.Windows.Forms.Label finite_floorLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button denyButton;
    }
}