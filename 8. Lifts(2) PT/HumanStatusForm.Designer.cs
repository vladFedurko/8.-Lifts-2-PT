namespace _8.Lifts_2__PT
{
    partial class HumanStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanStatusForm));
            this.FloorRadioButton = new System.Windows.Forms.RadioButton();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseFloorOfLiftLabel = new System.Windows.Forms.Label();
            this.NumberOfLiftOrFloorSelecter = new System.Windows.Forms.NumericUpDown();
            this.LiftRadioButton = new System.Windows.Forms.RadioButton();
            this.statusTable = new System.Windows.Forms.TableLayoutPanel();
            this.numberLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLiftOrFloorSelecter)).BeginInit();
            this.statusTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloorRadioButton
            // 
            this.FloorRadioButton.AutoSize = true;
            this.FloorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorRadioButton.Location = new System.Drawing.Point(6, 34);
            this.FloorRadioButton.Name = "FloorRadioButton";
            this.FloorRadioButton.Size = new System.Drawing.Size(68, 24);
            this.FloorRadioButton.TabIndex = 0;
            this.FloorRadioButton.TabStop = true;
            this.FloorRadioButton.Text = "Floor";
            this.FloorRadioButton.UseVisualStyleBackColor = true;
            this.FloorRadioButton.CheckedChanged += new System.EventHandler(this.TypeChanged);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.chooseFloorOfLiftLabel);
            this.statusGroupBox.Controls.Add(this.NumberOfLiftOrFloorSelecter);
            this.statusGroupBox.Controls.Add(this.LiftRadioButton);
            this.statusGroupBox.Controls.Add(this.FloorRadioButton);
            this.statusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusGroupBox.Location = new System.Drawing.Point(55, 22);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(313, 96);
            this.statusGroupBox.TabIndex = 1;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Choose floor or lift";
            // 
            // chooseFloorOfLiftLabel
            // 
            this.chooseFloorOfLiftLabel.AutoSize = true;
            this.chooseFloorOfLiftLabel.Location = new System.Drawing.Point(125, 34);
            this.chooseFloorOfLiftLabel.Name = "chooseFloorOfLiftLabel";
            this.chooseFloorOfLiftLabel.Size = new System.Drawing.Size(168, 20);
            this.chooseFloorOfLiftLabel.TabIndex = 3;
            this.chooseFloorOfLiftLabel.Text = "Number of floor or lift";
            // 
            // NumberOfLiftOrFloorSelecter
            // 
            this.NumberOfLiftOrFloorSelecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfLiftOrFloorSelecter.Location = new System.Drawing.Point(152, 57);
            this.NumberOfLiftOrFloorSelecter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOfLiftOrFloorSelecter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfLiftOrFloorSelecter.Name = "NumberOfLiftOrFloorSelecter";
            this.NumberOfLiftOrFloorSelecter.Size = new System.Drawing.Size(120, 27);
            this.NumberOfLiftOrFloorSelecter.TabIndex = 2;
            this.NumberOfLiftOrFloorSelecter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfLiftOrFloorSelecter.ValueChanged += new System.EventHandler(this.NumberOfLiftOrFloorChanged);
            // 
            // LiftRadioButton
            // 
            this.LiftRadioButton.AutoSize = true;
            this.LiftRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LiftRadioButton.Location = new System.Drawing.Point(6, 61);
            this.LiftRadioButton.Name = "LiftRadioButton";
            this.LiftRadioButton.Size = new System.Drawing.Size(54, 24);
            this.LiftRadioButton.TabIndex = 1;
            this.LiftRadioButton.TabStop = true;
            this.LiftRadioButton.Text = "LIft";
            this.LiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusTable
            // 
            this.statusTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.statusTable.ColumnCount = 2;
            this.statusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.statusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusTable.Controls.Add(this.numberLabel, 0, 0);
            this.statusTable.Controls.Add(this.statusLabel, 1, 0);
            this.statusTable.Location = new System.Drawing.Point(55, 139);
            this.statusTable.Name = "statusTable";
            this.statusTable.RowCount = 1;
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusTable.Size = new System.Drawing.Size(313, 42);
            this.statusTable.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(4, 1);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(84, 40);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Number of people";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(95, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(214, 17);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HumanStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.statusTable);
            this.Controls.Add(this.statusGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HumanStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HumanStatusForm";
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLiftOrFloorSelecter)).EndInit();
            this.statusTable.ResumeLayout(false);
            this.statusTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton FloorRadioButton;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.NumericUpDown NumberOfLiftOrFloorSelecter;
        private System.Windows.Forms.RadioButton LiftRadioButton;
        private System.Windows.Forms.Label chooseFloorOfLiftLabel;
        private System.Windows.Forms.TableLayoutPanel statusTable;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}