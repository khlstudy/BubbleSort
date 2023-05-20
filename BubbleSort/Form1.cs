namespace BubbleSort
{
    public partial class frmBubbleSort : Form
    {
        int m;
        char s;
        public frmBubbleSort()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (txtArray.Text == "")
            {
                MessageBox.Show("Кількість елементів не введено!", "ПОмилка");
            }
            else
            {
                m = Int32.Parse(txtArray.Text);
                dgvMass.ColumnCount = m;
                for (int j = 0; j < m; j++)
                {
                    dgvMass.Columns[j].Width = 110;

                    dgvMass.ColumnHeadersDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    dgvMass.Columns[j].HeaderText = "Символ №" + (j + 1).ToString();
                }
            }
        }

        private void btBubbleSort_Click(object sender, EventArgs e)
        {
            txtBubbleSort.Text = "";
            char[] symbs = new char[m];
            for (int j = 0; j < symbs.Length; j++)
            {
                symbs[j] = Convert.ToChar(dgvMass.Rows[0].Cells[j].Value);
            }
            for (int i = 1; i <= symbs.Length -1; i++)
            {
                for (int j = 0; j < symbs.Length - i; j++)
                {
                    if (symbs[j] > symbs[j+1])
                    {
                        s = symbs[j+1];
                        symbs[j+1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }
            for (int j = 0; j < symbs.Length; j++)
            {
                txtBubbleSort.Text += Convert.ToString(symbs[j]) + " ";
            }
        }

    }
}