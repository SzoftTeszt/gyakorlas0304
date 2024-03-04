namespace LottoSimulation
{
    public partial class Form1 : Form
    {
        private List<int> tippek = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var box = (CheckBox)sender;
            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));
                if (tippek.Count == 5) Kapcsol(true);
            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));
                Kapcsol(false);
            }
        }

        private void Kapcsol(bool be)
        {
            foreach (var item in panel.Controls)
            {
                if (be)
                {
                    if (!((CheckBox)item).Checked)
                        ((CheckBox)item).Enabled = false;

                }
                else
                {
                    ((CheckBox)item).Enabled = true;
                }
            }
            btnSorsol.Enabled = be;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 700);
            btnSorsol.Enabled = false;

            panel.Size = new Size(560, 500);
            panel.BackColor = Color.Beige;

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 10; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = (i * 10 + j + 1).ToString();
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    box.AutoSize = true;
                    box.Location = new Point(j * 50 + 40, i * 50 + 40);
                    panel.Controls.Add(box);
                }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int> szamok = new HashSet<int>();
            Random rnd = new Random();

            do {
                szamok.Add(rnd.Next(1, 6));
            } while (szamok.Count() != 5);

            label1.Text="Kisorsolt: "+ String.Join(", ", szamok);
            label1.Text+="\nEltalált: "+ String.Join(", ", szamok.Intersect(tippek));
        }
    }
}