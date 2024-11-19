using Tyuiu.MorozovSM.Sprint6.Task2.V11.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxInputStartStepEnd_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != '-') e.Handled = true;
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Морозов Сергей Максимович", "Справка");
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxInputStartStepEnd_MSM.Text);
                int stopValue = Convert.ToInt32(textBoxInputStopStepEnd_MSM.Text);
                int len = stopValue - startValue + 1;
                double[] array = ds.GetMassFunction(startValue, stopValue);
                double[] ListX = new double[len];
                double[] ListY = new double[len];

                this.dataGridViewOutput_MSM.Rows.Clear();


                for (int i = 0; i < len; i++)
                {
                    ListX[i] = startValue;
                    ListY[i] = array[i];
                    this.dataGridViewOutput_MSM.Rows.Add(Convert.ToString(startValue), Convert.ToString(array[i]));
                    startValue++;
                }
                formsPlotOutput_MSM.Plot.Clear();

                var scatter = formsPlotOutput_MSM.Plot.Add.Scatter(ListX, ListY);

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
    }
}
