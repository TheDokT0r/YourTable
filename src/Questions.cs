using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace YourTable
{
    public partial class Questions : Form
    {
        static Json_File j;
        static int jCounter; //counting the position of the current question
        int arraySize;
        List<string> answers;

        public Questions()
        {
            InitializeComponent();
            this.Text = "YourTable";

            jCounter = 0;
            j = new Json_File();
            answers = new List<string>();

            arraySize = j.arraySize();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            Stickers s = new Stickers();
            img_sticker.ImageLocation = s.GetRandom();


            Next();
            jCounter++;

            Options options = new Options();
            if(!options.hasOpened())
            {
                btn_cancel.Visible = false;
            }
        }

        private void img_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }

        private void txt_answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (jCounter < arraySize)
            {
                Next();
                NextAnswer();
            }
            else
            {
                NextAnswer();
                j.ChangeAnswers(answers);
                Done();
            }
        }

        private void cmb_options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //void Reset() //Reseting the cmb and txt
        //{
        //    cmb_options.Items.Clear();
        //    cmb_options.Text = "";
        //    txt_answer.Text = "";
        //}

        void Next()
        {
            Stickers s = new Stickers(); 
            string newLocation;
            string prevLocation = img_sticker.ImageLocation;
            do //Makes sure that the new sticker != to the prev one
            {
                newLocation = s.GetRandom();

            } while (prevLocation == newLocation);
            
            img_sticker.ImageLocation = s.GetRandom();

            cmb_options.Items.Clear(); //Resets the options of cmb_options

            lbl_question.Text = j.ReadQuestion(jCounter);

            if (j.IsOptionsQuestion(jCounter))
            {
                string[] opArray = j.ReadOptions(jCounter).ToArray(); //converts the options list to an array

                cmb_options.Items.AddRange(opArray);

                cmb_options.Visible = true;
                txt_answer.Visible = false;
            }
            else
            {
                cmb_options.Visible = false;
                txt_answer.Visible = true;
            }
        }

        void NextAnswer()
        {
            if (jCounter != 0) //So it wouldn't take the answer on questions_load
            {
                if (j.IsOptionsQuestion(jCounter - 1))
                {
                    answers.Add(cmb_options.Text.ToString());
                }
                else
                {
                    answers.Add(txt_answer.Text);
                }
            }
            jCounter++;
        }

        void Done() //moving to the next form when done
        {
            if(jCounter >= arraySize - 1)
            {
                Menu m = new Menu();
                m.Show();
                Hide();

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string path = localAppData + @"/YT_Data/hasOpened.txt"; //HasOpened = ture
                File.WriteAllText(path, "1");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Questios_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }
    }
}