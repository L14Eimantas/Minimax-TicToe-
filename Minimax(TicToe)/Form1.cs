using System;
using System.Linq;
using System.Windows.Forms;

namespace Minimax_TicToe_
{
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null, new EventArgs());

        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            gmBoard = new TicToeBoard();
            var list = Controls.OfType<Button>().Cast<Control>().ToList();
            foreach (var i in list)
            {
                i.Text = "";
                i.Enabled = true;
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            var requiredField = GetField(clickedButton);
            gmBoard[requiredField.X, requiredField.O] = Player.X;
            if (CheckForWinners())
                Form1_Load(null, new EventArgs());  //Winner was found, reload the game

            IAiLogic ai = new Minimax();
            requiredField = ai.Move(gmBoard, Player.O);

            EnabledButton(requiredField);
            gmBoard[requiredField.X, requiredField.O] = Player.O;
           
            if (CheckForWinners())
                Form1_Load(null, new EventArgs());  //Winner was found, reload the game

        }

        private void EnabledButton(EmptyFields emptyFields)
        {
            var name = new Button();
            if (emptyFields.X == 0 && emptyFields.O == 0)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt1") as Button;
            if (emptyFields.X == 0 && emptyFields.O == 1)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt2") as Button;
            if (emptyFields.X == 0 && emptyFields.O == 2)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt3") as Button;
            if (emptyFields.X == 1 && emptyFields.O == 0)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt4") as Button;
            if (emptyFields.X == 1 && emptyFields.O == 1)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt5") as Button;
            if (emptyFields.X == 1  && emptyFields.O == 2)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt6") as Button;
            if (emptyFields.X == 2 && emptyFields.O == 0)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt7") as Button;
            if (emptyFields.X == 2 && emptyFields.O == 1)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt8") as Button;
            if (emptyFields.X == 2 && emptyFields.O == 2)
                name = Controls.OfType<Button>().Cast<Control>().ToList().First(x => x.Name == "bt9") as Button;
            if (name != null)
            {
                name.Text = Player.O.ToString();
                name.Enabled = false;
            }
        }

        private EmptyFields GetField(Button name)
        {
            name.Enabled = false;
            name.Text = Player.X.ToString();
            if (name.Name.Equals("bt1")) return new EmptyFields(0, 0);
            if (name.Name.Equals("bt2")) return new EmptyFields(0, 1);
            if (name.Name.Equals("bt3")) return new EmptyFields(0, 2);
            if (name.Name.Equals("bt4")) return new EmptyFields(1, 0);
            if (name.Name.Equals("bt5")) return new EmptyFields(1, 1);
            if (name.Name.Equals("bt6")) return new EmptyFields(1, 2);
            if (name.Name.Equals("bt7")) return new EmptyFields(2, 0);
            if (name.Name.Equals("bt8")) return new EmptyFields(2, 1);
            return new EmptyFields(2, 2);
        }

        public bool CheckForWinners()
        {
            Player? p = gmBoard.Winner;

            if (p == Player.X)
            {
                MessageBox.Show(@"You Win");
                return true;
            }
            else if (p == Player.O)
            {
                MessageBox.Show(@"Computer Win!");
                return true;
            }
            else if (gmBoard.IsFull)
            {
                MessageBox.Show(@"Draw");
                return true;
            }
            return false;
        }
    }

}
