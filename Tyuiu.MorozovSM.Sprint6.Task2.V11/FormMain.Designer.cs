namespace Tyuiu.MorozovSM.Sprint6.Task2.V11
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
            groupBoxTask_MSM = new GroupBox();
            pictureBoxTask_MSM = new PictureBox();
            textBoxTask_MSM = new TextBox();
            groupBoxOutput_MSM = new GroupBox();
            dataGridViewOutput_MSM = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            formsPlotOutput_MSM = new ScottPlot.WinForms.FormsPlot();
            textBoxOutputBegin_MSM = new TextBox();
            groupBoxInput_MSM = new GroupBox();
            textBoxInputStartStepBegin_MSM = new TextBox();
            textBoxInputStopStepBegin_MSM = new TextBox();
            textBoxInputStopStepEnd_MSM = new TextBox();
            textBoxInputStartStepEnd_MSM = new TextBox();
            buttonResult_MSM = new Button();
            buttonHelp_MSM = new Button();
            groupBoxTask_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSM).BeginInit();
            groupBoxOutput_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).BeginInit();
            groupBoxInput_MSM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(pictureBoxTask_MSM);
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Location = new Point(12, 12);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(505, 340);
            groupBoxTask_MSM.TabIndex = 0;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // pictureBoxTask_MSM
            // 
            pictureBoxTask_MSM.BackColor = SystemColors.Window;
            pictureBoxTask_MSM.Image = (Image)resources.GetObject("pictureBoxTask_MSM.Image");
            pictureBoxTask_MSM.Location = new Point(179, 22);
            pictureBoxTask_MSM.Name = "pictureBoxTask_MSM";
            pictureBoxTask_MSM.Size = new Size(320, 37);
            pictureBoxTask_MSM.TabIndex = 0;
            pictureBoxTask_MSM.TabStop = false;
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Location = new Point(6, 22);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.ReadOnly = true;
            textBoxTask_MSM.Size = new Size(167, 312);
            textBoxTask_MSM.TabIndex = 1;
            textBoxTask_MSM.Text = "Написать программу которая выводит таблицу значений функции f(x) на заданном диапазоне с шагом 1";
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(dataGridViewOutput_MSM);
            groupBoxOutput_MSM.Controls.Add(formsPlotOutput_MSM);
            groupBoxOutput_MSM.Controls.Add(textBoxOutputBegin_MSM);
            groupBoxOutput_MSM.Location = new Point(523, 12);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(514, 426);
            groupBoxOutput_MSM.TabIndex = 1;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод данных";
            // 
            // dataGridViewOutput_MSM
            // 
            dataGridViewOutput_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MSM.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewOutput_MSM.Location = new Point(6, 44);
            dataGridViewOutput_MSM.Name = "dataGridViewOutput_MSM";
            dataGridViewOutput_MSM.RowHeadersVisible = false;
            dataGridViewOutput_MSM.Size = new Size(109, 376);
            dataGridViewOutput_MSM.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "x";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.Name = "F";
            F.Width = 50;
            // 
            // formsPlotOutput_MSM
            // 
            formsPlotOutput_MSM.DisplayScale = 1F;
            formsPlotOutput_MSM.Location = new Point(121, 44);
            formsPlotOutput_MSM.Name = "formsPlotOutput_MSM";
            formsPlotOutput_MSM.Size = new Size(387, 376);
            formsPlotOutput_MSM.TabIndex = 2;
            // 
            // textBoxOutputBegin_MSM
            // 
            textBoxOutputBegin_MSM.BackColor = SystemColors.Control;
            textBoxOutputBegin_MSM.BorderStyle = BorderStyle.None;
            textBoxOutputBegin_MSM.Location = new Point(6, 22);
            textBoxOutputBegin_MSM.Name = "textBoxOutputBegin_MSM";
            textBoxOutputBegin_MSM.ReadOnly = true;
            textBoxOutputBegin_MSM.Size = new Size(100, 16);
            textBoxOutputBegin_MSM.TabIndex = 0;
            textBoxOutputBegin_MSM.Text = "Результат:";
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_MSM.Controls.Add(textBoxInputStartStepBegin_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxInputStopStepBegin_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxInputStopStepEnd_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxInputStartStepEnd_MSM);
            groupBoxInput_MSM.Location = new Point(12, 363);
            groupBoxInput_MSM.Name = "groupBoxInput_MSM";
            groupBoxInput_MSM.Size = new Size(261, 75);
            groupBoxInput_MSM.TabIndex = 2;
            groupBoxInput_MSM.TabStop = false;
            groupBoxInput_MSM.Text = "Ввод данных";
            // 
            // textBoxInputStartStepBegin_MSM
            // 
            textBoxInputStartStepBegin_MSM.BorderStyle = BorderStyle.None;
            textBoxInputStartStepBegin_MSM.Location = new Point(6, 22);
            textBoxInputStartStepBegin_MSM.Name = "textBoxInputStartStepBegin_MSM";
            textBoxInputStartStepBegin_MSM.ReadOnly = true;
            textBoxInputStartStepBegin_MSM.Size = new Size(120, 16);
            textBoxInputStartStepBegin_MSM.TabIndex = 3;
            textBoxInputStartStepBegin_MSM.Text = "Старт шага:";
            // 
            // textBoxInputStopStepBegin_MSM
            // 
            textBoxInputStopStepBegin_MSM.BorderStyle = BorderStyle.None;
            textBoxInputStopStepBegin_MSM.Location = new Point(135, 22);
            textBoxInputStopStepBegin_MSM.Name = "textBoxInputStopStepBegin_MSM";
            textBoxInputStopStepBegin_MSM.ReadOnly = true;
            textBoxInputStopStepBegin_MSM.Size = new Size(120, 16);
            textBoxInputStopStepBegin_MSM.TabIndex = 2;
            textBoxInputStopStepBegin_MSM.Text = "Конец шага:";
            // 
            // textBoxInputStopStepEnd_MSM
            // 
            textBoxInputStopStepEnd_MSM.Location = new Point(132, 44);
            textBoxInputStopStepEnd_MSM.Name = "textBoxInputStopStepEnd_MSM";
            textBoxInputStopStepEnd_MSM.Size = new Size(120, 23);
            textBoxInputStopStepEnd_MSM.TabIndex = 1;
            textBoxInputStopStepEnd_MSM.KeyPress += textBoxInputStartStepEnd_MSM_KeyPress;
            // 
            // textBoxInputStartStepEnd_MSM
            // 
            textBoxInputStartStepEnd_MSM.Location = new Point(6, 44);
            textBoxInputStartStepEnd_MSM.Name = "textBoxInputStartStepEnd_MSM";
            textBoxInputStartStepEnd_MSM.Size = new Size(120, 23);
            textBoxInputStartStepEnd_MSM.TabIndex = 0;
            textBoxInputStartStepEnd_MSM.KeyPress += textBoxInputStartStepEnd_MSM_KeyPress;
            // 
            // buttonResult_MSM
            // 
            buttonResult_MSM.BackColor = SystemColors.ButtonFace;
            buttonResult_MSM.FlatStyle = FlatStyle.System;
            buttonResult_MSM.Font = new Font("Segoe UI", 10F);
            buttonResult_MSM.Location = new Point(360, 363);
            buttonResult_MSM.Name = "buttonResult_MSM";
            buttonResult_MSM.Size = new Size(157, 75);
            buttonResult_MSM.TabIndex = 3;
            buttonResult_MSM.Text = "Выполнить";
            buttonResult_MSM.UseVisualStyleBackColor = false;
            buttonResult_MSM.Click += buttonResult_MSM_Click;
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_MSM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MSM.Font = new Font("Segoe UI", 10F);
            buttonHelp_MSM.Location = new Point(279, 363);
            buttonHelp_MSM.Name = "buttonHelp_MSM";
            buttonHelp_MSM.Size = new Size(75, 75);
            buttonHelp_MSM.TabIndex = 4;
            buttonHelp_MSM.Text = "Справка";
            buttonHelp_MSM.UseVisualStyleBackColor = true;
            buttonHelp_MSM.Click += buttonHelp_MSM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(buttonResult_MSM);
            Controls.Add(groupBoxInput_MSM);
            Controls.Add(buttonHelp_MSM);
            Controls.Add(groupBoxOutput_MSM);
            Controls.Add(groupBoxTask_MSM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 11 | Морозов С. М.";
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSM).EndInit();
            groupBoxOutput_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).EndInit();
            groupBoxInput_MSM.ResumeLayout(false);
            groupBoxInput_MSM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSM;
        private GroupBox groupBoxOutput_MSM;
        private GroupBox groupBoxInput_MSM;
        private PictureBox pictureBoxTask_MSM;
        private TextBox textBoxTask_MSM;
        private TextBox textBoxOutputBegin_MSM;
        private TextBox textBoxInputStartStepBegin_MSM;
        private TextBox textBoxInputStopStepBegin_MSM;
        private TextBox textBoxInputStopStepEnd_MSM;
        private TextBox textBoxInputStartStepEnd_MSM;
        private Button buttonResult_MSM;
        private Button buttonHelp_MSM;
        private DataGridView dataGridViewOutput_MSM;
        private ScottPlot.WinForms.FormsPlot formsPlotOutput_MSM;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
