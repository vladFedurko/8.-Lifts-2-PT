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
            ((System.ComponentModel.ISupportInitialize)(this.speedSelecter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationTable
            // 
            this.simulationTable.AutoSize = true;
            this.simulationTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.simulationTable.ColumnCount = 4;
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.simulationTable.Location = new System.Drawing.Point(101, 41);
            this.simulationTable.Margin = new System.Windows.Forms.Padding(2);
            this.simulationTable.Name = "simulationTable";
            this.simulationTable.RowCount = 6;
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.simulationTable.Size = new System.Drawing.Size(561, 370);
            this.simulationTable.TabIndex = 0;
            this.simulationTable.Paint += new System.Windows.Forms.PaintEventHandler(this.SimulationTable_Paint);
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
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
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
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // fireAlarmButton
            // 
            this.fireAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fireAlarmButton.Location = new System.Drawing.Point(10, 372);
            this.fireAlarmButton.Margin = new System.Windows.Forms.Padding(2);
            this.fireAlarmButton.Name = "fireAlarmButton";
            this.fireAlarmButton.Size = new System.Drawing.Size(84, 39);
            this.fireAlarmButton.TabIndex = 3;
            this.fireAlarmButton.Text = "Fire alarm";
            this.fireAlarmButton.UseVisualStyleBackColor = true;
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
            this.speedSelecter.Location = new System.Drawing.Point(10, 202);
            this.speedSelecter.Margin = new System.Windows.Forms.Padding(2);
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
            this.speedSelecter.Size = new System.Drawing.Size(76, 21);
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
            this.createHumanButton.Size = new System.Drawing.Size(84, 46);
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
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // fireAlarmToolStripMenuItem
            // 
            this.fireAlarmToolStripMenuItem.Name = "fireAlarmToolStripMenuItem";
            this.fireAlarmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fireAlarmToolStripMenuItem.Text = "Fire alarm";
            this.fireAlarmToolStripMenuItem.Click += new System.EventHandler(this.FireAlarmButton_Click);
            // 
            // systemParametersToolStripMenuItem1
            // 
            this.systemParametersToolStripMenuItem1.Name = "systemParametersToolStripMenuItem1";
            this.systemParametersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.systemParametersToolStripMenuItem1.Text = "System parameters";
            // 
            // humanControllingToolStripMenuItem
            // 
            this.humanControllingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHumanToolStripMenuItem,
            this.humanGenerationToolStripMenuItem,
            this.humanStatusToolStripMenuItem});
            this.humanControllingToolStripMenuItem.Name = "humanControllingToolStripMenuItem";
            this.humanControllingToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.humanControllingToolStripMenuItem.Text = "Human controlling";
            // 
            // createHumanToolStripMenuItem
            // 
            this.createHumanToolStripMenuItem.Name = "createHumanToolStripMenuItem";
            this.createHumanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createHumanToolStripMenuItem.Text = "Create human";
            this.createHumanToolStripMenuItem.Click += new System.EventHandler(this.CreateHumanButton_Click);
            // 
            // humanGenerationToolStripMenuItem
            // 
            this.humanGenerationToolStripMenuItem.Name = "humanGenerationToolStripMenuItem";
            this.humanGenerationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.humanGenerationToolStripMenuItem.Text = "Human generation";
            this.humanGenerationToolStripMenuItem.Click += new System.EventHandler(this.humanGenerationToolStripMenuItem_Click);
            // 
            // humanStatusToolStripMenuItem
            // 
            this.humanStatusToolStripMenuItem.Name = "humanStatusToolStripMenuItem";
            this.humanStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // humanGenerationToolStripMenuItem1
            // 
            this.humanGenerationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.humanGenerationToolStripMenuItem1.Name = "humanGenerationToolStripMenuItem1";
            this.humanGenerationToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.humanGenerationToolStripMenuItem1.Text = "Human generation";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
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
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.statisticToolStripMenuItem.Text = "Export statistics";
            // 
            // planFireAlarmToolStripMenuItem
            // 
            this.planFireAlarmToolStripMenuItem.Name = "planFireAlarmToolStripMenuItem";
            this.planFireAlarmToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.planFireAlarmToolStripMenuItem.Text = "Plan fire alarm";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 449);
            this.Controls.Add(this.createHumanButton);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.speedSelecter);
            this.Controls.Add(this.fireAlarmButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.simulationTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SimulationForm";
            this.Text = "SimuLifts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedSelecter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

