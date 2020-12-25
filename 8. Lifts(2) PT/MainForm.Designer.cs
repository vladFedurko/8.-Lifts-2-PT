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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openLiftFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveLiftFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openGenerationFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveGeneratedFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSelecter)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationTable
            // 
            this.simulationTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.simulationTable.ColumnCount = 4;
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.simulationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulationTable.Location = new System.Drawing.Point(0, 24);
            this.simulationTable.Margin = new System.Windows.Forms.Padding(0);
            this.simulationTable.Name = "simulationTable";
            this.simulationTable.Padding = new System.Windows.Forms.Padding(98, 16, 38, 41);
            this.simulationTable.RowCount = 6;
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.Size = new System.Drawing.Size(934, 536);
            this.simulationTable.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(9, 87);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(77, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartSimulationClick);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(9, 135);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(77, 32);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopSimulationClick);
            // 
            // fireAlarmButton
            // 
            this.fireAlarmButton.BackColor = System.Drawing.Color.IndianRed;
            this.fireAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fireAlarmButton.Location = new System.Drawing.Point(10, 372);
            this.fireAlarmButton.Margin = new System.Windows.Forms.Padding(2);
            this.fireAlarmButton.Name = "fireAlarmButton";
            this.fireAlarmButton.Size = new System.Drawing.Size(84, 38);
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
            this.SpeedSelecter.Location = new System.Drawing.Point(10, 202);
            this.SpeedSelecter.Margin = new System.Windows.Forms.Padding(2);
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
            this.SpeedSelecter.Size = new System.Drawing.Size(76, 21);
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
            this.simulationSpeedLabel.Location = new System.Drawing.Point(7, 185);
            this.simulationSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.simulationSpeedLabel.Name = "simulationSpeedLabel";
            this.simulationSpeedLabel.Size = new System.Drawing.Size(87, 13);
            this.simulationSpeedLabel.TabIndex = 5;
            this.simulationSpeedLabel.Text = "Simulation speed";
            // 
            // createHumanButton
            // 
            this.createHumanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createHumanButton.Location = new System.Drawing.Point(10, 311);
            this.createHumanButton.Margin = new System.Windows.Forms.Padding(2);
            this.createHumanButton.Name = "createHumanButton";
            this.createHumanButton.Size = new System.Drawing.Size(76, 46);
            this.createHumanButton.TabIndex = 6;
            this.createHumanButton.Text = "Create human";
            this.createHumanButton.UseVisualStyleBackColor = true;
            this.createHumanButton.Click += new System.EventHandler(this.CreateHumanClick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(934, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // TimeStatusLabel
            // 
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            this.TimeStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.TimeStatusLabel.Text = "Status";
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
            this.SimulationMenuItem.Size = new System.Drawing.Size(76, 20);
            this.SimulationMenuItem.Text = "Simulation";
            // 
            // StartMenuItem
            // 
            this.StartMenuItem.Name = "StartMenuItem";
            this.StartMenuItem.Size = new System.Drawing.Size(174, 22);
            this.StartMenuItem.Text = "Start";
            this.StartMenuItem.Click += new System.EventHandler(this.StartSimulationClick);
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Enabled = false;
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(174, 22);
            this.PauseMenuItem.Text = "Pause";
            this.PauseMenuItem.Click += new System.EventHandler(this.StartSimulationClick);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(174, 22);
            this.StopMenuItem.Text = "Stop";
            this.StopMenuItem.Click += new System.EventHandler(this.StopSimulationClick);
            // 
            // FireAlarmMenuItem
            // 
            this.FireAlarmMenuItem.Name = "FireAlarmMenuItem";
            this.FireAlarmMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FireAlarmMenuItem.Text = "Fire alarm";
            this.FireAlarmMenuItem.Click += new System.EventHandler(this.FireAlarmClick);
            // 
            // SystemParametersMenuItem
            // 
            this.SystemParametersMenuItem.Name = "SystemParametersMenuItem";
            this.SystemParametersMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.HumanControllingMenuItem.Size = new System.Drawing.Size(120, 20);
            this.HumanControllingMenuItem.Text = "Human controlling";
            // 
            // CreateHumanMenuItem
            // 
            this.CreateHumanMenuItem.Name = "CreateHumanMenuItem";
            this.CreateHumanMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CreateHumanMenuItem.Text = "Create human";
            this.CreateHumanMenuItem.Click += new System.EventHandler(this.CreateHumanClick);
            // 
            // HumanGenerationMenuItem
            // 
            this.HumanGenerationMenuItem.Name = "HumanGenerationMenuItem";
            this.HumanGenerationMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HumanGenerationMenuItem.Text = "Human generation";
            this.HumanGenerationMenuItem.Click += new System.EventHandler(this.HumanGenerationClick);
            // 
            // HumanStatusMenuItem
            // 
            this.HumanStatusMenuItem.Name = "HumanStatusMenuItem";
            this.HumanStatusMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.ConfigurationMenuItem.Size = new System.Drawing.Size(93, 20);
            this.ConfigurationMenuItem.Text = "Configuration";
            // 
            // humanGenerationToolStripMenuItem1
            // 
            this.humanGenerationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.LoadMenuItem});
            this.humanGenerationToolStripMenuItem1.Name = "humanGenerationToolStripMenuItem1";
            this.humanGenerationToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.humanGenerationToolStripMenuItem1.Text = "Human generation";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveHumanGenerationClick);
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(100, 22);
            this.LoadMenuItem.Text = "Load";
            this.LoadMenuItem.Click += new System.EventHandler(this.LoadHumanGenerationClick);
            // 
            // liftConifurationsToolStripMenuItem
            // 
            this.liftConifurationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.liftConifurationsToolStripMenuItem.Name = "liftConifurationsToolStripMenuItem";
            this.liftConifurationsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.liftConifurationsToolStripMenuItem.Text = "Lift conifurations";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveLiftConfigurationClick);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.ShowShortcutKeys = false;
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.LoadLiftConfiguration);
            // 
            // StatisticMenuItem
            // 
            this.StatisticMenuItem.Enabled = false;
            this.StatisticMenuItem.Name = "StatisticMenuItem";
            this.StatisticMenuItem.Size = new System.Drawing.Size(174, 22);
            this.StatisticMenuItem.Text = "Show statistics";
            this.StatisticMenuItem.Click += new System.EventHandler(this.StatisticsClick);
            // 
            // PlanFireAlarmMenuItem
            // 
            this.PlanFireAlarmMenuItem.Name = "PlanFireAlarmMenuItem";
            this.PlanFireAlarmMenuItem.Size = new System.Drawing.Size(174, 22);
            this.PlanFireAlarmMenuItem.Text = "Plan fire alarm";
            this.PlanFireAlarmMenuItem.Click += new System.EventHandler(this.PlanFireAlarmClick);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimulationMenuItem,
            this.HumanControllingMenuItem,
            this.ConfigurationMenuItem,
            this.HelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(934, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // openGenerationFileDialog
            // 
            this.openGenerationFileDialog.FileName = "openFileDialog1";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 560);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.createHumanButton);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.SpeedSelecter);
            this.Controls.Add(this.fireAlarmButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.simulationTable);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 596);
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuLifts";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSelecter)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TimeStatusLabel;
        private System.Windows.Forms.OpenFileDialog openLiftFileDialog;
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SaveFileDialog saveLiftFileDialog;
        private System.Windows.Forms.OpenFileDialog openGenerationFileDialog;
        private System.Windows.Forms.SaveFileDialog saveGeneratedFileDialog;
    }
}

