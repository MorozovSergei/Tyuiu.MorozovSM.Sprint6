using Tyuiu.MorozovSM.Sprint6.Task1.V3.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBoxInputStartStepEnd_MSM.Text);
            int stop = Convert.ToInt32(textBoxInputStopStepEnd_MSM.Text);
            double[] array = ds.GetMassFunction(start, stop);
            textBoxOutputEnd_MSM.Text = "";
            textBoxOutputEnd_MSM.AppendText("+----------+-------------+" + Environment.NewLine);
            textBoxOutputEnd_MSM.AppendText("|    X     |    F(x)     |" + Environment.NewLine);
            textBoxOutputEnd_MSM.AppendText("+----------+-------------+" + Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                textBoxOutputEnd_MSM.AppendText(String.Format("|{0,5:d}     |   {1,6:f2}    |", start, array[i])+ Environment.NewLine);
                start++;
            }
            textBoxOutputEnd_MSM.AppendText("+----------+------------+");
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-24-1 Морозов Сергей Максимович", "Справка");
        }

        private void textBoxInputStopStepEnd_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58 ) && e.KeyChar != 8 && e.KeyChar != '-') e.Handled = true;
        }
    }
}
