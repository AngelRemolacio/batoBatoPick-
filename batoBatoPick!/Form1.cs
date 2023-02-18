namespace batoBatoPick_
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;

        Random rnd = new Random();
        string cpChoice = "";

        int playerWins = 0;
        int cpWins = 0;


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void gameKodigo()
        {
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                cpChoice = "Rock";
            }
            else if (choice == 2)
            {
                cpChoice = "Paper";
            }
            else if (choice == 3)
            {
                cpChoice = "Scissors";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            gameKodigo();
            if (cpChoice == "Rock")
            {
                lblResult.Text = "It's a tie!";
            }
            else if(cpChoice == "Paper")
            {
                lblResult.Text = "You lose!";
                cpWins = Convert.ToInt32(lblcpScore.Text) + 1;
                lblcpScore.Text = cpWins.ToString();
            }
            else if (cpChoice == "Scissors")
            {
                lblResult.Text = "You win!";
                playerWins = Convert.ToInt32(lblplayerScore.Text) + 1;
                lblplayerScore.Text = playerWins.ToString();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            gameKodigo();
            if (cpChoice == "Rock")
            {
                lblResult.Text = "You win!";
                playerWins = Convert.ToInt32(lblplayerScore.Text) + 1;
                lblplayerScore.Text = playerWins.ToString();
            }
            else if (cpChoice == "Paper")
            {
                lblResult.Text = "It's a tie!";
            }
            else if (cpChoice == "Scissors")
            {
                lblResult.Text = "You lose!";
                cpWins = Convert.ToInt32(lblcpScore.Text) + 1;
                lblcpScore.Text = cpWins.ToString();
            }

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            gameKodigo();
            if (cpChoice == "Rock")
            {
                lblResult.Text = "You lose!";
                cpWins = Convert.ToInt32(lblcpScore.Text) + 1;
                lblcpScore.Text = cpWins.ToString();
            }
            else if (cpChoice == "Paper")
            {
                lblResult.Text = "You win!";
                playerWins = Convert.ToInt32(lblplayerScore.Text) + 1;
                lblplayerScore.Text = playerWins.ToString();
            }
            else if (cpChoice == "Scissors")
            {
                lblResult.Text = "It's a tie!";
            }
        }
    }
    //Remolacio, Angel
}