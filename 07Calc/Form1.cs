namespace _07Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int att = int.Parse(attack.Text);
            int str = int.Parse(strength.Text);
            int def = int.Parse(defence.Text);
            int hp = int.Parse(hitpoints.Text);
            int pray = int.Parse(prayer.Text);
            int ranging = int.Parse(range.Text);
            int magic = int.Parse(mage.Text);

            if (hp < 10)
            {
                hp = 10;
            }

            if (def == 1)
            {
                MessageBox.Show("Oh my eff gee!@! 1 def pure");
            }

            double basic = 0.25 * (def + hp + (pray/2));
            double melee = (0.325) * (att + str);
            double bow = (0.325) * (ranging * 1.5);
            double rune = (0.325) * (magic * 1.5);

            double total = basic;

            List<double> skills = new List<double>();
            skills.Add(melee);
            skills.Add(bow);
            skills.Add(rune);

            double tracker = 0;

            foreach(double s in skills)
            {
                if (s > tracker)
                {
                    tracker = s;
                }
            }

            total += tracker;

            MessageBox.Show($"{(int)total}");
        }
    }
}