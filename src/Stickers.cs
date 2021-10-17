using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YourTable
{
    public class Stickers
    {
        public string GetRandom()
        {
            string path = @".\img\Stickers\";
            var files = Directory.GetFiles(path, "*.png");
            
            var rand = new Random();
            return files[rand.Next(files.Length)];
        }
    }
}