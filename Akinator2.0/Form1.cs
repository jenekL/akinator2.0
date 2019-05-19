using Akinator2._0.entities;
using Akinator2._0.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinator2._0
{
    public partial class Form1 : Form
    {
        private List<Questions> questions;
        //Unnecessary
        private List<Answers> answers;

        private int numOfAnswers = 0;
        private AddForm addForm;
        private Questions q1;
        private Questions q2;
        private Questions lastAnsweredQuestion;
        

        public Form1()
        {
            InitializeComponent();
            questions = DataBaseUtil.LoadQuestions();
            answers = DataBaseUtil.LoadAnswers();

            label1.AutoSize = true;
            label2.AutoSize = true;

            yesButton.Click += yesButton_Click;
            NoButton.Click += NoButton_Click;

            restart();
        }

        public void restart()
        {
            questions.Clear();
            questions = DataBaseUtil.LoadQuestions();
            q1 = null;
            q2 = null;
            lastAnsweredQuestion = null;
            numOfAnswers = 0;
            play();
        }

        private void play()
        {
            if(questions.Count != 0)
            {
                int nextItem = new Random().Next(questions.Count);
                lastAnsweredQuestion = questions[nextItem];
                questions.RemoveAt(nextItem);
                label2.Text = lastAnsweredQuestion.Question;

                
            }
            else
            {
                MessageBox.Show("Вопросы закончились");
                if (numOfAnswers == 1)
                {
                    addForm = new AddForm(this, numOfAnswers, q1: q1);
                    addForm.Show();
                    this.Hide();
                    MessageBox.Show("Add second stat");
                }
                else
                {
                    if(numOfAnswers == 0)
                    {
                        addForm = new AddForm(this, numOfAnswers, q1: q1, q2: q2);
                        addForm.Show();
                        this.Hide();
                        MessageBox.Show("Add both stats");
                    }
                }
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            play();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            numOfAnswers++;
            if (numOfAnswers == 1)
            {
                q1 = lastAnsweredQuestion;
            }
            else
            {
                if (numOfAnswers == 2)
                {
                    q2 = lastAnsweredQuestion;
                }
            }
            if (numOfAnswers == 2)
            {
                if (DataBaseUtil.LoadAnswerByTwoQuestions(q1, q2) == null)
                {
                    addForm = new AddForm(this, numOfAnswers, q1, q2);
                    addForm.Show();
                    this.Hide();
                    MessageBox.Show("Add answer");

                }
                else
                {
                    MessageBox.Show("У вас: " + DataBaseUtil.LoadAnswerByTwoQuestions(q1, q2).Answer);
                    restart();
                }
            }
            else
            {
                play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
