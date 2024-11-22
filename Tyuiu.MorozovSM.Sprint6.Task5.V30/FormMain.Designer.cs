namespace Tyuiu.MorozovSM.Sprint6.Task5.V30
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
            panelUP_MSM = new Panel();
            buttonHelp_MSM = new Button();
            buttonOpen_MSM = new Button();
            buttonResult_MSM = new Button();
            groupBoxTask_MSM = new GroupBox();
            textBoxTask_MSM = new TextBox();
            panelFill_MSM = new Panel();
            formsPlotOutput_MSM = new ScottPlot.WinForms.FormsPlot();
            panelLeft_MSM = new Panel();
            groupBoxOutput_MSM = new GroupBox();
            dataGridViewOutput_MSM = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            splitter1 = new Splitter();
            panelUP_MSM.SuspendLayout();
            groupBoxTask_MSM.SuspendLayout();
            panelFill_MSM.SuspendLayout();
            panelLeft_MSM.SuspendLayout();
            groupBoxOutput_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).BeginInit();
            SuspendLayout();
            // 
            // panelUP_MSM
            // 
            panelUP_MSM.Controls.Add(buttonHelp_MSM);
            panelUP_MSM.Controls.Add(buttonOpen_MSM);
            panelUP_MSM.Controls.Add(buttonResult_MSM);
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
            // buttonOpen_MSM
            // 
            buttonOpen_MSM.Location = new Point(586, 7);
            buttonOpen_MSM.Name = "buttonOpen_MSM";
            buttonOpen_MSM.Size = new Size(90, 90);
            buttonOpen_MSM.TabIndex = 2;
            buttonOpen_MSM.Text = "Открыть файл";
            buttonOpen_MSM.UseVisualStyleBackColor = true;
            buttonOpen_MSM.Click += buttonOpen_MSM_Click;
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
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Dock = DockStyle.Left;
            groupBoxTask_MSM.Location = new Point(0, 0);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(484, 100);
            groupBoxTask_MSM.TabIndex = 0;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Dock = DockStyle.Fill;
            textBoxTask_MSM.Location = new Point(3, 19);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.Size = new Size(478, 78);
            textBoxTask_MSM.TabIndex = 0;
            textBoxTask_MSM.Text = "Прочитать данные из файла InPutFileTask5V30.txt. Вывести все числа от 2 до 7. Построить диаграмму по этим значениям. У вещественных значений округлить до трёх знаков после запятой.";
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
            groupBoxOutput_MSM.Controls.Add(dataGridViewOutput_MSM);
            groupBoxOutput_MSM.Dock = DockStyle.Left;
            groupBoxOutput_MSM.Location = new Point(0, 0);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(200, 361);
            groupBoxOutput_MSM.TabIndex = 0;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод:";
            // 
            // dataGridViewOutput_MSM
            // 
            dataGridViewOutput_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MSM.ColumnHeadersVisible = false;
            dataGridViewOutput_MSM.Columns.AddRange(new DataGridViewColumn[] { Index, Value });
            dataGridViewOutput_MSM.Dock = DockStyle.Fill;
            dataGridViewOutput_MSM.Location = new Point(3, 19);
            dataGridViewOutput_MSM.Name = "dataGridViewOutput_MSM";
            dataGridViewOutput_MSM.RowHeadersVisible = false;
            dataGridViewOutput_MSM.Size = new Size(194, 339);
            dataGridViewOutput_MSM.TabIndex = 0;
            // 
            // Index
            // 
            Index.HeaderText = "";
            Index.Name = "Index";
            Index.ReadOnly = true;
            // 
            // Value
            // 
            Value.HeaderText = "";
            Value.Name = "Value";
            Value.ReadOnly = true;
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
            Text = "Спринт 6 | Таск 5 | Вариант 30 | Морозов С. М.";
            panelUP_MSM.ResumeLayout(false);
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            panelFill_MSM.ResumeLayout(false);
            panelLeft_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_MSM;
        private Panel panelFill_MSM;
        private Panel panelLeft_MSM;
        private Splitter splitter1;
        private GroupBox groupBoxTask_MSM;
        private TextBox textBoxTask_MSM;
        private GroupBox groupBoxOutput_MSM;
        private Button buttonHelp_MSM;
        private Button buttonOpen_MSM;
        private Button buttonResult_MSM;
        private ScottPlot.WinForms.FormsPlot formsPlotOutput_MSM;
        private DataGridView dataGridViewOutput_MSM;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Value;
    }
}
