using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace nhap
{
    public partial class Form1 : Form
    {
        int numberCol;
        int second;
        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        int moveNumber = 0;
        int labelIndext = 0;

        private void shuffleButtons(int n)
        {
            //start timing 
            timePlayGame.Start();
            Thread time = new Thread(Elapsed);
            time.Start();
            List<int> labelList = new List<int>();
            Random rand = new Random();
            foreach( Button btn in this.pnl.Controls )
            {
                while(labelList.Contains(labelIndext))
                {
                    labelIndext = rand.Next(n);
                }
                btn.Text = (labelIndext == 0) ? "" : labelIndext + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndext);
               
            }

            moveNumber = 0;
            lblNoOfMove.Text = "Move Count: " + moveNumber;
        }


        private void checkOrder()
        {
            int index = 1;
            foreach(Button btn in this.pnl.Controls)
            {
                if(btn.Text !="" && (Convert.ToInt32(btn.Text)!=index))
                {
                    return;
                }
                index++;
            }

            //finish timers
            timePlayGame.Stop();
            MessageBox.Show("Congrat! You did it in" + moveNumber+"moves in"+ second+"Second");
        }

        // list include buttons
        List<Button> buttonsAdded = new List<Button>();
        private void addButton(int n)
        {
            for (int i = 0; i < n; i++)
            {
                 for (int j = 0; j < n; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(60-n*n*3 + j * 43, 50-n*n*2+ i*43);
                    btn.Size = new Size(40, 40);
                    btn.Click += swapLablel;

                    this.pnl.Controls.Add(btn);
                    buttonsAdded.Add(btn);
                    
                }
            }
        }

        private void clearButton()
        {
            pnl.Controls.Clear();
        }

        private void swapLablel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                return;
            }

            Button whileBTn = null;
            foreach (Button bt in this.pnl.Controls)
            {
                if (bt.Text == "")
                {
                    whileBTn = bt;
                    break;
                }

            }

            if (btn.TabIndex == (whileBTn.TabIndex - 1) ||
                btn.TabIndex == (whileBTn.TabIndex - numberCol) ||
                btn.TabIndex == (whileBTn.TabIndex + 1) ||
                 btn.TabIndex == (whileBTn.TabIndex + numberCol))
            {
                whileBTn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whileBTn.Text = btn.Text;
                btn.Text = "";
                moveNumber++;
                lblNoOfMove.Text = "Move count :" + moveNumber;

            }
            checkOrder();
        }

        private void CboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == "3 x 3")
            {
                numberCol = 3;
                clearButton();
                addButton(numberCol);
                shuffleButtons(9);

            }
            if (cb.SelectedItem == "4 x 4")
            {
                numberCol = 4;
                clearButton();
                addButton(numberCol);
                shuffleButtons(16);
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            if (numberCol == 3)
            {
                clearButton();
                addButton(numberCol);
                shuffleButtons(9);

            }
            if (numberCol == 4)
            {
                clearButton();
                addButton(numberCol);
                shuffleButtons(16);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numberCol = 3;
            addButton(numberCol);
            shuffleButtons(9);
            MessageBox.Show("The tiles must be moved back into their original positions, numbered 1 through 8.Good luck!");
            
        }

        private void LbSize_Click(object sender, EventArgs e)
        {

        }

        private void TimePlayGame_Tick(object sender, EventArgs e)
        {
            string str = lblSecond.Text;
            var a=str.Substring(0, str.IndexOf(" "));
            int second = Int32.Parse(a);
            second++;
            lblSecond.Text = second.ToString() + " sec";

        }
        private void Elapsed() 
        {
            lblSecond.Text = second.ToString()+" sec";
        }
    }
}
