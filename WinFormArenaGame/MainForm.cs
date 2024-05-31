using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{

    public partial class MainForm : Form
    {
        public Hero lHero;
        public Hero rHero;
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker == lHero)
                tbAttacker = tbKnight;
            else
                tbAttacker = tbAssassin;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                //HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                //HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                HeroA = lHero,
                HeroB = rHero,
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lHero = new Assassin("Altair", 10, 5, new Dagger("Dagger"));
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lHero = new Knight("Sir Kn.", 10, 5, new Sword("Swork"));
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lHero = new Magician("Gandalf", 10, 5, new Dagger("Dagger"));
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lHero = new Viking("Ragnarok", 10, 5, new Sword("Swork"));
            }
            textBox1.Text = lHero.SpecialWeapon.Name;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                rHero = new Assassin("Ezio", 10, 5, new Dagger("Dagger"));
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                rHero = new Knight("Lancelot", 10, 20, new Sword("Sword"));
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                rHero = new Magician("White Gandalf", 6, 15, new Dagger("Dagger"));
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                rHero = new Viking("Magma", 20, 13, new Sword("Sword"));
            }
            textBox2.Text = rHero.SpecialWeapon.Name;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}