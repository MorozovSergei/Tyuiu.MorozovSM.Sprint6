using Tyuiu.MorozovSM.Sprint6.Task6.V29.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_MSM_Click(object sender, EventArgs e)
        {
            textBoxOutput_MSM.Text = ds.CollectTextFromFile(path);
        }

        private void buttonLoad_MSM_Click(object sender, EventArgs e)
        {
            openFileDialog_MSM.ShowDialog();
            path = openFileDialog_MSM.FileName;
            textBoxInput_MSM.Text = File.ReadAllText(path);
            groupBoxInput_MSM.Text = groupBoxInput_MSM.Text + " " + path;
            buttonExecute_MSM.Enabled = true;
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}
