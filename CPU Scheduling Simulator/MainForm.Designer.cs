using System.Drawing;

namespace CPU_Scheduling_Simulator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelIOTime = new System.Windows.Forms.Label();
            this.labelBurstTime = new System.Windows.Forms.Label();
            this.textBoxBurstTime = new System.Windows.Forms.TextBox();
            this.textBoxIOTime = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelAlgorithmSelector = new System.Windows.Forms.Panel();
            this.buttonStartSimulation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRR = new System.Windows.Forms.RadioButton();
            this.radioButtonSJF = new System.Windows.Forms.RadioButton();
            this.radioButtonFCFS = new System.Windows.Forms.RadioButton();
            this.labelAlgorithmSelector = new System.Windows.Forms.Label();
            this.panelProcessesList = new System.Windows.Forms.Panel();
            this.dataGridViewProcessesList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelProcessesList = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelAlgorithmSelector.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelProcessesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.labelIOTime);
            this.panelInput.Controls.Add(this.labelBurstTime);
            this.panelInput.Controls.Add(this.textBoxBurstTime);
            this.panelInput.Controls.Add(this.textBoxIOTime);
            this.panelInput.Controls.Add(this.buttonInput);
            this.panelInput.Controls.Add(this.textBoxArrivalTime);
            this.panelInput.Controls.Add(this.textBoxPriority);
            this.panelInput.Controls.Add(this.textBoxDuration);
            this.panelInput.Controls.Add(this.labelArrivalTime);
            this.panelInput.Controls.Add(this.labelPriority);
            this.panelInput.Controls.Add(this.labelDuration);
            this.panelInput.Controls.Add(this.labelInput);
            this.panelInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInput.Location = new System.Drawing.Point(12, 12);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(301, 341);
            this.panelInput.TabIndex = 0;
            // 
            // labelIOTime
            // 
            this.labelIOTime.AutoSize = true;
            this.labelIOTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIOTime.Location = new System.Drawing.Point(3, 242);
            this.labelIOTime.Name = "labelIOTime";
            this.labelIOTime.Size = new System.Drawing.Size(96, 25);
            this.labelIOTime.TabIndex = 11;
            this.labelIOTime.Text = "I/O Time";
            this.labelIOTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBurstTime
            // 
            this.labelBurstTime.AutoSize = true;
            this.labelBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBurstTime.Location = new System.Drawing.Point(3, 210);
            this.labelBurstTime.Name = "labelBurstTime";
            this.labelBurstTime.Size = new System.Drawing.Size(116, 25);
            this.labelBurstTime.TabIndex = 10;
            this.labelBurstTime.Text = "Burst Time";
            this.labelBurstTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBurstTime
            // 
            this.textBoxBurstTime.Location = new System.Drawing.Point(166, 214);
            this.textBoxBurstTime.Name = "textBoxBurstTime";
            this.textBoxBurstTime.Size = new System.Drawing.Size(86, 22);
            this.textBoxBurstTime.TabIndex = 9;
            // 
            // textBoxIOTime
            // 
            this.textBoxIOTime.Location = new System.Drawing.Point(166, 242);
            this.textBoxIOTime.Name = "textBoxIOTime";
            this.textBoxIOTime.Size = new System.Drawing.Size(86, 22);
            this.textBoxIOTime.TabIndex = 8;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInput.Location = new System.Drawing.Point(84, 302);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(119, 34);
            this.buttonInput.TabIndex = 7;
            this.buttonInput.Text = "Add to list";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxArrivalTime
            // 
            this.textBoxArrivalTime.Location = new System.Drawing.Point(166, 75);
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(86, 22);
            this.textBoxArrivalTime.TabIndex = 6;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(166, 143);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(86, 22);
            this.textBoxPriority.TabIndex = 5;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(166, 108);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(86, 22);
            this.textBoxDuration.TabIndex = 4;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalTime.Location = new System.Drawing.Point(3, 75);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(128, 25);
            this.labelArrivalTime.TabIndex = 3;
            this.labelArrivalTime.Text = "Arrival Time";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.Location = new System.Drawing.Point(3, 143);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(79, 25);
            this.labelPriority.TabIndex = 2;
            this.labelPriority.Text = "Priority";
            this.labelPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(3, 108);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(93, 25);
            this.labelDuration.TabIndex = 1;
            this.labelDuration.Text = "Duration";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(96, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(83, 32);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // panelAlgorithmSelector
            // 
            this.panelAlgorithmSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlgorithmSelector.Controls.Add(this.buttonStartSimulation);
            this.panelAlgorithmSelector.Controls.Add(this.groupBox1);
            this.panelAlgorithmSelector.Controls.Add(this.labelAlgorithmSelector);
            this.panelAlgorithmSelector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAlgorithmSelector.Location = new System.Drawing.Point(319, 13);
            this.panelAlgorithmSelector.Name = "panelAlgorithmSelector";
            this.panelAlgorithmSelector.Size = new System.Drawing.Size(312, 340);
            this.panelAlgorithmSelector.TabIndex = 1;
            // 
            // buttonStartSimulation
            // 
            this.buttonStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSimulation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStartSimulation.Location = new System.Drawing.Point(56, 301);
            this.buttonStartSimulation.Name = "buttonStartSimulation";
            this.buttonStartSimulation.Size = new System.Drawing.Size(205, 34);
            this.buttonStartSimulation.TabIndex = 8;
            this.buttonStartSimulation.Text = "Start Simulation";
            this.buttonStartSimulation.UseVisualStyleBackColor = true;
            this.buttonStartSimulation.Click += new System.EventHandler(this.buttonStartSimulation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRR);
            this.groupBox1.Controls.Add(this.radioButtonSJF);
            this.groupBox1.Controls.Add(this.radioButtonFCFS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select one algorithm:";
            // 
            // radioButtonRR
            // 
            this.radioButtonRR.AutoSize = true;
            this.radioButtonRR.Location = new System.Drawing.Point(7, 78);
            this.radioButtonRR.Name = "radioButtonRR";
            this.radioButtonRR.Size = new System.Drawing.Size(49, 21);
            this.radioButtonRR.TabIndex = 2;
            this.radioButtonRR.TabStop = true;
            this.radioButtonRR.Text = "RR";
            this.radioButtonRR.UseVisualStyleBackColor = true;
            // 
            // radioButtonSJF
            // 
            this.radioButtonSJF.AutoSize = true;
            this.radioButtonSJF.Location = new System.Drawing.Point(7, 50);
            this.radioButtonSJF.Name = "radioButtonSJF";
            this.radioButtonSJF.Size = new System.Drawing.Size(53, 21);
            this.radioButtonSJF.TabIndex = 1;
            this.radioButtonSJF.TabStop = true;
            this.radioButtonSJF.Text = "SJF";
            this.radioButtonSJF.UseVisualStyleBackColor = true;
            // 
            // radioButtonFCFS
            // 
            this.radioButtonFCFS.AutoSize = true;
            this.radioButtonFCFS.Location = new System.Drawing.Point(7, 22);
            this.radioButtonFCFS.Name = "radioButtonFCFS";
            this.radioButtonFCFS.Size = new System.Drawing.Size(63, 21);
            this.radioButtonFCFS.TabIndex = 0;
            this.radioButtonFCFS.TabStop = true;
            this.radioButtonFCFS.Text = "FCFS";
            this.radioButtonFCFS.UseVisualStyleBackColor = true;
            // 
            // labelAlgorithmSelector
            // 
            this.labelAlgorithmSelector.AutoSize = true;
            this.labelAlgorithmSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithmSelector.Location = new System.Drawing.Point(26, 0);
            this.labelAlgorithmSelector.Name = "labelAlgorithmSelector";
            this.labelAlgorithmSelector.Size = new System.Drawing.Size(266, 32);
            this.labelAlgorithmSelector.TabIndex = 0;
            this.labelAlgorithmSelector.Text = "Algorithm Selector";
            // 
            // panelProcessesList
            // 
            this.panelProcessesList.AutoScroll = true;
            this.panelProcessesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcessesList.Controls.Add(this.dataGridViewProcessesList);
            this.panelProcessesList.Controls.Add(this.labelProcessesList);
            this.panelProcessesList.Location = new System.Drawing.Point(12, 359);
            this.panelProcessesList.Name = "panelProcessesList";
            this.panelProcessesList.Size = new System.Drawing.Size(619, 415);
            this.panelProcessesList.TabIndex = 2;
            // 
            // dataGridViewProcessesList
            // 
            this.dataGridViewProcessesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Duration,
            this.Arrival,
            this.Priority,
            this.Burst,
            this.InputOutput,
            this.Delete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcessesList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcessesList.Location = new System.Drawing.Point(19, 35);
            this.dataGridViewProcessesList.Name = "dataGridViewProcessesList";
            this.dataGridViewProcessesList.RowTemplate.Height = 24;
            this.dataGridViewProcessesList.Size = new System.Drawing.Size(580, 356);
            this.dataGridViewProcessesList.TabIndex = 2;
            this.dataGridViewProcessesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessesList_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.Width = 60;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 50;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.Width = 50;
            // 
            // Burst
            // 
            this.Burst.HeaderText = "Burst";
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            this.Burst.Width = 60;
            // 
            // InputOutput
            // 
            this.InputOutput.HeaderText = "I/O";
            this.InputOutput.Name = "InputOutput";
            this.InputOutput.ReadOnly = true;
            this.InputOutput.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "On delete processes Ids will be reordered.";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // labelProcessesList
            // 
            this.labelProcessesList.AutoSize = true;
            this.labelProcessesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessesList.Location = new System.Drawing.Point(197, 0);
            this.labelProcessesList.Name = "labelProcessesList";
            this.labelProcessesList.Size = new System.Drawing.Size(213, 32);
            this.labelProcessesList.TabIndex = 1;
            this.labelProcessesList.Text = "Processes List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 897);
            this.Controls.Add(this.panelProcessesList);
            this.Controls.Add(this.panelAlgorithmSelector);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CPU Scheduling SImulator";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelAlgorithmSelector.ResumeLayout(false);
            this.panelAlgorithmSelector.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProcessesList.ResumeLayout(false);
            this.panelProcessesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Panel panelAlgorithmSelector;
        private System.Windows.Forms.Label labelAlgorithmSelector;
        private System.Windows.Forms.Panel panelProcessesList;
        private System.Windows.Forms.Label labelProcessesList;
        private System.Windows.Forms.DataGridView dataGridViewProcessesList;
        private System.Windows.Forms.Label labelIOTime;
        private System.Windows.Forms.Label labelBurstTime;
        private System.Windows.Forms.TextBox textBoxBurstTime;
        private System.Windows.Forms.TextBox textBoxIOTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Burst;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputOutput;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRR;
        private System.Windows.Forms.RadioButton radioButtonSJF;
        private System.Windows.Forms.RadioButton radioButtonFCFS;
        private System.Windows.Forms.Button buttonStartSimulation;
    }
}

