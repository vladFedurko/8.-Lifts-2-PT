namespace _8.Lifts_2__PT
{
    partial class SimulationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.simulationTable = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fireAlarmButton = new System.Windows.Forms.Button();
            this.speedSelecter = new System.Windows.Forms.NumericUpDown();
            this.simulationSpeedLabel = new System.Windows.Forms.Label();
            this.createHumanButton = new System.Windows.Forms.Button();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemParametersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.humanControllingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createHumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanGenerationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liftConifurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planFireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelecter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationTable
            // 
            this.simulationTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.simulationTable.ColumnCount = 4;
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.simulationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulationTable.Location = new System.Drawing.Point(0, 28);
            this.simulationTable.Margin = new System.Windows.Forms.Padding(0);
            this.simulationTable.Name = "simulationTable";
            this.simulationTable.Padding = new System.Windows.Forms.Padding(130, 20, 50, 50);
            this.simulationTable.RowCount = 6;
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.Size = new System.Drawing.Size(1243, 653);
            this.simulationTable.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(12, 107);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(12, 166);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 39);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // fireAlarmButton
            // 
            this.fireAlarmButton.BackColor = System.Drawing.Color.IndianRed;
            this.fireAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fireAlarmButton.Location = new System.Drawing.Point(13, 458);
            this.fireAlarmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireAlarmButton.Name = "fireAlarmButton";
            this.fireAlarmButton.Size = new System.Drawing.Size(101, 48);
            this.fireAlarmButton.TabIndex = 3;
            this.fireAlarmButton.Text = "Fire alarm";
            this.fireAlarmButton.UseVisualStyleBackColor = false;
            this.fireAlarmButton.Click += new System.EventHandler(this.FireAlarmButton_Click);
            // 
            // speedSelecter
            // 
            this.speedSelecter.DecimalPlaces = 2;
            this.speedSelecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedSelecter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.speedSelecter.Location = new System.Drawing.Point(13, 249);
            this.speedSelecter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speedSelecter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedSelecter.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.speedSelecter.Name = "speedSelecter";
            this.speedSelecter.Size = new System.Drawing.Size(101, 24);
            this.speedSelecter.TabIndex = 4;
            this.speedSelecter.Tag = "";
            this.speedSelecter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedSelecter.ValueChanged += new System.EventHandler(this.SpeedSelecter_ValueChanged);
            // 
            // simulationSpeedLabel
            // 
            this.simulationSpeedLabel.AutoSize = true;
            this.simulationSpeedLabel.Location = new System.Drawing.Point(9, 228);
            this.simulationSpeedLabel.Name = "simulationSpeedLabel";
            this.simulationSpeedLabel.Size = new System.Drawing.Size(116, 17);
            this.simulationSpeedLabel.TabIndex = 5;
            this.simulationSpeedLabel.Text = "Simulation speed";
            // 
            // createHumanButton
            // 
            this.createHumanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createHumanButton.Location = new System.Drawing.Point(13, 383);
            this.createHumanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createHumanButton.Name = "createHumanButton";
            this.createHumanButton.Size = new System.Drawing.Size(102, 57);
            this.createHumanButton.TabIndex = 6;
            this.createHumanButton.Text = "Create human";
            this.createHumanButton.UseVisualStyleBackColor = true;
            this.createHumanButton.Click += new System.EventHandler(this.CreateHumanButton_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.fireAlarmToolStripMenuItem,
            this.systemParametersToolStripMenuItem1});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // fireAlarmToolStripMenuItem
            // 
            this.fireAlarmToolStripMenuItem.Name = "fireAlarmToolStripMenuItem";
            this.fireAlarmToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.fireAlarmToolStripMenuItem.Text = "Fire alarm";
            this.fireAlarmToolStripMenuItem.Click += new System.EventHandler(this.FireAlarmButton_Click);
            // 
            // systemParametersToolStripMenuItem1
            // 
            this.systemParametersToolStripMenuItem1.Name = "systemParametersToolStripMenuItem1";
            this.systemParametersToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.systemParametersToolStripMenuItem1.Text = "System parameters";
            this.systemParametersToolStripMenuItem1.Click += new System.EventHandler(this.systemParametersToolStripMenuItem1_Click);
            // 
            // humanControllingToolStripMenuItem
            // 
            this.humanControllingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHumanToolStripMenuItem,
            this.humanGenerationToolStripMenuItem,
            this.humanStatusToolStripMenuItem});
            this.humanControllingToolStripMenuItem.Name = "humanControllingToolStripMenuItem";
            this.humanControllingToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.humanControllingToolStripMenuItem.Text = "Human controlling";
            // 
            // createHumanToolStripMenuItem
            // 
            this.createHumanToolStripMenuItem.Name = "createHumanToolStripMenuItem";
            this.createHumanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createHumanToolStripMenuItem.Text = "Create human";
            this.createHumanToolStripMenuItem.Click += new System.EventHandler(this.CreateHumanButton_Click);
            // 
            // humanGenerationToolStripMenuItem
            // 
            this.humanGenerationToolStripMenuItem.Name = "humanGenerationToolStripMenuItem";
            this.humanGenerationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.humanGenerationToolStripMenuItem.Text = "Human generation";
            this.humanGenerationToolStripMenuItem.Click += new System.EventHandler(this.HumanGenerationToolStripMenuItem_Click);
            // 
            // humanStatusToolStripMenuItem
            // 
            this.humanStatusToolStripMenuItem.Name = "humanStatusToolStripMenuItem";
            this.humanStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.humanStatusToolStripMenuItem.Text = "Human status";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanGenerationToolStripMenuItem1,
            this.liftConifurationsToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.planFireAlarmToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // humanGenerationToolStripMenuItem1
            // 
            this.humanGenerationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.humanGenerationToolStripMenuItem1.Name = "humanGenerationToolStripMenuItem1";
            this.humanGenerationToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.humanGenerationToolStripMenuItem1.Text = "Human generation";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // liftConifurationsToolStripMenuItem
            // 
            this.liftConifurationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.liftConifurationsToolStripMenuItem.Name = "liftConifurationsToolStripMenuItem";
            this.liftConifurationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.liftConifurationsToolStripMenuItem.Text = "Lift conifurations";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Enabled = false;
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statisticToolStripMenuItem.Text = "Show statistics";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.StatisticToolStripMenuItem_Click);
            // 
            // planFireAlarmToolStripMenuItem
            // 
            this.planFireAlarmToolStripMenuItem.Name = "planFireAlarmToolStripMenuItem";
            this.planFireAlarmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.planFireAlarmToolStripMenuItem.Text = "Plan fire alarm";
            this.planFireAlarmToolStripMenuItem.Click += new System.EventHandler(this.PlanFireAlarmToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem,
            this.humanControllingToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1243, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1243, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.createHumanButton);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.speedSelecter);
            this.Controls.Add(this.fireAlarmButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.simulationTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1261, 728);
            this.Name = "SimulationForm";
            this.Text = "SimuLifts";
            ((System.ComponentModel.ISupportInitialize)(this.speedSelecter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel simulationTable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button fireAlarmButton;
        private System.Windows.Forms.NumericUpDown speedSelecter;
        private System.Windows.Forms.Label simulationSpeedLabel;
        private System.Windows.Forms.Button createHumanButton;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemParametersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem humanControllingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createHumanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanGenerationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liftConifurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planFireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

