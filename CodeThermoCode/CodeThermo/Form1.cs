using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeThermo
{
    public partial class CodeThermo : Form
    {
        System.Media.SoundPlayer player;

        int minutesLeft = 1;
        int secondsLeft = 0;

        bool alertPic01Visible = true;
        bool alertPic02Visible = false;

        public CodeThermo() // Constructor
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer(@"Alert.wav");

            DeavtivateCountDownUI();
            ActivateMainMenuUI();

            MinuteSetter.Value = 0;
            SecondsSetter.Value = 0;
            AlertPic01.Visible = false;
            AlertPic02.Visible = false;

        }

        #region Activate/Deactivate UI Functions
        void ActivateMainMenuUI()
        {
            MinuteSetter.Value = 0;
            SecondsSetter.Value = 0;

            MainMenuSetTimeAmmountLabel.Visible = true;
            MainMenuMinuteAmmount.Visible = true;
            MainMenuSecondsAmmount.Visible = true;
            MinuteSetter.Visible = true;
            SecondsSetter.Visible = true;
            StartButton.Visible = true;

        }

        void DeactivateMainMenuUI()
        {
            MainMenuSetTimeAmmountLabel.Visible = false;
            MainMenuMinuteAmmount.Visible = false;
            MainMenuSecondsAmmount.Visible = false;
            MinuteSetter.Visible = false;
            SecondsSetter.Visible = false;
            StartButton.Visible = false;
        }

        void ActivateCountDownUI()
        {
            TimeLeftLabel.Visible = true;
            MinutesLeftLabel.Visible = true;
            SecondsLeftLabel.Visible = true;
            StopButton.Visible = true;

            //time adder
            AddTimeButton.Visible = true;
            AddLabel01.Visible = true;
            AddLabel02.Visible = true;
            TimeAdder.Value = 10;
            TimeAdder.Visible = true;
            //time adder end

            timer1.Start();
        }

        void DeavtivateCountDownUI()
        {
            timer1.Stop();
            timer2.Stop();

            TimeLeftLabel.Visible = false;
            MinutesLeftLabel.Visible = false;
            SecondsLeftLabel.Visible = false;
            StopButton.Visible = false;

            //Allerts
            player.Stop();
            AlertPic01.Visible = false;
            AlertPic02.Visible = false;
            //Allerts end

            //time adder
            AddTimeButton.Visible = false;
            AddLabel01.Visible = false;
            AddLabel02.Visible = false;
            TimeAdder.Value = 10;
            TimeAdder.Visible = false;
            //time adder end

        }
        #endregion


        #region Buttons
        private void StartButton_Click(object sender, EventArgs e)
        {
            minutesLeft = (int)MinuteSetter.Value;
            secondsLeft = (int)SecondsSetter.Value;

            DeactivateMainMenuUI();
            ActivateCountDownUI();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            DeavtivateCountDownUI();
            ActivateMainMenuUI();
        }

        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            //Allerts
            player.Stop();
            AlertPic01.Visible = false;
            AlertPic02.Visible = false;
            //Allerts end

            timer1.Start();
            timer2.Stop();
            minutesLeft += (int)TimeAdder.Value;
        }
        #endregion


        #region Timers
        private void timer1_Tick(object sender, EventArgs e) // Time left count Down
        {
            if (secondsLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                secondsLeft = secondsLeft - 1;
            }
            else if (secondsLeft == 0)
            {
                if( minutesLeft > 0)
                {
                    secondsLeft = 59;
                    minutesLeft--;
                }
                else if(minutesLeft == 0)
                {
                    timer2.Start();
                    player.PlayLooping();
                    AlertPic02.Visible = true;
                    timer1.Stop();
                }
            }

            SecondsLeftLabel.Text = secondsLeft + " sec";
            MinutesLeftLabel.Text = minutesLeft + " min";
        }//timer1 end

        private void timer2_Tick(object sender, EventArgs e) // Manages the alert icons
        {
            alertPic01Visible = !alertPic01Visible;
            alertPic02Visible = !alertPic02Visible;

            AlertPic01.Visible = alertPic01Visible;
            AlertPic02.Visible = alertPic02Visible;
        }
        #endregion

        private void QuitButton_Click(object sender, EventArgs e) // QuitButton
        {
            Application.Exit();
        }

    }//class end
}

