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
            this.liftAccelerationSelecter = new System.Windows.Forms.NumericUpDown();
            this.StrategySelecter = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftSpeedSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacitySelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftsCountSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftAccelerationSelecter)).BeginInit();
            this.SuspendLayout();
            // 
            // liftStrategyLabel
            // 
            this.liftStrategyLabel.AutoSize = true;
            this.liftStrategyLabel.Location = new System.Drawing.Point(9, 9);
            this.liftStrategyLabel.Name = "liftStrategyLabel";
            this.liftStrategyLabel.Size = new System.Drawing.Size(96, 13);
            this.liftStrategyLabel.TabIndex = 0;
            this.liftStrategyLabel.Text = "Choose lift strategy";
            // 
            // liftCapacityLabel
            // 
            this.liftCapacityLabel.AutoSize = true;
            this.liftCapacityLabel.Location = new System.Drawing.Point(135, 9);
            this.liftCapacityLabel.Name = "liftCapacityLabel";
            this.liftCapacityLabel.Size = new System.Drawing.Size(79, 13);
            this.liftCapacityLabel.TabIndex = 1;
            this.liftCapacityLabel.Text = "Set lift capacity";
            // 
            // liftSpeedLabel
            // 
            this.liftSpeedLabel.AutoSize = true;
            this.liftSpeedLabel.Location = new System.Drawing.Point(261, 9);
            this.liftSpeedLabel.Name = "liftSpeedLabel";
            this.liftSpeedLabel.Size = new System.Drawing.Size(90, 13);
            this.liftSpeedLabel.TabIndex = 2;
            this.liftSpeedLabel.Text = "Set max lift speed";
            // 
            // liftAcelerationLabel
            // 
            this.liftAcelerationLabel.AutoSize = true;
            this.liftAcelerationLabel.Location = new System.Drawing.Point(387, 9);
            this.liftAcelerationLabel.Name = "liftAcelerationLabel";
            this.liftAcelerationLabel.Size = new System.Drawing.Size(119, 13);
            this.liftAcelerationLabel.TabIndex = 3;
            this.liftAcelerationLabel.Text = "Set max lift acceleration";
            // 
            // liftCountLabel
            // 
            this.liftCountLabel.AutoSize = true;
            this.liftCountLabel.Location = new System.Drawing.Point(138, 48);
            this.liftCountLabel.Name = "liftCountLabel";
            this.liftCountLabel.Size = new System.Drawing.Size(71, 13);
            this.liftCountLabel.TabIndex = 4;
            this.liftCountLabel.Text = "Set lifts count";
            // 
            // floorCountLabel
            // 
            this.floorCountLabel.AutoSize = true;
            this.floorCountLabel.Location = new System.Drawing.Point(261, 48);
            this.floorCountLabel.Name = "floorCountLabel";
            this.floorCountLabel.Size = new System.Drawing.Size(81, 13);
            this.floorCountLabel.TabIndex = 5;
            this.floorCountLabel.Text = "Set floors count";
            // 
            // floorsCountSelecter
            // 
            this.floorsCountSelecter.Location = new System.Drawing.Point(264, 64);
            this.floorsCountSelecter.Name = "floorsCountSelecter";
            this.floorsCountSelecter.Size = new System.Drawing.Size(120, 20);
            this.floorsCountSelecter.TabIndex = 6;
            // 
            // liftSpeedSelecter
            // 
            this.liftSpeedSelecter.Location = new System.Drawing.Point(264, 25);
            this.liftSpeedSelecter.Name = "liftSpeedSelecter";
            this.liftSpeedSelecter.Size = new System.Drawing.Size(120, 20);
            this.liftSpeedSelecter.TabIndex = 7;
            // 
            // liftCapacitySelecter
            // 
            this.liftCapacitySelecter.Location = new System.Drawing.Point(138, 25);
            this.liftCapacitySelecter.Name = "liftCapacitySelecter";
            this.liftCapacitySelecter.Size = new System.Drawing.Size(120, 20);
            this.liftCapacitySelecter.TabIndex = 8;
            // 
            // liftsCountSelecter
            // 
            this.liftsCountSelecter.Location = new System.Drawing.Point(138, 64);
            this.liftsCountSelecter.Name = "liftsCountSelecter";
            this.liftsCountSelecter.Size = new System.Drawing.Size(120, 20);
            this.liftsCountSelecter.TabIndex = 9;
            // 
            // liftAccelerationSelecter
            // 
            this.liftAccelerationSelecter.Location = new System.Drawing.Point(390, 25);
            this.liftAccelerationSelecter.Name = "liftAccelerationSelecter";
            this.liftAccelerationSelecter.Size = new System.Drawing.Size(120, 20);
            this.liftAccelerationSelecter.TabIndex = 10;
            // 
            // StrategySelecter
            // 
            this.StrategySelecter.FormattingEnabled = true;
            this.StrategySelecter.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.StrategySelecter.Location = new System.Drawing.Point(12, 25);
            this.StrategySelecter.Name = "StrategySelecter";
            this.StrategySelecter.Size = new System.Drawing.Size(120, 95);
            this.StrategySelecter.TabIndex = 11;
            // 
            // SystemParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 133);
            this.Controls.Add(this.StrategySelecter);
            this.Controls.Add(this.liftAccelerationSelecter);
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
            this.Name = "SystemParameters";
            this.Text = "SystemParameters";
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftSpeedSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacitySelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftsCountSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftAccelerationSelecter)).EndInit();
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
        private System.Windows.Forms.NumericUpDown liftAccelerationSelecter;
        private System.Windows.Forms.ListBox StrategySelecter;
    }
}