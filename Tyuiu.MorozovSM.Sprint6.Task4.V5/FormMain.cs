using Tyuiu.MorozovSM.Sprint6.Task4.V5.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        double[] array;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Морозов Сергей Максимович", "Справка");
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStepEnd_MSM.Text);
                int stopValue = Convert.ToInt32(textBoxStopStepEnd_MSM.Text);
                int len = stopValue - startValue + 1;
                array = ds.GetMassFunction(startValue, stopValue);
                textBoxOutput_MSM.Text = "";
                foreach (double i in array)
                {
                    textBoxOutput_MSM.AppendText(i + Environment.NewLine);
                }
                double[] ListX = new double[len];
                double[] ListY = new double[len];
                for (int i = 0; i < len; i++)
                {
                    ListX[i] = startValue++;
                    ListY[i] = array[i];
                }
                formsPlotOutput_MSM.Plot.Clear();
                formsPlotOutput_MSM.Plot.Add.Scatter(ListX, ListY);
                formsPlotOutput_MSM.Plot.Title("График функции");
                formsPlotOutput_MSM.Plot.XLabel("Ось X");
                formsPlotOutput_MSM.Plot.YLabel("Ось Y");
                formsPlotOutput_MSM.Refresh();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStepEnd_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != '-') e.Handled = true;
        }

        private void buttonSave_MSM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V5.txt");
                if (File.Exists(path)) File.Delete(path);
                File.WriteAllText(path,textBoxOutput_MSM.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!" + Environment.NewLine + "Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch 
            { 
                MessageBox.Show("Сбой при сохранении файла","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
