namespace _8.Lifts_2__PT
{
    partial class SystemParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemParametersForm));
            this.liftStrategyLabel = new System.Windows.Forms.Label();
            this.liftCapacityLabel = new System.Windows.Forms.Label();
            this.liftSpeedLabel = new System.Windows.Forms.Label();
            this.liftAcelerationLabel = new System.Windows.Forms.Label();
            this.liftCountLabel = new System.Windows.Forms.Label();
            this.floorCountLabel = new System.Windows.Forms.Label();
            this.floorsCountSelecter = new System.Windows.Forms.NumericUpDown();
            this.liftSpeedSelecter = new System.Windows.Forms.NumericUpDown();
            this.liftCapacitySelecter = new System.Windows.Forms.NumericUpDown();
            this.liftsCountSelecter = new System.Windows.Forms.NumericUpDown();
            this.liftWaitingTimeSelecter = new System.Windows.Forms.NumericUpDown();
            this.StrategySelecter = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftSpeedSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacitySelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftsCountSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftWaitingTimeSelecter)).BeginInit();
            this.SuspendLayout();
            // 
            // liftStrategyLabel
            // 
            this.liftStrategyLabel.AutoSize = true;
            this.liftStrategyLabel.Location = new System.Drawing.Point(12, 11);
            this.liftStrategyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liftStrategyLabel.Name = "liftStrategyLabel";
            this.liftStrategyLabel.Size = new System.Drawing.Size(129, 17);
            this.liftStrategyLabel.TabIndex = 0;
            this.liftStrategyLabel.Text = "Choose lift strategy";
            // 
            // liftCapacityLabel
            // 
            this.liftCapacityLabel.AutoSize = true;
            this.liftCapacityLabel.Location = new System.Drawing.Point(180, 11);
            this.liftCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liftCapacityLabel.Name = "liftCapacityLabel";
            this.liftCapacityLabel.Size = new System.Drawing.Size(147, 17);
            this.liftCapacityLabel.TabIndex = 1;
            this.liftCapacityLabel.Text = "Lift capacity (humans)";
            // 
            // liftSpeedLabel
            // 
            this.liftSpeedLabel.AutoSize = true;
            this.liftSpeedLabel.Location = new System.Drawing.Point(348, 11);
            this.liftSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liftSpeedLabel.Name = "liftSpeedLabel";
            this.liftSpeedLabel.Size = new System.Drawing.Size(167, 17);
            this.liftSpeedLabel.TabIndex = 2;
            this.liftSpeedLabel.Text = "Lift speed (sec. per floor)";
            // 
            // liftAcelerationLabel
            // 
            this.liftAcelerationLabel.AutoSize = true;
            this.liftAcelerationLabel.Location = new System.Drawing.Point(516, 11);
            this.liftAcelerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liftAcelerationLabel.Name = "liftAcelerationLabel";
            this.liftAcelerationLabel.Size = new System.Drawing.Size(171, 17);
            this.liftAcelerationLabel.TabIndex = 3;
            this.liftAcelerationLabel.Text = "Waiting time of lift on floor";
            // 
            // liftCountLabel
            // 
            this.liftCountLabel.AutoSize = true;
            this.liftCountLabel.Location = new System.Drawing.Point(184, 59);
            this.liftCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liftCountLabel.Name = "liftCountLabel";
            this.liftCountLabel.Size = new System.Drawing.Size(73, 17);
            this.liftCountLabel.TabIndex = 4;
            this.liftCountLabel.Text = "Lifts count";
            // 
            // floorCountLabel
            // 
            this.floorCountLabel.AutoSize = true;
            this.floorCountLabel.Location = new System.Drawing.Point(348, 59);
            this.floorCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.floorCountLabel.Name = "floorCountLabel";
            this.floorCountLabel.Size = new System.Drawing.Size(86, 17);
            this.floorCountLabel.TabIndex = 5;
            this.floorCountLabel.Text = "Floors count";
            // 
            // floorsCountSelecter
            // 
            this.floorsCountSelecter.Location = new System.Drawing.Point(352, 79);
            this.floorsCountSelecter.Margin = new System.Windows.Forms.Padding(4);
            this.floorsCountSelecter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.floorsCountSelecter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.floorsCountSelecter.Name = "floorsCountSelecter";
            this.floorsCountSelecter.Size = new System.Drawing.Size(160, 22);
            this.floorsCountSelecter.TabIndex = 6;
            this.floorsCountSelecter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // liftSpeedSelecter
            // 
            this.liftSpeedSelecter.Location = new System.Drawing.Point(352, 31);
            this.liftSpeedSelecter.Margin = new System.Windows.Forms.Padding(4);
            this.liftSpeedSelecter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.liftSpeedSelecter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.liftSpeedSelecter.Name = "liftSpeedSelecter";
            this.liftSpeedSelecter.Size = new System.Drawing.Size(160, 22);
            this.liftSpeedSelecter.TabIndex = 7;
            this.liftSpeedSelecter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // liftCapacitySelecter
            // 
            this.liftCapacitySelecter.Location = new System.Drawing.Point(184, 31);
            this.liftCapacitySelecter.Margin = new System.Windows.Forms.Padding(4);
            this.liftCapacitySelecter.Name = "liftCapacitySelecter";
            this.liftCapacitySelecter.Size = new System.Drawing.Size(160, 22);
            this.liftCapacitySelecter.TabIndex = 8;
            this.liftCapacitySelecter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // liftsCountSelecter
            // 
            this.liftsCountSelecter.Location = new System.Drawing.Point(184, 79);
            this.liftsCountSelecter.Margin = new System.Windows.Forms.Padding(4);
            this.liftsCountSelecter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.liftsCountSelecter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.liftsCountSelecter.Name = "liftsCountSelecter";
            this.liftsCountSelecter.Size = new System.Drawing.Size(160, 22);
            this.liftsCountSelecter.TabIndex = 9;
            this.liftsCountSelecter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // liftWaitingTimeSelecter
            // 
            this.liftWaitingTimeSelecter.Location = new System.Drawing.Point(520, 31);
            this.liftWaitingTimeSelecter.Margin = new System.Windows.Forms.Padding(4);
            this.liftWaitingTimeSelecter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.liftWaitingTimeSelecter.Name = "liftWaitingTimeSelecter";
            this.liftWaitingTimeSelecter.Size = new System.Drawing.Size(160, 22);
            this.liftWaitingTimeSelecter.TabIndex = 10;
            this.liftWaitingTimeSelecter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // StrategySelecter
            // 
            this.StrategySelecter.FormattingEnabled = true;
            this.StrategySelecter.ItemHeight = 16;
            this.StrategySelecter.Items.AddRange(new object[] {
            "Minimum waiting time",
            "Minimum idling trips"});
            this.StrategySelecter.Location = new System.Drawing.Point(16, 31);
            this.StrategySelecter.Margin = new System.Windows.Forms.Padding(4);
            this.StrategySelecter.Name = "StrategySelecter";
            this.StrategySelecter.Size = new System.Drawing.Size(159, 116);
            this.StrategySelecter.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(188, 121);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 28);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(352, 121);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 28);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SystemParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 164);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.StrategySelecter);
            this.Controls.Add(this.liftWaitingTimeSelecter);
            this.Controls.Add(this.liftsCountSelecter);
            this.Controls.Add(this.liftCapacitySelecter);
            this.Controls.Add(this.liftSpeedSelecter);
            this.Controls.Add(this.floorsCountSelecter);
            this.Controls.Add(this.floorCountLabel);
            this.Controls.Add(this.liftCountLabel);
            this.Controls.Add(this.liftAcelerationLabel);
            this.Controls.Add(this.liftSpeedLabel);
            this.Controls.Add(this.liftCapacityLabel);
            this.Controls.Add(this.liftStrategyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemParametersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemParameters";
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftSpeedSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacitySelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftsCountSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftWaitingTimeSelecter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label liftStrategyLabel;
        private System.Windows.Forms.Label liftCapacityLabel;
        private System.Windows.Forms.Label liftSpeedLabel;
        private System.Windows.Forms.Label liftAcelerationLabel;
        private System.Windows.Forms.Label liftCountLabel;
        private System.Windows.Forms.Label floorCountLabel;
        private System.Windows.Forms.NumericUpDown floorsCountSelecter;
        private System.Windows.Forms.NumericUpDown liftSpeedSelecter;
        private System.Windows.Forms.NumericUpDown liftCapacitySelecter;
        private System.Windows.Forms.NumericUpDown liftsCountSelecter;
        private System.Windows.Forms.NumericUpDown liftWaitingTimeSelecter;
        private System.Windows.Forms.ListBox StrategySelecter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}