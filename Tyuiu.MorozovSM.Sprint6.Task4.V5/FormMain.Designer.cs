namespace Tyuiu.MorozovSM.Sprint6.Task4.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelUP_MSM = new Panel();
            buttonHelp_MSM = new Button();
            buttonSave_MSM = new Button();
            buttonResult_MSM = new Button();
            groupBoxInput_MSM = new GroupBox();
            textBoxStopStepEnd_MSM = new TextBox();
            textBoxStartStepEnd_MSM = new TextBox();
            textBoxStopStepBegin_MSM = new TextBox();
            textBoxStartStepBegin_MSM = new TextBox();
            groupBoxTask_MSM = new GroupBox();
            pictureBoxTask_MSM = new PictureBox();
            textBoxTask_MSM = new TextBox();
            panelFill_MSM = new Panel();
            formsPlotOutput_MSM = new ScottPlot.WinForms.FormsPlot();
            panelLeft_MSM = new Panel();
            groupBoxOutput_MSM = new GroupBox();
            textBoxOutput_MSM = new TextBox();
            splitter1 = new Splitter();
            panelUP_MSM.SuspendLayout();
            groupBoxInput_MSM.SuspendLayout();
            groupBoxTask_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSM).BeginInit();
            panelFill_MSM.SuspendLayout();
            panelLeft_MSM.SuspendLayout();
            groupBoxOutput_MSM.SuspendLayout();
            SuspendLayout();
            // 
            // panelUP_MSM
            // 
            panelUP_MSM.Controls.Add(buttonHelp_MSM);
            panelUP_MSM.Controls.Add(buttonSave_MSM);
            panelUP_MSM.Controls.Add(buttonResult_MSM);
            panelUP_MSM.Controls.Add(groupBoxInput_MSM);
            panelUP_MSM.Controls.Add(groupBoxTask_MSM);
            panelUP_MSM.Dock = DockStyle.Top;
            panelUP_MSM.Location = new Point(0, 0);
            panelUP_MSM.Name = "panelUP_MSM";
            panelUP_MSM.Size = new Size(784, 100);
            panelUP_MSM.TabIndex = 0;
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_MSM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MSM.Location = new Point(682, 7);
            buttonHelp_MSM.Name = "buttonHelp_MSM";
            buttonHelp_MSM.Size = new Size(90, 90);
            buttonHelp_MSM.TabIndex = 2;
            buttonHelp_MSM.Text = "Справка";
            buttonHelp_MSM.UseVisualStyleBackColor = true;
            buttonHelp_MSM.Click += buttonHelp_MSM_Click;
            // 
            // buttonSave_MSM
            // 
            buttonSave_MSM.Location = new Point(586, 7);
            buttonSave_MSM.Name = "buttonSave_MSM";
            buttonSave_MSM.Size = new Size(90, 90);
            buttonSave_MSM.TabIndex = 2;
            buttonSave_MSM.Text = "Сохранить";
            buttonSave_MSM.UseVisualStyleBackColor = true;
            buttonSave_MSM.Click += buttonSave_MSM_Click;
            // 
            // buttonResult_MSM
            // 
            buttonResult_MSM.Location = new Point(490, 7);
            buttonResult_MSM.Name = "buttonResult_MSM";
            buttonResult_MSM.Size = new Size(90, 90);
            buttonResult_MSM.TabIndex = 2;
            buttonResult_MSM.Text = "Выполнить";
            buttonResult_MSM.UseVisualStyleBackColor = true;
            buttonResult_MSM.Click += buttonResult_MSM_Click;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_MSM.Controls.Add(textBoxStopStepEnd_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxStartStepEnd_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxStopStepBegin_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxStartStepBegin_MSM);
            groupBoxInput_MSM.Location = new Point(315, 0);
            groupBoxInput_MSM.Name = "groupBoxInput_MSM";
            groupBoxInput_MSM.Size = new Size(166, 100);
            groupBoxInput_MSM.TabIndex = 1;
            groupBoxInput_MSM.TabStop = false;
            groupBoxInput_MSM.Text = "Вывод данных:";
            // 
            // textBoxStopStepEnd_MSM
            // 
            textBoxStopStepEnd_MSM.Font = new Font("Segoe UI", 20F);
            textBoxStopStepEnd_MSM.Location = new Point(82, 44);
            textBoxStopStepEnd_MSM.Multiline = true;
            textBoxStopStepEnd_MSM.Name = "textBoxStopStepEnd_MSM";
            textBoxStopStepEnd_MSM.Size = new Size(70, 50);
            textBoxStopStepEnd_MSM.TabIndex = 0;
            textBoxStopStepEnd_MSM.KeyPress += textBoxStartStepEnd_MSM_KeyPress;
            // 
            // textBoxStartStepEnd_MSM
            // 
            textBoxStartStepEnd_MSM.Font = new Font("Segoe UI", 20F);
            textBoxStartStepEnd_MSM.Location = new Point(6, 44);
            textBoxStartStepEnd_MSM.Multiline = true;
            textBoxStartStepEnd_MSM.Name = "textBoxStartStepEnd_MSM";
            textBoxStartStepEnd_MSM.Size = new Size(70, 50);
            textBoxStartStepEnd_MSM.TabIndex = 0;
            textBoxStartStepEnd_MSM.KeyPress += textBoxStartStepEnd_MSM_KeyPress;
            // 
            // textBoxStopStepBegin_MSM
            // 
            textBoxStopStepBegin_MSM.BackColor = SystemColors.Control;
            textBoxStopStepBegin_MSM.BorderStyle = BorderStyle.None;
            textBoxStopStepBegin_MSM.Location = new Point(82, 22);
            textBoxStopStepBegin_MSM.Name = "textBoxStopStepBegin_MSM";
            textBoxStopStepBegin_MSM.Size = new Size(70, 16);
            textBoxStopStepBegin_MSM.TabIndex = 0;
            textBoxStopStepBegin_MSM.Text = "Конец шага:";
            // 
            // textBoxStartStepBegin_MSM
            // 
            textBoxStartStepBegin_MSM.BackColor = SystemColors.Control;
            textBoxStartStepBegin_MSM.BorderStyle = BorderStyle.None;
            textBoxStartStepBegin_MSM.Location = new Point(6, 22);
            textBoxStartStepBegin_MSM.Name = "textBoxStartStepBegin_MSM";
            textBoxStartStepBegin_MSM.Size = new Size(70, 16);
            textBoxStartStepBegin_MSM.TabIndex = 0;
            textBoxStartStepBegin_MSM.Text = "Старт шага:";
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(pictureBoxTask_MSM);
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Dock = DockStyle.Left;
            groupBoxTask_MSM.Location = new Point(0, 0);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(312, 100);
            groupBoxTask_MSM.TabIndex = 0;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // pictureBoxTask_MSM
            // 
            pictureBoxTask_MSM.BackColor = SystemColors.Window;
            pictureBoxTask_MSM.Image = (Image)resources.GetObject("pictureBoxTask_MSM.Image");
            pictureBoxTask_MSM.Location = new Point(3, 63);
            pictureBoxTask_MSM.Name = "pictureBoxTask_MSM";
            pictureBoxTask_MSM.Size = new Size(306, 34);
            pictureBoxTask_MSM.TabIndex = 1;
            pictureBoxTask_MSM.TabStop = false;
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Dock = DockStyle.Fill;
            textBoxTask_MSM.Location = new Point(3, 19);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.Size = new Size(306, 78);
            textBoxTask_MSM.TabIndex = 0;
            textBoxTask_MSM.Text = "Написать программу которая выводит таблицу значений функции f(x) на заданном диапазоне с шагом 1";
            // 
            // panelFill_MSM
            // 
            panelFill_MSM.Controls.Add(formsPlotOutput_MSM);
            panelFill_MSM.Dock = DockStyle.Fill;
            panelFill_MSM.Location = new Point(203, 100);
            panelFill_MSM.Name = "panelFill_MSM";
            panelFill_MSM.Size = new Size(581, 361);
            panelFill_MSM.TabIndex = 1;
            // 
            // formsPlotOutput_MSM
            // 
            formsPlotOutput_MSM.DisplayScale = 1F;
            formsPlotOutput_MSM.Dock = DockStyle.Fill;
            formsPlotOutput_MSM.Location = new Point(0, 0);
            formsPlotOutput_MSM.Name = "formsPlotOutput_MSM";
            formsPlotOutput_MSM.Size = new Size(581, 361);
            formsPlotOutput_MSM.TabIndex = 0;
            // 
            // panelLeft_MSM
            // 
            panelLeft_MSM.Controls.Add(groupBoxOutput_MSM);
            panelLeft_MSM.Dock = DockStyle.Left;
            panelLeft_MSM.Location = new Point(0, 100);
            panelLeft_MSM.Name = "panelLeft_MSM";
            panelLeft_MSM.Size = new Size(200, 361);
            panelLeft_MSM.TabIndex = 2;
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(textBoxOutput_MSM);
            groupBoxOutput_MSM.Dock = DockStyle.Left;
            groupBoxOutput_MSM.Location = new Point(0, 0);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(200, 361);
            groupBoxOutput_MSM.TabIndex = 0;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод:";
            // 
            // textBoxOutput_MSM
            // 
            textBoxOutput_MSM.Dock = DockStyle.Fill;
            textBoxOutput_MSM.Location = new Point(3, 19);
            textBoxOutput_MSM.Multiline = true;
            textBoxOutput_MSM.Name = "textBoxOutput_MSM";
            textBoxOutput_MSM.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MSM.Size = new Size(194, 339);
            textBoxOutput_MSM.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 361);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelFill_MSM);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_MSM);
            Controls.Add(panelUP_MSM);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelUP_MSM.ResumeLayout(false);
            groupBoxInput_MSM.ResumeLayout(false);
            groupBoxInput_MSM.PerformLayout();
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSM).EndInit();
            panelFill_MSM.ResumeLayout(false);
            panelLeft_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_MSM;
        private Panel panelFill_MSM;
        private Panel panelLeft_MSM;
        private Splitter splitter1;
        private GroupBox groupBoxTask_MSM;
        private GroupBox groupBoxInput_MSM;
        private TextBox textBoxTask_MSM;
        private GroupBox groupBoxOutput_MSM;
        private TextBox textBoxOutput_MSM;
        private Button buttonHelp_MSM;
        private Button buttonSave_MSM;
        private Button buttonResult_MSM;
        private TextBox textBoxStopStepEnd_MSM;
        private TextBox textBoxStartStepEnd_MSM;
        private TextBox textBoxStopStepBegin_MSM;
        private TextBox textBoxStartStepBegin_MSM;
        private ScottPlot.WinForms.FormsPlot formsPlotOutput_MSM;
        private PictureBox pictureBoxTask_MSM;
    }
}
