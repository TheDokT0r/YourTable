using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace YourTable
{
    public class Json_File
    {
        static string path;
        int size;

        string main { get; set; }
        string question { get; set; }
        string answer { get; set; }
        List<string> options { get; set; }

        public Json_File()
        {
            //string localAppData = Environment.GetEnvironmentVariable("LocalAppData");
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = localAppData + @"\YT_Data\user_data.json";
            size = arraySize();
        }

        public string ReadQuestion(int num)
        {
            dynamic array = ReadFile();

            //return AdjQuestion(array[num].question.ToString());

            return array[num].question;
        }

        //public string AdjQuestion(string question)
        //{
        //    if(question.Length > 16)
        //    {
        //        string q1 = question.Substring(1, question.Length / 2);
        //        string q2 = question.Substring((question.Length / 2) + 1, question.Length - 1);

        //        question = q1 + "\n" + q2;
        //    }

        //    return question;
        //}

        public List<string> ReadOptions(int num)
        {
            dynamic array = ReadFile();

            List<string> strList = new List<string>();

            foreach (var item in array[num].options) //Converts to list<string>
            {
                strList.Add(item.ToString());
            }

            return strList;
        }

        public int arraySize()
        {
            dynamic array = ReadFile();

            int counter = 0;

            foreach (var item in array)
            {
                counter++;
            }

            return counter;
        }

        //public void ChangeAnswer(int num, string answer)
        //{
        //    string json = File.ReadAllText(path);
        //    dynamic jsonObj = JsonConvert.DeserializeObject(json);
        //    jsonObj[num]["answer"] = answer;
        //    //jsonObj[num].answer = answer;
        //    string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        //    File.WriteAllText(path, output);
        //}

        public void ChangeAnswers(List<string> answers)
        {
            dynamic json = ReadFile();

            for (int i = 0; i < answers.Count; i++)
            {
                json[i]["answer"] = answers[i];
                //jsonObj[num].answer = answer;
            }

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(path, output);
        }

        public bool IsOptionsQuestion(int num)
        {
            Json_File j = new Json_File();

            string first = j.ReadOptions(num)[0];

            if (first != "null") //Check if it's an option question or a text question
            {
                return true;
            }

            return false;
        }

        public string ReadAnswer(string main)
        {
            dynamic json = ReadFile();

            foreach(var item in json)
            {
                if(item.main == main)
                {
                    return item.answer;
                }
            }

            return "null"; //In case didn't find
        }

        public Dictionary<string, string> ReadAllAnswers()
        {
            var dic = new Dictionary<string, string>();
            dynamic json = ReadFile();

            foreach (var item in json)
            {
                dic.Add(item.main.ToString(), item.answer.ToString());
            }

            return dic;
        }

        dynamic ReadFile()
        {
            string json = File.ReadAllText(path);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            return jsonObj;
        }

        public void ResetJson()
        {
            int length = arraySize();

            List<string> answers = new List<string>();
            for(int i = 0; i < length; i++)
            {
                answers.Add("");
            }

            ChangeAnswers(answers);
        }
    }
}
