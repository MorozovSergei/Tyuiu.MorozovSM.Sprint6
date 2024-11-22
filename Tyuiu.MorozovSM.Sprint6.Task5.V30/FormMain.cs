using Tyuiu.MorozovSM.Sprint6.Task5.V30.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        string path = @"C:\Users\necar\Downloads\InPutDataFileTask5V30.txt";
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            var array = ds.LoadFromDataFile(path);
            formsPlotOutput_MSM.Plot.Clear();
            this.dataGridViewOutput_MSM.Rows.Clear();
            for (int i = 0; i < array.Length; i++) 
            {
                this.dataGridViewOutput_MSM.Rows.Add(i+1,array[i]);
            }
            formsPlotOutput_MSM.Plot.Add.Bars(array);
            formsPlotOutput_MSM.Refresh();
        }

        private void buttonOpen_MSM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-24-1 Морозов Сергей Максимович", "Справка");
        }
    }
}
