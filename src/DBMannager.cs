using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace YourTable
{
    //Based on the SQLite code of:
    //https://youtu.be/U777GVhKUQk

    public class DBMannager
    {
        //desc: A library that mannages the database file (Tasks.db)

        string path;
        string cs;
        SQLiteDataReader dr;

        //For tasks
        string name; //Also for schedule
        int timeTakeHours;
        int priority; //0 - 3
        string completionDate;

        //for schedule
        List<string> dates;
        int taskID;

        public DBMannager()
        {
            //string localAppData = Environment.GetEnvironmentVariable("LocalAppData");
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); //db is automaticly downloed into the appdata folder
            //path = @"Data Source=.\data\Tasks.db";
            path = @"Data Source = " + localAppData + @"\YT_Data\Tasks.db";
            //cs = @"URI=file:" + @".\data\Tasks.db"; //creates debug folder
            cs = @"URI=file:" + localAppData + @"\YT_Data\Tasks.db";

            dates = new List<string>();
        }

        public void InsertTask(string name, int timeTakeHours, int priority, string completionDate) //Insets task into the db
        {
            this.name = name;
            this.timeTakeHours = timeTakeHours;
            this.priority = priority;
            this.completionDate = completionDate;

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO TasksData(name, timeTakeHours, priority, completionDate) " +
                "VALUES(@name, @timeTakeHours, @priority, @completionDate)";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@timeTakeHours", timeTakeHours);
            cmd.Parameters.AddWithValue("@priority", priority);
            cmd.Parameters.AddWithValue("@completionDate", completionDate);

            cmd.ExecuteNonQuery();



            //Gets the taskID to insert the date for the schedule
            cmd.CommandText = "SELECT id FROM TasksData WHERE name = @name and timeTakeHours = @timeTakeHours and priority = @priority" +
               " and completionDate = @completionDate";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@timeTakeHours", timeTakeHours);
            cmd.Parameters.AddWithValue("@priority", priority);
            cmd.Parameters.AddWithValue("@completionDate", completionDate);

            SQLiteDataReader reader = cmd.ExecuteReader();

            int taskID = 0; //Just to add value so it wouldn't pop up a stupidass error

            reader.Read();
            taskID = Convert.ToInt32(reader["id"]);
            reader.Close();


            CaculateDates caculate = new CaculateDates(name, timeTakeHours, priority, Convert.ToDateTime(completionDate));

            List<DateTime> dt = caculate.GetDates();

            foreach (DateTime date in dt)
            {
                dates.Add(date.ToString());
            }

            InsertToSchedule(name, dates, taskID);
        }



        public void InsertToSchedule(string name, List<string> dates, int taskID) //insets data to the schedule table
        {
            //dates.Add(DateTime.Now.ToString()); //Just for demo...
            this.name = name;
            this.dates = dates;
            this.taskID = taskID;

            foreach (string date in dates)
            {
                string dateTime = GetFixedDate(Convert.ToDateTime(date)).ToString(); //What the actual fuck (In short, it gets the date in a fixed time)

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO Schedule(name, date, taskID) VALUES(@name, @date, @taskID)";

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", dateTime);
                cmd.Parameters.AddWithValue(@"taskID", taskID);

                cmd.ExecuteNonQuery();
            }
        }

        private DateTime GetFixedDate(DateTime dt) //Changes the datetime do the same formula
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);
        }


        public Dictionary<string, object> GetTaskInDate(DateTime dt) //Get a task from a specific date (including his data)
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from Schedule where date = @date", con))
            {
                comm.Parameters.AddWithValue("@date", dt.ToString());
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord s in r)
                    {
                        if (Convert.ToDateTime(s["date"]) == dt)
                        {
                            int priority = GetPriority(Convert.ToInt32(r["taskID"]));
                            DateTime completionDate = GetCompletionDate(Convert.ToInt32(r["taskID"]));

                            Dictionary<string, object> dataDic = new Dictionary<string, object> //Dictionary with the data of the task.
                                {
                                    { "id", Convert.ToInt32(s["id"]) },
                                    { "name", s["name"].ToString() },
                                    { "date", s["date"].ToString() },
                                    { "taskID", Convert.ToInt32(s["taskID"]) },
                                    {"priority", priority },
                                    {"completionDate", completionDate }
                                };

                            return dataDic;
                        }
                    }

                    Dictionary<string, object> nullDic = new Dictionary<string, object> //Returns null in the case of data not found.
                                {
                                    { "id", null },
                                    { "name", null },
                                    { "date", null },
                                    { "taskID", null },
                                    {"priority", null},
                                    {"completionDate", null}
                                };

                    return nullDic;
                }
            }
        }


        public Dictionary<string, object> GetTaskFromID(int id) //Get the task and its data from the ID
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from TasksData where id = @id", con))
            {
                comm.Parameters.AddWithValue("@id", id.ToString());
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord s in r)
                    {
                        if (Convert.ToInt32(s["id"]) == id)
                        {
                            Dictionary<string, object> dataDic = new Dictionary<string, object>
                                {
                                    { "taskID", Convert.ToInt32(s["id"]) },
                                    { "name", s["name"].ToString() },
                                    {"priority", s["priority"] },
                                    {"completionDate", s["completionDate"] }
                                };

                            return dataDic;
                        }
                    }

                    Dictionary<string, object> nullDic = new Dictionary<string, object> //Returns null in the case of data not found.
                                {
                                    { "id", null},
                                    { "name", null},
                                    {"priority", null},
                                    {"completionDate", null}
                                };

                    return nullDic;
                }
            }
        }


        private int GetPriority(int taskID) //Gets the priority of the task
        {
            int priority = 9;
            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from TasksData where id = @id", con))
            {
                comm.Parameters.AddWithValue("@id", taskID);
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord reader in r)
                    {
                        if (Convert.ToInt32(reader["id"]) == taskID)
                        {
                            priority = Convert.ToInt32(reader["priority"]);
                        }
                    }
                }
            }

            return priority;
        }

        public Dictionary<string, string> GetNextTask()
        {
            DbDataRecord returnThis = null; //task from the database
            DateTime smallestDate = new DateTime(3000, 1, 1);

            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from Schedule", con))
            {
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    if(r == null) //Check if there are even tasks
                    {
                        var nullDict = new Dictionary<string, string>()
                        {
                            {"id", null },
                            {"taskID", null },
                            {"name", null },
                            {"date", null}
                        };

                        return nullDict;
                    }

                    foreach (DbDataRecord reader in r)
                    {
                        DateTime date = Convert.ToDateTime(reader["date"]);
                        if (date.Date <= smallestDate.Date && Convert.ToInt32(reader["taskID"]) != -100) //Which date comes first, also checks if it's a task or not (taskID)
                        {
                            smallestDate = date;
                            returnThis = reader;
                        }
                    }
                }
            }

            var dict = new Dictionary<string, string>()
            {
                {"id", returnThis["id"].ToString() },
                {"taskID", returnThis["taskID"].ToString() },
                {"name", returnThis["name"].ToString() },
                {"date", smallestDate.ToString()}
            };

            return dict;
        }

        public DateTime GetCompletionDate(int taskID) //Get the completion date of the task
        {
            DateTime completionDate = new DateTime();
            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from TasksData where id = @id", con))
            {
                comm.Parameters.AddWithValue("@id", taskID);
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord reader in r)
                    {
                        if (Convert.ToInt32(reader["id"]) == taskID)
                        {
                            completionDate = Convert.ToDateTime(reader["completionDate"]);
                        }
                    }
                }
            }

            return completionDate;
        }


        public List<DateTime> GetAllDates(int taskID) //Get list of all of the dates of the task (using the task ID)
        {
            List<DateTime> dates = new List<DateTime>();

            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from Schedule where taskID = @taskID", con))
            {
                comm.Parameters.AddWithValue("@taskID", taskID);
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord reader in r)
                    {
                        if (Convert.ToInt32(reader["taskID"]) == taskID)
                        {
                            dates.Add(Convert.ToDateTime(reader["date"]));
                        }
                    }
                }
            }

            return dates;
        }



        public void ResetTable(string tableName) //Resets a specific table and all of its content
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM " + tableName;
            cmd.ExecuteNonQuery();

            /*cmd.CommandText = "delete from sqlite_sequence where name = " + tableName;
            cmd.ExecuteNonQuery();*/
        }



        public bool IsFullDay(int firstHour, int lastHour, DateTime dt) //Check if the day is full
        {
            for (int i = firstHour; i <= lastHour; i++)
            {
                DateTime newDt = new DateTime(dt.Year, dt.Month, dt.Day, i, 0, 0);

                using (var con = new SQLiteConnection(cs))
                using (var comm = new SQLiteCommand("SELECT date FROM Schedule where date = @date", con))
                {
                    comm.Parameters.AddWithValue("@date", newDt.ToString());
                    con.Open();

                    using (var r = comm.ExecuteReader())
                    {
                        foreach (DbDataRecord s in r)
                        {
                            if (s == null)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }


        public List<DateTime> FreeHoursOfTheDay(DateTime date) //Returns a list with all of the free hours of said day
        {
            var freeHours = new List<DateTime>();

            User user = new User();

            for (int i = user.HoursOfWork[0]; i < user.HoursOfWork[1]; i++)
            {
                DateTime hour = new DateTime(date.Year, date.Month, date.Day, i, 0, 0);
                int exist;

                using (var con = new SQLiteConnection(cs))
                using (var comm = new SQLiteCommand("SELECT EXISTS(SELECT 1 FROM Schedule WHERE date = @date)", con))
                {
                    comm.Parameters.AddWithValue("@date", hour.ToString());
                    con.Open();

                    exist = Convert.ToInt32(comm.ExecuteScalar());
                }

                if(exist != 1) //The object doesn't exists in the DB
                {
                    freeHours.Add(hour);
                }
            }

            return freeHours;
        }


        public Queue<int> GetAllTaskIDs() //Returns a queue list of all of the taskIDs
        {
            Queue<int> ids = new Queue<int>();

            using (SQLiteConnection con = new SQLiteConnection(cs))
            using (SQLiteCommand comm = new SQLiteCommand("select * from TasksData", con))
            {
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord reader in r)
                    {
                        ids.Enqueue(Convert.ToInt32(reader["id"]));
                    }
                }
            }

            return ids;
        }

        public void DeleteTask(int taskID) //Delete a specific task form the db (both Schedule table and task table) (deletes from schedule in the next func below)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE from Schedule WHERE taskID = @taskID";
            cmd.Parameters.AddWithValue(@"taskID", taskID);

            cmd.ExecuteNonQuery();


            cmd.CommandText = "DELETE from TasksData WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", taskID);
            cmd.ExecuteNonQuery();
        }


        public void DeleteFromSchedule(DateTime dt)
        {
            using (var con = new SQLiteConnection(cs))
            using (var comm = new SQLiteCommand("DELETE from Schedule WHERE date = @date", con))
            {
                con.Open();
                comm.Parameters.AddWithValue("@date", dt);

                comm.ExecuteNonQuery();
            }
        }


        public void DeletePastTasks() //TODO: Delete (doesn't work)
        {
            var removeDates = new Queue<DateTime>();

            using (var con = new SQLiteConnection(cs))
            using (var comm = new SQLiteCommand("SELECT * FROM Schedule", con))
            {
                con.Open();

                using (var r = comm.ExecuteReader())
                {
                    foreach (DbDataRecord reader in r)
                    {
                        DateTime date = Convert.ToDateTime(reader["date"]);

                        if (date.Date > DateTime.Today.Date)
                        {
                            removeDates.Enqueue(date);
                        }
                    }
                }
            }

            while(removeDates.Count > 0)
            {
                using (var con = new SQLiteConnection(cs))
                using (var comm = new SQLiteCommand("DELETE FROM Schedule WHERE date = @date", con))
                {
                    comm.Parameters.AddWithValue("@dates", removeDates.Dequeue());
                    con.Open();

                    comm.ExecuteNonQuery();
                }
            }
        }


        public void DeleteBusyHours() //Remvoe all of the busy hours from the Schedule table
        {
            using (var con = new SQLiteConnection(cs))
            using (var comm = new SQLiteCommand("DELETE FROM Schedule WHERE taskID = -100", con)) //All of the busy hours has the id of -100 by default
            {
                con.Open();
                comm.ExecuteNonQuery();
            }
        }
    }
}