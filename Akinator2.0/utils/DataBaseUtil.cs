using Akinator2._0.entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinator2._0.utils
{
    class DataBaseUtil
    {
        public static List<Questions> LoadQuestions()
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                var output = cnn.Query<Questions>("select * from questions", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveQuestion(Questions question)
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                cnn.Execute("insert into questions (question) values (@Question)", question);
            }
        }

        public static List<Answers> LoadAnswers()
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                var output = cnn.Query<Answers>("select * from answers", new DynamicParameters());
                return output.ToList();
            }
        }
        public static Answers LoadAnswerByTwoQuestions(Questions q1, Questions q2)
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                KEK kek = new KEK(q1.Id, q2.Id, q2.Id, q1.Id);
                var output = cnn.Query<Answers>("select * from answers " +
                    "where (question1_id = @Id1 and question2_id = @Id2) OR (question1_id = @Id3 and question2_Id = @id4)", 
                   kek);
                return output.ToList().FirstOrDefault();
            }
        }
        public static int getQuestionMaxID()
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                var output = cnn.Query<int>("select MAX(id) from questions", new DynamicParameters());
                return output.ToList().First();
            }
        }
        public static void SaveAnswer(Answers answer)
        {
            using (IDbConnection cnn = new MySqlConnection(loadConnectionString()))
            {
                cnn.Execute("insert into answers (answer, question1_id, question2_id) values (@Answer, @Question1_id, @Question2_id)", answer);
            }
        }


        private static string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
