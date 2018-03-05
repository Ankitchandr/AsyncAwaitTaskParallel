using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace AsyncAwait1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int countCharacters()
        {
            int count = 0;
            try
            {
         
                using (StreamReader reader = new StreamReader(" F:\\fileIO\\data.txt.txt"))
                {
                    string content = reader.ReadToEnd();
                    count = content.Length;
                    Thread.Sleep(5000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }

        private async void btnProcessesFile_Click(object sender, EventArgs e)
        {

            Task<int> task = new Task<int>(countCharacters);
            task.Start();
            lblcount.Text = "Processing File. please wait...";
            int count = await task;
            lblcount.Text = count.ToString() + " character in file";
            Console.Read();
        }



        //int CharacterCount = 0; 
        //private async void btnProcessesFile_Click(object sender, EventArgs e)
        //{

        //    Thread thread = new Thread(()=>
        //    {
        //        CharacterCount = countCharacters();
        //        Action action = new Action(setLabel1TextProperty);
        //        this.BeginInvoke(action);
        //    });
        //    thread.Start();
        //    lblcount.Text = "Processing File. please wait...";

        //    Console.Read();
        //}

        //public void setLabel1TextProperty()
        //{
        //    lblcount.Text = CharacterCount.ToString() + " character in file";
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            labmess.Text = "Total Number of Character in your file click Processes File";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            labmess.Text = "Total Number of Character in your file ";
        }

    }
}
