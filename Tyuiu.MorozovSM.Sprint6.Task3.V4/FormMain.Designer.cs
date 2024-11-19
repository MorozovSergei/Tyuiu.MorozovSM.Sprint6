namespace Tyuiu.MorozovSM.Sprint6.Task3.V4
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
            dataGridViewTask_MSM = new DataGridView();
            textBoxTask_MSM = new TextBox();
            groupBoxOutput_MSM = new GroupBox();
            dataGridViewOutput_MSM = new DataGridView();
            textBoxOutput_MSM = new TextBox();
            buttonResult_MSM = new Button();
            buttonHelp_MSM = new Button();
            groupBoxTask_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_MSM).BeginInit();
            groupBoxOutput_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(dataGridViewTask_MSM);
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Location = new Point(12, 12);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(519, 426);
            groupBoxTask_MSM.TabIndex = 0;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // dataGridViewTask_MSM
            // 
            dataGridViewTask_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_MSM.ColumnHeadersVisible = false;
            dataGridViewTask_MSM.Location = new Point(273, 44);
            dataGridViewTask_MSM.Name = "dataGridViewTask_MSM";
            dataGridViewTask_MSM.ReadOnly = true;
            dataGridViewTask_MSM.RowHeadersVisible = false;
            dataGridViewTask_MSM.Size = new Size(240, 240);
            dataGridViewTask_MSM.TabIndex = 2;
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Location = new Point(6, 22);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.ReadOnly = true;
            textBoxTask_MSM.Size = new Size(223, 312);
            textBoxTask_MSM.TabIndex = 1;
            textBoxTask_MSM.Text = resources.GetString("textBoxTask_MSM.Text");
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(dataGridViewOutput_MSM);
            groupBoxOutput_MSM.Controls.Add(textBoxOutput_MSM);
            groupBoxOutput_MSM.Location = new Point(537, 12);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(251, 340);
            groupBoxOutput_MSM.TabIndex = 1;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод данных";
            // 
            // dataGridViewOutput_MSM
            // 
            dataGridViewOutput_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MSM.ColumnHeadersVisible = false;
            dataGridViewOutput_MSM.Location = new Point(6, 44);
            dataGridViewOutput_MSM.Name = "dataGridViewOutput_MSM";
            dataGridViewOutput_MSM.ReadOnly = true;
            dataGridViewOutput_MSM.RowHeadersVisible = false;
            dataGridViewOutput_MSM.Size = new Size(240, 240);
            dataGridViewOutput_MSM.TabIndex = 1;
            // 
            // textBoxOutput_MSM
            // 
            textBoxOutput_MSM.BackColor = SystemColors.Control;
            textBoxOutput_MSM.BorderStyle = BorderStyle.None;
            textBoxOutput_MSM.Location = new Point(6, 22);
            textBoxOutput_MSM.Name = "textBoxOutput_MSM";
            textBoxOutput_MSM.ReadOnly = true;
            textBoxOutput_MSM.Size = new Size(100, 16);
            textBoxOutput_MSM.TabIndex = 0;
            textBoxOutput_MSM.Text = "Результат:";
            // 
            // buttonResult_MSM
            // 
            buttonResult_MSM.BackColor = SystemColors.ButtonFace;
            buttonResult_MSM.FlatStyle = FlatStyle.System;
            buttonResult_MSM.Font = new Font("Segoe UI", 10F);
            buttonResult_MSM.Location = new Point(631, 363);
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
            buttonHelp_MSM.Location = new Point(537, 363);
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
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult_MSM);
            Controls.Add(buttonHelp_MSM);
            Controls.Add(groupBoxOutput_MSM);
            Controls.Add(groupBoxTask_MSM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Морозов С. М.";
            Load += FormMain_Load;
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_MSM).EndInit();
            groupBoxOutput_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSM;
        private GroupBox groupBoxOutput_MSM;
        private TextBox textBoxTask_MSM;
        private TextBox textBoxOutput_MSM;
        private Button buttonResult_MSM;
        private Button buttonHelp_MSM;
        private DataGridView dataGridViewTask_MSM;
        private DataGridView dataGridViewOutput_MSM;
    }
}
