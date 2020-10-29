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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.finiteFloorSelector = new System.Windows.Forms.NumericUpDown();
            this.initialFloorSelector = new System.Windows.Forms.NumericUpDown();
            this.finiteFloorLabel = new System.Windows.Forms.Label();
            this.initialFlootLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(246, 94);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 28);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(28, 94);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 28);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // finiteFloorSelector
            // 
            this.finiteFloorSelector.Location = new System.Drawing.Point(209, 45);
            this.finiteFloorSelector.Margin = new System.Windows.Forms.Padding(4);
            this.finiteFloorSelector.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.finiteFloorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.finiteFloorSelector.Name = "finiteFloorSelector";
            this.finiteFloorSelector.Size = new System.Drawing.Size(160, 22);
            this.finiteFloorSelector.TabIndex = 18;
            this.finiteFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // initialFloorSelector
            // 
            this.initialFloorSelector.Location = new System.Drawing.Point(28, 45);
            this.initialFloorSelector.Margin = new System.Windows.Forms.Padding(4);
            this.initialFloorSelector.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.initialFloorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.initialFloorSelector.Name = "initialFloorSelector";
            this.initialFloorSelector.Size = new System.Drawing.Size(160, 22);
            this.initialFloorSelector.TabIndex = 17;
            this.initialFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finiteFloorLabel
            // 
            this.finiteFloorLabel.AutoSize = true;
            this.finiteFloorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.finiteFloorLabel.Location = new System.Drawing.Point(207, 25);
            this.finiteFloorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finiteFloorLabel.Name = "finiteFloorLabel";
            this.finiteFloorLabel.Size = new System.Drawing.Size(125, 17);
            this.finiteFloorLabel.TabIndex = 15;
            this.finiteFloorLabel.Text = "Finite at (seconds)";
            // 
            // initialFlootLabel
            // 
            this.initialFlootLabel.AutoSize = true;
            this.initialFlootLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.initialFlootLabel.Location = new System.Drawing.Point(25, 24);
            this.initialFlootLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialFlootLabel.Name = "initialFlootLabel";
            this.initialFlootLabel.Size = new System.Drawing.Size(121, 17);
            this.initialFlootLabel.TabIndex = 14;
            this.initialFlootLabel.Text = "Start at (seconds)";
            // 
            // PlanFireAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 157);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.finiteFloorSelector);
            this.Controls.Add(this.initialFloorSelector);
            this.Controls.Add(this.finiteFloorLabel);
            this.Controls.Add(this.initialFlootLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanFireAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanFireAlarmForm";
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown finiteFloorSelector;
        private System.Windows.Forms.NumericUpDown initialFloorSelector;
        private System.Windows.Forms.Label finiteFloorLabel;
        private System.Windows.Forms.Label initialFlootLabel;
    }
}