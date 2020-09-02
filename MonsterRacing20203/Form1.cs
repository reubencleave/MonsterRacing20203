using MonsterRacing20203.Properties;
using MonsterRacing2023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterRacing20203
{
    public partial class Form1 : Form
    {
				//Create my monsters
				
		Monster[] monster = new Monster[4]; //creates my monsters in an array
				Punter[] MyPunter = new Punter[3];//all my punters in an array
        Punter CurrentPunter = new George(); //default CurrentPunter
        public int PunterNumber { get; set; }


        // Punter CurrentPunter = new Sophie(); // used in the code for a default punter


        public object Charlotte { get; private set; }
        public string MonsterWinner { get; private set; }
		public string Monster { get; private set;}
        public string Punter { get; set; }
        public string PunterName { get; set; }
        public Label LabelWinner { get; set; }
        public Form1()
				{

                    InitializeComponent();
					LoadMonsters();
					LoadPunters();
				}

				#region Load The Monsters and Punters

				private void LoadMonsters()
				{
					//make an instance for our monster
					monster[0] = new Monster { Length = 0, MyPB = pb1, Name = "Charlotte" };
					monster[0].MyPB.BackgroundImage = Resources.Charlotte1;
					monster[1] = new Monster { Length = 0, MyPB = pb2, Name = "George" };
					monster[1].MyPB.BackgroundImage = Resources.George1;
					monster[2] = new Monster { Length = 0, MyPB = pb3, Name = "Peter" };
					monster[2].MyPB.BackgroundImage = Resources.Peter1;
					monster[3] = new Monster { Length = 0, MyPB = pb4, Name = "Sophie" };
					monster[3].MyPB.BackgroundImage = Resources.Sophie1;
				}

				private void LoadPunters()
				{
		        	for (int i = 0; i < 3; i++)
		      		{

			}
				}


private void RunRace()
        {
			var myrand = new Random();
			bool end = false;

			while (end != true)
            {
				int distance = Form1.ActiveForm.Width;

				for (int i = 0; i < monster.Length; i++) 
                {
					monster[i].MyPB.Left += myrand.Next(1, 30);

					if(monster[i].MyPB.Left > distance)
                    {
						end = true;
						MonsterWinner = monster[i].Name;
						lblWinner.Text = MonsterWinner;

                    }
                }
				//FindWinner();

            }
        }

		private void FindWinner(string MonsterWinner)
        {
			for (int i = 0; i < 3; i++)
            {

				if (MyPunter[i].Monstername == MonsterWinner) 
                {
                    MyPunter[i].Cash += MyPunter[i].Bet;
					MyPunter[i].LabelWinner.Text += MonsterWinner + "and" + MyPunter[i].PunterName + "won and now has" + MyPunter[i].Cash;
                }

                else
                {
					MyPunter[i].Cash -= MyPunter[i].Bet;
                }
            }
        }

		private void Bet(string Bet)
        {
			for (int i = 0; i < 3; i++)
            {
				if (MyPunter[i].Monstername == MonsterWinner)
                {
					MyPunter[i].Cash += MyPunter[i].Bet;

                }
            }
        }
      
        private void btnStart_Click(object sender, EventArgs e)
        {
			RunRace();
        }

        private void AllRB_CheckedChanged(object sender, EventArgs e)
        {
			RadioButton fakeRB = new RadioButton();
			fakeRB = (RadioButton)sender;

            if (fakeRB.Checked)
            {
                switch (fakeRB.Text)
                {
                    case "George":
                        CurrentPunter = new George();
                        break;
                    case "Sophie":
                        CurrentPunter = new Sophie ();
                        break;
                    case "Peter":
                        CurrentPunter = new Peter();
                        break;
                }

                PunterNumber = Factory.SetPunterNumber(CurrentPunter.PunterName);
                string Testtt = MyPunter[PunterNumber].PunterName;

                MessageBox.Show(Testtt);
            }
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < 3; i++)
            {
				MyPunter[i].monster = monster[i].Name;
				MyPunter[i].Bet = MyPunter[i].Cash;     
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < monster.Length; i++)
            {
				monster[i].MyPB.Left = 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        
    }

		}
		
		
        
#endregion