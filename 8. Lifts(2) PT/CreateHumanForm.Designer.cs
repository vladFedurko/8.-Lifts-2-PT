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
            this.HumanNumberSelector = new System.Windows.Forms.NumericUpDown();
            this.HumanNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inSecondsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanNumberSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // initialFlootLabel
            // 
            resources.ApplyResources(this.initialFlootLabel, "initialFlootLabel");
            this.initialFlootLabel.Name = "initialFlootLabel";
            // 
            // finiteFloorLabel
            // 
            resources.ApplyResources(this.finiteFloorLabel, "finiteFloorLabel");
            this.finiteFloorLabel.Name = "finiteFloorLabel";
            // 
            // inSecondsLabel
            // 
            resources.ApplyResources(this.inSecondsLabel, "inSecondsLabel");
            this.inSecondsLabel.Name = "inSecondsLabel";
            // 
            // initialFloorSelector
            // 
            resources.ApplyResources(this.initialFloorSelector, "initialFloorSelector");
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
            this.initialFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finiteFloorSelector
            // 
            resources.ApplyResources(this.finiteFloorSelector, "finiteFloorSelector");
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
            this.finiteFloorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inSecondsSelector
            // 
            resources.ApplyResources(this.inSecondsSelector, "inSecondsSelector");
            this.inSecondsSelector.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.inSecondsSelector.Name = "inSecondsSelector";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // HumanNumberSelector
            // 
            resources.ApplyResources(this.HumanNumberSelector, "HumanNumberSelector");
            this.HumanNumberSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HumanNumberSelector.Name = "HumanNumberSelector";
            this.HumanNumberSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HumanNumberLabel
            // 
            resources.ApplyResources(this.HumanNumberLabel, "HumanNumberLabel");
            this.HumanNumberLabel.Name = "HumanNumberLabel";
            // 
            // CreateHumanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.HumanNumberLabel);
            this.Controls.Add(this.HumanNumberSelector);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inSecondsSelector);
            this.Controls.Add(this.finiteFloorSelector);
            this.Controls.Add(this.initialFloorSelector);
            this.Controls.Add(this.inSecondsLabel);
            this.Controls.Add(this.finiteFloorLabel);
            this.Controls.Add(this.initialFlootLabel);
            this.Name = "CreateHumanForm";
            this.Deactivate += new System.EventHandler(this.CreateHumanForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.initialFloorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteFloorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inSecondsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanNumberSelector)).EndInit();
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
        private System.Windows.Forms.NumericUpDown HumanNumberSelector;
        private System.Windows.Forms.Label HumanNumberLabel;
    }
}