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
            this.SpeedSelecter = new System.Windows.Forms.NumericUpDown();
            this.simulationSpeedLabel = new System.Windows.Forms.Label();
            this.createHumanButton = new System.Windows.Forms.Button();
            this.SimulationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FireAlarmMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemParametersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HumanControllingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateHumanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HumanGenerationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HumanStatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanGenerationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liftConifurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanFireAlarmMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSelecter)).BeginInit();
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
            this.simulationTable.Padding = new System.Windows.Forms.Padding(131, 20, 51, 50);
            this.simulationTable.RowCount = 6;
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.Size = new System.Drawing.Size(1245, 661);
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
            this.startButton.Click += new System.EventHandler(this.StartSimulationClick);

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
            this.stopButton.Click += new System.EventHandler(this.StopSimulationClick);

            // 
            // fireAlarmButton
            // 
            this.fireAlarmButton.BackColor = System.Drawing.Color.IndianRed;
            this.fireAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fireAlarmButton.Location = new System.Drawing.Point(13, 458);
            this.fireAlarmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireAlarmButton.Name = "fireAlarmButton";
            this.fireAlarmButton.Size = new System.Drawing.Size(112, 47);
            this.fireAlarmButton.TabIndex = 3;
            this.fireAlarmButton.Text = "Fire alarm";
            this.fireAlarmButton.UseVisualStyleBackColor = false;
            this.fireAlarmButton.Click += new System.EventHandler(this.FireAlarmClick);
            // 
            // SpeedSelecter
            // 
            this.SpeedSelecter.DecimalPlaces = 2;
            this.SpeedSelecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedSelecter.Increment = new decimal(new int[] {

            25,
            0,
            0,
            131072});

            this.SpeedSelecter.Location = new System.Drawing.Point(13, 249);
            this.SpeedSelecter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeedSelecter.Maximum = new decimal(new int[] {

            10,
            0,
            0,
            0});

            this.SpeedSelecter.Minimum = new decimal(new int[] {

            25,
            0,
            0,
            131072});
            this.SpeedSelecter.Name = "SpeedSelecter";
            this.SpeedSelecter.Size = new System.Drawing.Size(101, 24);
            this.SpeedSelecter.TabIndex = 4;
            this.SpeedSelecter.Tag = "";
            this.SpeedSelecter.Value = new decimal(new int[] {

            1,
            0,
            0,
            0});
            this.SpeedSelecter.ValueChanged += new System.EventHandler(this.ChangeSimulationSpeed);

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
            this.createHumanButton.Size = new System.Drawing.Size(101, 57);
            this.createHumanButton.TabIndex = 6;
            this.createHumanButton.Text = "Create human";
            this.createHumanButton.UseVisualStyleBackColor = true;
            this.createHumanButton.Click += new System.EventHandler(this.CreateHumanClick);
            // 
            // SimulationMenuItem
            // 
            this.SimulationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenuItem,
            this.PauseMenuItem,
            this.StopMenuItem,
            this.FireAlarmMenuItem,
            this.SystemParametersMenuItem});
            this.SimulationMenuItem.Name = "SimulationMenuItem";
            this.SimulationMenuItem.Size = new System.Drawing.Size(94, 24);
            this.SimulationMenuItem.Text = "Simulation";
            // 
            // StartMenuItem
            // 
            this.StartMenuItem.Name = "StartMenuItem";
            this.StartMenuItem.Size = new System.Drawing.Size(218, 26);
            this.StartMenuItem.Text = "Start";
            this.StartMenuItem.Click += new System.EventHandler(this.StartSimulationClick);
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Enabled = false;
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(218, 26);
            this.PauseMenuItem.Text = "Pause";
            this.PauseMenuItem.Click += new System.EventHandler(this.StartSimulationClick);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(218, 26);
            this.StopMenuItem.Text = "Stop";
            this.StopMenuItem.Click += new System.EventHandler(this.StopSimulationClick);
            // 
            // FireAlarmMenuItem
            // 
            this.FireAlarmMenuItem.Name = "FireAlarmMenuItem";
            this.FireAlarmMenuItem.Size = new System.Drawing.Size(218, 26);
            this.FireAlarmMenuItem.Text = "Fire alarm";
            this.FireAlarmMenuItem.Click += new System.EventHandler(this.FireAlarmClick);
            // 
            // SystemParametersMenuItem
            // 
            this.SystemParametersMenuItem.Name = "SystemParametersMenuItem";
            this.SystemParametersMenuItem.Size = new System.Drawing.Size(218, 26);
            this.SystemParametersMenuItem.Text = "System parameters";
            this.SystemParametersMenuItem.Click += new System.EventHandler(this.SystemParametersClick);
            // 
            // HumanControllingMenuItem
            // 
            this.HumanControllingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateHumanMenuItem,
            this.HumanGenerationMenuItem,
            this.HumanStatusMenuItem});
            this.HumanControllingMenuItem.Name = "HumanControllingMenuItem";
            this.HumanControllingMenuItem.Size = new System.Drawing.Size(147, 24);
            this.HumanControllingMenuItem.Text = "Human controlling";
            // 
            // CreateHumanMenuItem
            // 
            this.CreateHumanMenuItem.Name = "CreateHumanMenuItem";
            this.CreateHumanMenuItem.Size = new System.Drawing.Size(216, 26);
            this.CreateHumanMenuItem.Text = "Create human";
            this.CreateHumanMenuItem.Click += new System.EventHandler(this.CreateHumanClick);
            // 
            // HumanGenerationMenuItem
            // 
            this.HumanGenerationMenuItem.Name = "HumanGenerationMenuItem";
            this.HumanGenerationMenuItem.Size = new System.Drawing.Size(216, 26);
            this.HumanGenerationMenuItem.Text = "Human generation";
            this.HumanGenerationMenuItem.Click += new System.EventHandler(this.HumanGenerationClick);
            // 
            // HumanStatusMenuItem
            // 
            this.HumanStatusMenuItem.Name = "HumanStatusMenuItem";
            this.HumanStatusMenuItem.Size = new System.Drawing.Size(216, 26);
            this.HumanStatusMenuItem.Text = "Human status";
            this.HumanStatusMenuItem.Click += new System.EventHandler(this.HumanStatusClick);
            // 
            // ConfigurationMenuItem
            // 
            this.ConfigurationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanGenerationToolStripMenuItem1,
            this.liftConifurationsToolStripMenuItem,
            this.StatisticMenuItem,
            this.PlanFireAlarmMenuItem});
            this.ConfigurationMenuItem.Name = "ConfigurationMenuItem";
            this.ConfigurationMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ConfigurationMenuItem.Text = "Configuration";
            // 
            // humanGenerationToolStripMenuItem1
            // 
            this.humanGenerationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.LoadMenuItem});
            this.humanGenerationToolStripMenuItem1.Name = "humanGenerationToolStripMenuItem1";
            this.humanGenerationToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.humanGenerationToolStripMenuItem1.Text = "Human generation";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveHumanGenerationClick);
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LoadMenuItem.Text = "Load";
            this.LoadMenuItem.Click += new System.EventHandler(this.LoadHumanGenerationClick);
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
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveLiftConfigurationClick);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.LoadLiftConfiguration);
            // 
            // StatisticMenuItem
            // 
            this.StatisticMenuItem.Enabled = false;
            this.StatisticMenuItem.Name = "StatisticMenuItem";
            this.StatisticMenuItem.Size = new System.Drawing.Size(224, 26);
            this.StatisticMenuItem.Text = "Show statistics";
            this.StatisticMenuItem.Click += new System.EventHandler(this.StatisticsClick);
            // 
            // PlanFireAlarmMenuItem
            // 
            this.PlanFireAlarmMenuItem.Name = "PlanFireAlarmMenuItem";
            this.PlanFireAlarmMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PlanFireAlarmMenuItem.Text = "Plan fire alarm";
            this.PlanFireAlarmMenuItem.Click += new System.EventHandler(this.PlanFireAlarmClick);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimulationMenuItem,
            this.HumanControllingMenuItem,
            this.ConfigurationMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1245, 26);
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
            this.ClientSize = new System.Drawing.Size(1245, 689);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.createHumanButton);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.SpeedSelecter);
            this.Controls.Add(this.fireAlarmButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.simulationTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1261, 726);
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuLifts";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSelecter)).EndInit();
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
        private System.Windows.Forms.NumericUpDown SpeedSelecter;
        private System.Windows.Forms.Label simulationSpeedLabel;
        private System.Windows.Forms.Button createHumanButton;
        private System.Windows.Forms.ToolStripMenuItem SimulationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FireAlarmMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemParametersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HumanControllingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateHumanMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HumanGenerationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HumanStatusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanGenerationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liftConifurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StatisticMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlanFireAlarmMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

