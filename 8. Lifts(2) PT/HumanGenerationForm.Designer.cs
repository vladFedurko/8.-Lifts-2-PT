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
            this.denyButton = new System.Windows.Forms.Button();
            this.humanGenerationTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // humanGenerationTable
            // 
            this.humanGenerationTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.humanGenerationTable.AutoScroll = true;
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
            this.humanGenerationTable.Location = new System.Drawing.Point(12, 12);
            this.humanGenerationTable.Name = "humanGenerationTable";
            this.humanGenerationTable.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.humanGenerationTable.RowCount = 2;
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.humanGenerationTable.Size = new System.Drawing.Size(1095, 179);
            this.humanGenerationTable.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(817, 1);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(264, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Через (секунд)";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_humansLabel
            // 
            this.num_of_humansLabel.AutoSize = true;
            this.num_of_humansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_of_humansLabel.Location = new System.Drawing.Point(4, 1);
            this.num_of_humansLabel.Name = "num_of_humansLabel";
            this.num_of_humansLabel.Size = new System.Drawing.Size(264, 20);
            this.num_of_humansLabel.TabIndex = 1;
            this.num_of_humansLabel.Text = "Число создаваемых людей";
            this.num_of_humansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finite_floorLabel
            // 
            this.finite_floorLabel.AutoSize = true;
            this.finite_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finite_floorLabel.Location = new System.Drawing.Point(546, 1);
            this.finite_floorLabel.Name = "finite_floorLabel";
            this.finite_floorLabel.Size = new System.Drawing.Size(264, 20);
            this.finite_floorLabel.TabIndex = 3;
            this.finite_floorLabel.Text = "Конечный этаж";
            this.finite_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initial_floorLabel
            // 
            this.initial_floorLabel.AutoSize = true;
            this.initial_floorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initial_floorLabel.Location = new System.Drawing.Point(275, 1);
            this.initial_floorLabel.Name = "initial_floorLabel";
            this.initial_floorLabel.Size = new System.Drawing.Size(264, 20);
            this.initial_floorLabel.TabIndex = 2;
            this.initial_floorLabel.Text = "Начальный этаж";
            this.initial_floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.Location = new System.Drawing.Point(335, 198);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 28);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить правило...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Location = new System.Drawing.Point(521, 198);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.denyButton.Location = new System.Drawing.Point(642, 197);
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
            this.ClientSize = new System.Drawing.Size(1119, 233);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.humanGenerationTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button denyButton;
    }
}