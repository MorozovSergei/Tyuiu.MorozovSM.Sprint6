using Tyuiu.MorozovSM.Sprint6.Task3.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] mat = { { -14, -7, 18, 12, -20 }, { -2, -15, -19, -19, -3 }, { -18, -5, -10, 14, -17 }, { -1, 2, -10, 0, 11 }, { 6, -18, 0, 19, 16 } };
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Морозов Сергей Максимович", "Справка");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mat.GetLength(0);
            int colums = mat.GetLength(1);
            dataGridViewTask_MSM.RowCount = rows;
            dataGridViewTask_MSM.ColumnCount = colums;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewTask_MSM.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++) for (int j = 0; j < colums; j++) dataGridViewTask_MSM.Rows[i].Cells[j].Value = Convert.ToString(mat[i, j]);
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            mat = ds.Calculate(mat);
            dataGridViewOutput_MSM.ClearSelection();
            int rows = mat.GetLength(0);
            int colums = mat.GetLength(1);
            dataGridViewOutput_MSM.RowCount = rows;
            dataGridViewOutput_MSM.ColumnCount = colums;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewOutput_MSM.Columns[i].Width = 25;
            }
            
            for (int i = 0; i < rows; i++) for (int j = 0; j < colums; j++) dataGridViewOutput_MSM.Rows[i].Cells[j].Value = Convert.ToString(mat[i, j]);
        }
    }
}
