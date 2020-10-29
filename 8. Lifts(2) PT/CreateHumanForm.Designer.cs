namespace _8.Lifts_2__PT
{
    partial class CreateHumanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHumanForm));
            this.initialFlootLabel = new System.Windows.Forms.Label();
            this.finiteFloorLabel = new System.Windows.Forms.Label();
            this.inSecondsLabel = new System.Windows.Forms.Label();
            this.initialFloorSelector = new System.Windows.Forms.NumericUpDown();
            this.finiteFloorSelector = new System.Windows.Forms.NumericUpDown();
            this.inSecondsSelector = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inSecondsSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // initialFlootLabel
            // 
            this.initialFlootLabel.AutoSize = true;
            this.initialFlootLabel.Location = new System.Drawing.Point(13, 10);
            this.initialFlootLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialFlootLabel.Name = "initialFlootLabel";
            this.initialFlootLabel.Size = new System.Drawing.Size(72, 17);
            this.initialFlootLabel.TabIndex = 4;
            this.initialFlootLabel.Text = "Initial floor";
            // 
            // finiteFloorLabel
            // 
            this.finiteFloorLabel.AutoSize = true;
            this.finiteFloorLabel.Location = new System.Drawing.Point(195, 11);
            this.finiteFloorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finiteFloorLabel.Name = "finiteFloorLabel";
            this.finiteFloorLabel.Size = new System.Drawing.Size(74, 17);
            this.finiteFloorLabel.TabIndex = 6;
            this.finiteFloorLabel.Text = "Finite floor";
            // 
            // inSecondsLabel
            // 
            this.inSecondsLabel.AutoSize = true;
            this.inSecondsLabel.Location = new System.Drawing.Point(374, 11);
            this.inSecondsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inSecondsLabel.Name = "inSecondsLabel";
            this.inSecondsLabel.Size = new System.Drawing.Size(86, 17);
            this.inSecondsLabel.TabIndex = 7;
            this.inSecondsLabel.Text = "In (seconds)";
            // 
            // initialFloorSelector
            // 
            this.initialFloorSelector.Location = new System.Drawing.Point(16, 31);
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
            this.initialFloorSelector.TabIndex = 8;
            this.initialFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finiteFloorSelector
            // 
            this.finiteFloorSelector.Location = new System.Drawing.Point(197, 31);
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
            this.finiteFloorSelector.TabIndex = 9;
            this.finiteFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inSecondsSelector
            // 
            this.inSecondsSelector.Location = new System.Drawing.Point(377, 31);
            this.inSecondsSelector.Margin = new System.Windows.Forms.Padding(4);
            this.inSecondsSelector.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.inSecondsSelector.Name = "inSecondsSelector";
            this.inSecondsSelector.Size = new System.Drawing.Size(160, 22);
            this.inSecondsSelector.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 70);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 28);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 70);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 28);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 113);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inSecondsSelector);
            this.Controls.Add(this.finiteFloorSelector);
            this.Controls.Add(this.initialFloorSelector);
            this.Controls.Add(this.inSecondsLabel);
            this.Controls.Add(this.finiteFloorLabel);
            this.Controls.Add(this.initialFlootLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateHumanForm";
            this.Text = "Create human";
            this.Load += new System.EventHandler(this.CreateHumanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inSecondsSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label initialFlootLabel;
        private System.Windows.Forms.Label finiteFloorLabel;
        private System.Windows.Forms.Label inSecondsLabel;
        private System.Windows.Forms.NumericUpDown initialFloorSelector;
        private System.Windows.Forms.NumericUpDown finiteFloorSelector;
        private System.Windows.Forms.NumericUpDown inSecondsSelector;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}