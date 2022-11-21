using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Name: Michelle Boutilier
        //Date: October 5 2022
        // Description: This is a multiplier app with a photo app  that tells a story, with a message box and a full data details.
        
        /// <summary>
        /// This closes the form when user clicks exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Shows the picture when the user clicks on the button, and hides the data label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPicture_Click(object sender, EventArgs e)
        {
            picSadie.Visible = true;
            lblTopicName.Visible = false;

        }


        /// <summary>
        /// Hide the picture and data label on top of it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHide_Click(object sender, EventArgs e)
        {
            picSadie.Visible = false;
            lblTopicName.Visible = true;
            lblData.Visible = false;
        }

        /// <summary>
        /// Blank out the number and multiplier textboxes and the answer label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtMultiplier.Text = "";
            lblAnswer.Text = "";

        }

        /// <summary>
        /// This is the story about Sadie and my homework. Will hide picture and Topic label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnData_Click(object sender, EventArgs e)
        {
            lblData.Visible=true;
            picSadie.Visible=false;
            lblData.Text = "My topic is " + lblTopicName.Text + ". \r\n\r\n" +
                "I was tossing and turning thinking about my Math assignment while in bed.\r\n\r\n "
                +"I decided to get up and work on it instead of trying to solve the answers in my head.\r\n\r\n "
                +"I had finished my questions just in time to get the kids up for school. \r\n\r\n " 
               +"Then I heard ..Bad Sadie.No  Paper -Mommmm .. she ate your homework \r\n\r\n ";
        }
        /// <summary>
        /// Displays a message box about the picture, with my name as the title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSadie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Sadie, I ate my mom's homework!","Michelle Boutilier");
        }
        

     
        /// <summary>
        /// Declare variables, multiply 2 numbers and display the answer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number;
            int multiplier;
            int answer;
            //converting the integer into text 
            number = Convert.ToInt32(txtNumber.Text);
            multiplier = Convert.ToInt32(txtMultiplier.Text);
            //we are multiply 2 numbers 
            answer = number * multiplier;
            lblAnswer.Text = answer.ToString();
        }
    }
}
