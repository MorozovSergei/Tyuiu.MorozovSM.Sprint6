using Tyuiu.MorozovSM.Sprint6.Task0.V5.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputEnd_MSM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputEnd_MSM.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInputEnd_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) e.Handled = true;
        }
        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ������-24-1 ������� ������ ����������", "�������");
        }

    }
}
