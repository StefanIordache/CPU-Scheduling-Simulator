using System.Drawing;

namespace CPU_Scheduling_Simulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelInput = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelAlgorithmSelector = new System.Windows.Forms.Panel();
            this.labelAlgorithmSelector = new System.Windows.Forms.Label();
            this.panelProcessesList = new System.Windows.Forms.Panel();
            this.labelProcessesList = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelAlgorithmSelector.SuspendLayout();
            this.panelProcessesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.button1);
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
            this.panelInput.Size = new System.Drawing.Size(301, 252);
            this.panelInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(81, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add to list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxArrivalTime
            // 
            this.textBoxArrivalTime.Location = new System.Drawing.Point(166, 101);
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
            this.textBoxDuration.Location = new System.Drawing.Point(166, 58);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(86, 22);
            this.textBoxDuration.TabIndex = 4;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalTime.Location = new System.Drawing.Point(3, 101);
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
            this.labelDuration.Location = new System.Drawing.Point(3, 58);
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
            this.panelAlgorithmSelector.Controls.Add(this.labelAlgorithm);
            this.panelAlgorithmSelector.Controls.Add(this.comboBoxAlgorithm);
            this.panelAlgorithmSelector.Controls.Add(this.labelAlgorithmSelector);
            this.panelAlgorithmSelector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAlgorithmSelector.Location = new System.Drawing.Point(330, 13);
            this.panelAlgorithmSelector.Name = "panelAlgorithmSelector";
            this.panelAlgorithmSelector.Size = new System.Drawing.Size(301, 252);
            this.panelAlgorithmSelector.TabIndex = 1;
            // 
            // labelAlgorithmSelector
            // 
            this.labelAlgorithmSelector.AutoSize = true;
            this.labelAlgorithmSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithmSelector.Location = new System.Drawing.Point(20, 0);
            this.labelAlgorithmSelector.Name = "labelAlgorithmSelector";
            this.labelAlgorithmSelector.Size = new System.Drawing.Size(266, 32);
            this.labelAlgorithmSelector.TabIndex = 0;
            this.labelAlgorithmSelector.Text = "Algorithm Selector";
            // 
            // panelProcessesList
            // 
            this.panelProcessesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcessesList.Controls.Add(this.labelProcessesList);
            this.panelProcessesList.Location = new System.Drawing.Point(12, 270);
            this.panelProcessesList.Name = "panelProcessesList";
            this.panelProcessesList.Size = new System.Drawing.Size(619, 375);
            this.panelProcessesList.TabIndex = 2;
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
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(139, 55);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(132, 24);
            this.comboBoxAlgorithm.TabIndex = 1;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.Location = new System.Drawing.Point(3, 55);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(103, 25);
            this.labelAlgorithm.TabIndex = 2;
            this.labelAlgorithm.Text = "Algorithm";
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
            this.panelProcessesList.ResumeLayout(false);
            this.panelProcessesList.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAlgorithmSelector;
        private System.Windows.Forms.Label labelAlgorithmSelector;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Panel panelProcessesList;
        private System.Windows.Forms.Label labelProcessesList;
    }
}

