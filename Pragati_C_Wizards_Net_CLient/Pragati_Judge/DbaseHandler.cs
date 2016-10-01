using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pragati_Judge
{
    class DbaseHandler
    {   
        private static string connStr ="" ;
        MySqlConnection con;

        public DbaseHandler()
        {
            if (connStr.Length == 0)
            {
                string[] arr = System.IO.File.ReadAllLines("c:\\system");
                connStr = " Host= "+arr[0]+";UID = " + arr[2] + "; database = " + arr[1] + "; pwd = " + arr[3] + ";port = " + arr[4];
            }
        }

        private int executeQuery(string query)
        {
            try
            {
                if (con == null || con.State != System.Data.ConnectionState.Open)
                {
                    con = new MySqlConnection(connStr);
                    con.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.Text;                
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e.Message); if (con != null && con.State == System.Data.ConnectionState.Open) con.Close(); return 0; }
        }

        private MySqlDataReader getReader(string query)
        {
            if (con == null || con.State != System.Data.ConnectionState.Open)
            {
                con = new MySqlConnection(connStr);
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.Text;
            return cmd.ExecuteReader();
        }

        public bool userValid(string userName, string password)
        {
            MySqlDataReader reader = getReader("select count(*) from t_team where team_login ='" + userName + "' and team_pass = '" + password + "'");
            bool valid = false;
            if (reader != null)
                if (reader.Read())
                    valid = (reader.GetInt32(0) == 1) ? true : false;
            reader.Close();
            con.Close();
            return valid;

        }

        internal Team getTeamUsingName(string loginName)
        {
            Team t = null;
            try
            {
                MySqlDataReader reader = getReader("select * from t_team where team_login = '" + loginName + "'");
                reader.Read();
                t = new Team(reader.GetInt32(0), reader.GetInt32(3), reader.GetString(1));
                reader.Close();
                con.Close();
                return t;
            }
            catch (Exception) { con.Close();  return null; }

        }

        internal List<Problem> getUnsolvedProblems(int teamid)
        {
            List<Problem> temp = new List<Problem>();
            try
            {
                MySqlDataReader reader = getReader("select * from t_problems where problems_id not in ( select sub_probid from t_submission where sub_teamid = " + teamid + " and sub_no_of_errors = 0 )");
                while (reader.Read())
                {
                    Problem t = new Problem(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    temp.Add(t);
                }
                reader.Close();
                con.Close();
                return temp;
            }
            catch (Exception) { con.Close(); return null; }

        }

        internal bool submitSolution(Submission sNew)
        {
            try
            {
                executeQuery("insert into t_submission ( sub_teamid,sub_probid,sub_time,sub_no_of_errors) values (" + sNew.TeamId + "," + sNew.ProbId + ",'" + sNew.Time + "'," + sNew.NoOfErrors + ")");
                int marks = (sNew.NoOfErrors == 0) ? sNew.ProbMarks : sNew.NoOfErrors * -4;
                executeQuery("update t_team set team_score = team_score +" + marks + " where team_id= " + sNew.TeamId);
                con.Close();
                return true;
            }
            catch (Exception) { con.Close();  return false; }

        }

        internal List<System.Windows.Forms.ListViewItem> getSubmissions(int teamId)
        {
            List<System.Windows.Forms.ListViewItem> arr = new List<System.Windows.Forms.ListViewItem>();
            string[] subs = new string[4];

            try
            {
                MySqlDataReader reader = getReader(" select t_problems.problems_name , t_problems.problems_marks , t_submission.sub_time , t_submission.sub_no_of_errors from t_submission,t_problems where t_submission.sub_teamid = " + teamId + " and problems_id = sub_probid ");
                while (reader.Read())
                {
                    subs[0] = reader.GetString(0) + ", Marks: " + reader.GetString(1);
                    subs[1] = reader.GetString(2);
                    subs[2] = reader.GetString(3);
                    int noOfErr = Int32.Parse(reader.GetString(3));
                    // Calculating marks for each submission
                    subs[3] = (noOfErr == 0) ? reader.GetString(1) : "-" + (noOfErr * 4) + "";
                    System.Windows.Forms.ListViewItem lstItem = new System.Windows.Forms.ListViewItem(subs);
                    arr.Add(lstItem);
                }
                reader.Close();
                con.Close();
                return arr;
            }
            catch (Exception) { con.Close(); return null; }

        }

        internal List<System.Windows.Forms.ListViewItem> getScore()
        {
            List<System.Windows.Forms.ListViewItem> arr = new List<System.Windows.Forms.ListViewItem>();
            string[] subs = new string[2];

            try
            {
                MySqlDataReader reader = getReader(" select team_login,team_score from t_team order by team_score desc");
                while (reader.Read())
                {
                    subs[0] = reader.GetString(0);
                    subs[1] = reader.GetString(1);
                    System.Windows.Forms.ListViewItem lstItem = new System.Windows.Forms.ListViewItem(subs);
                    arr.Add(lstItem);
                }
                reader.Close();
                con.Close();
                return arr;
            }
            catch (Exception) { con.Close(); return null; }
        }

        internal List<Team> getTeams()
        {
            List<Team> arr = new List<Team>();
            try
            {
                MySqlDataReader reader = getReader(" select * from t_team");
                while (reader.Read())
                {
                    Team t = new Team(reader.GetInt32(0), reader.GetString(1));
                    arr.Add(t);
                }
                reader.Close();
                con.Close();
                return arr;
            }            
            catch (Exception) {  con.Close();return null; }
        }

        internal bool sendSms(Message message)
        {
            try
            {
                if (message.ToId != 0)
                    executeQuery("insert into t_msg ( msg_fromid,msg_toid,msg_text,msg_read )values (" + message.FromId + "," + message.ToId + ",'" + message.Text + "',0)");
                else
                {
                    List<Team> teams = new List<Team>();
                    teams = getTeams();
                    foreach (Team t in teams)
                        executeQuery("insert into t_msg ( msg_fromid,msg_toid,msg_text,msg_read )values (" + message.FromId + "," + t.ID + ",'" + message.Text + "',0)");
                }
                con.Close();
                return true;
            }
            catch (Exception) { con.Close(); return false; }
        }

        internal List<Message> getMessages(int teamId)
        {
            List<Message> msgs = new List<Message>();
            try
            {
                MySqlDataReader reader = getReader("select msg_fromid,msg_text from t_msg where msg_read = 0 and msg_toid = " + teamId);
                while (reader.Read())
                {
                    Message m = new Message(reader.GetInt32(0), teamId, reader.GetString(1));
                    msgs.Add(m);
                }
                reader.Close();
                executeQuery("update t_msg set msg_read = 1 where msg_toid =" + teamId);                
                con.Close();
                return msgs;
            }
            catch (Exception) { con.Close(); return null; }
        }
    }
}
