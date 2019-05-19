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
    public partial class AddForm : Form
    {
        private Form1 mainForm;
        public AddForm(Form1 mainForm, int numOfAnswers, Questions q1 = null, Questions q2 = null)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            question1Text.ReadOnly = true;
            question2Text.ReadOnly = true;

            if (numOfAnswers == 2)
            {
                question1Text.Text = q1.Question;
                question2Text.Text = q2.Question;
                addButton.Click += (object sender, EventArgs e) =>
                {
                    if (answerText.Text != "")
                    {
                        try { 
                            DataBaseUtil.SaveAnswer(new Answers(answerText.Text, q1.Id, q2.Id));
                            mainForm.restart();
                            mainForm.Show();
                            this.Close();
                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show("Так нельзя!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля!");
                    }
                };
            }
            else
            {
                if (numOfAnswers == 1)
                {
                    question1Text.Text = q1.Question;
                    question2Text.ReadOnly = false;

                    addButton.Click += (object sender, EventArgs e) =>
                    {
                        if (answerText.Text != "" && question2Text.Text != "")
                        {
                            try { 
                                Questions newQuestion = new Questions(DataBaseUtil.getQuestionMaxID() + 1, question2Text.Text);
                                DataBaseUtil.SaveQuestion(newQuestion);
                                DataBaseUtil.SaveAnswer(new Answers(answerText.Text, q1.Id, newQuestion.Id));
                                mainForm.restart();
                                mainForm.Show();
                                this.Close();
                            }
                            catch (MySql.Data.MySqlClient.MySqlException ex)
                            {
                                MessageBox.Show("Так нельзя!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!");
                        }

                    };
                }
                else
                {
                    question2Text.ReadOnly = false;
                    question1Text.ReadOnly = false;

                    addButton.Click += (object sender, EventArgs e) =>
                    {
                        if (answerText.Text != "" && question1Text.Text != "" && question2Text.Text != "")
                        {
                            try
                            {
                                Questions newQuestion1 = new Questions(DataBaseUtil.getQuestionMaxID() + 1, question1Text.Text);
                                DataBaseUtil.SaveQuestion(newQuestion1);
                                Questions newQuestion2 = new Questions(DataBaseUtil.getQuestionMaxID() + 1, question2Text.Text);
                                DataBaseUtil.SaveQuestion(newQuestion2);
                                DataBaseUtil.SaveAnswer(new Answers(answerText.Text, newQuestion1.Id, newQuestion2.Id));
                                mainForm.restart();
                                mainForm.Show();
                                this.Close();
                            }                
                            catch (MySql.Data.MySqlClient.MySqlException ex)
                            {
                                MessageBox.Show("Такой объект уже есть!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!");
                        }

                    };
                }
            }
        }


        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.restart();
            mainForm.Show();
        }
    }
}
