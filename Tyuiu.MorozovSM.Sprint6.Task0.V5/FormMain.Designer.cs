namespace Tyuiu.MorozovSM.Sprint6.Task0.V5
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
            buttonHelp_MSM = new Button();
            buttonResult_MSM = new Button();
            groupBoxTask_MSM = new GroupBox();
            textBoxTask_MSM = new TextBox();
            pictureBoxFarmula_MSM = new PictureBox();
            groupBoxInput_MSM = new GroupBox();
            textBoxInputEnd_MSM = new TextBox();
            textBoxInputStart_MSM = new TextBox();
            groupBoxOutput_MSM = new GroupBox();
            textBoxOutputEnd_MSM = new TextBox();
            textBoxOutpunStart_MSM = new TextBox();
            groupBoxTask_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_MSM).BeginInit();
            groupBoxInput_MSM.SuspendLayout();
            groupBoxOutput_MSM.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_MSM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MSM.Font = new Font("Segoe UI", 14F);
            buttonHelp_MSM.Location = new Point(574, 390);
            buttonHelp_MSM.Name = "buttonHelp_MSM";
            buttonHelp_MSM.Size = new Size(50, 50);
            buttonHelp_MSM.TabIndex = 0;
            buttonHelp_MSM.Text = "?";
            buttonHelp_MSM.UseVisualStyleBackColor = true;
            buttonHelp_MSM.Click += buttonHelp_MSM_Click;
            // 
            // buttonResult_MSM
            // 
            buttonResult_MSM.BackColor = SystemColors.Control;
            buttonResult_MSM.Location = new Point(630, 390);
            buttonResult_MSM.Name = "buttonResult_MSM";
            buttonResult_MSM.Size = new Size(158, 48);
            buttonResult_MSM.TabIndex = 1;
            buttonResult_MSM.Text = "Выполнить";
            buttonResult_MSM.UseVisualStyleBackColor = false;
            buttonResult_MSM.Click += buttonResult_MSM_Click;
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Controls.Add(pictureBoxFarmula_MSM);
            groupBoxTask_MSM.Location = new Point(12, 12);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(776, 263);
            groupBoxTask_MSM.TabIndex = 2;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Location = new Point(6, 22);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.ReadOnly = true;
            textBoxTask_MSM.Size = new Size(461, 235);
            textBoxTask_MSM.TabIndex = 1;
            textBoxTask_MSM.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_MSM
            // 
            pictureBoxFarmula_MSM.BackColor = SystemColors.Window;
            pictureBoxFarmula_MSM.Image = (Image)resources.GetObject("pictureBoxFarmula_MSM.Image");
            pictureBoxFarmula_MSM.Location = new Point(473, 22);
            pictureBoxFarmula_MSM.Name = "pictureBoxFarmula_MSM";
            pictureBoxFarmula_MSM.Size = new Size(297, 39);
            pictureBoxFarmula_MSM.TabIndex = 0;
            pictureBoxFarmula_MSM.TabStop = false;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_MSM.Controls.Add(textBoxInputEnd_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxInputStart_MSM);
            groupBoxInput_MSM.Location = new Point(12, 281);
            groupBoxInput_MSM.Name = "groupBoxInput_MSM";
            groupBoxInput_MSM.Size = new Size(558, 95);
            groupBoxInput_MSM.TabIndex = 3;
            groupBoxInput_MSM.TabStop = false;
            groupBoxInput_MSM.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_MSM
            // 
            textBoxInputEnd_MSM.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_MSM.Location = new Point(6, 51);
            textBoxInputEnd_MSM.Name = "textBoxInputEnd_MSM";
            textBoxInputEnd_MSM.Size = new Size(546, 36);
            textBoxInputEnd_MSM.TabIndex = 1;
            textBoxInputEnd_MSM.KeyPress += textBoxInputEnd_MSM_KeyPress;
            // 
            // textBoxInputStart_MSM
            // 
            textBoxInputStart_MSM.BackColor = SystemColors.Control;
            textBoxInputStart_MSM.BorderStyle = BorderStyle.None;
            textBoxInputStart_MSM.Location = new Point(6, 29);
            textBoxInputStart_MSM.Name = "textBoxInputStart_MSM";
            textBoxInputStart_MSM.ReadOnly = true;
            textBoxInputStart_MSM.Size = new Size(100, 16);
            textBoxInputStart_MSM.TabIndex = 0;
            textBoxInputStart_MSM.Text = "Переменная X:";
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(textBoxOutputEnd_MSM);
            groupBoxOutput_MSM.Controls.Add(textBoxOutpunStart_MSM);
            groupBoxOutput_MSM.Location = new Point(576, 281);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(212, 95);
            groupBoxOutput_MSM.TabIndex = 4;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_MSM
            // 
            textBoxOutputEnd_MSM.Font = new Font("Segoe UI", 16F);
            textBoxOutputEnd_MSM.Location = new Point(6, 51);
            textBoxOutputEnd_MSM.Name = "textBoxOutputEnd_MSM";
            textBoxOutputEnd_MSM.ReadOnly = true;
            textBoxOutputEnd_MSM.Size = new Size(182, 36);
            textBoxOutputEnd_MSM.TabIndex = 1;
            // 
            // textBoxOutpunStart_MSM
            // 
            textBoxOutpunStart_MSM.BackColor = SystemColors.Control;
            textBoxOutpunStart_MSM.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_MSM.Location = new Point(6, 29);
            textBoxOutpunStart_MSM.Multiline = true;
            textBoxOutpunStart_MSM.Name = "textBoxOutpunStart_MSM";
            textBoxOutpunStart_MSM.ReadOnly = true;
            textBoxOutpunStart_MSM.Size = new Size(100, 16);
            textBoxOutpunStart_MSM.TabIndex = 0;
            textBoxOutpunStart_MSM.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_MSM);
            Controls.Add(groupBoxInput_MSM);
            Controls.Add(groupBoxTask_MSM);
            Controls.Add(buttonResult_MSM);
            Controls.Add(buttonHelp_MSM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 | Морозов С. М.";
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_MSM).EndInit();
            groupBoxInput_MSM.ResumeLayout(false);
            groupBoxInput_MSM.PerformLayout();
            groupBoxOutput_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_MSM;
        private Button buttonResult_MSM;
        private GroupBox groupBoxTask_MSM;
        private TextBox textBoxTask_MSM;
        private PictureBox pictureBoxFarmula_MSM;
        private GroupBox groupBoxInput_MSM;
        private TextBox textBoxInputEnd_MSM;
        private TextBox textBoxInputStart_MSM;
        private GroupBox groupBoxOutput_MSM;
        private TextBox textBoxOutputEnd_MSM;
        private TextBox textBoxOutpunStart_MSM;
    }
}