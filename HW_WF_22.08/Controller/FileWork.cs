using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_WF_22._08.Controller
{
    internal class FileWork
    {
        StreamReader Reader;
        StreamWriter Writer;
        string path = @"logg.txt";

      public  FileWork()
        {
            using (Writer = new StreamWriter(path, true))
            {
                Writer.WriteLine("Progran opened" + DateTime.Now);
                
            }
        }
            
        public void WriteToFile(string str)
        {
            try
            {
                using (Writer = new StreamWriter(path, true))
                {
                    Writer.WriteLine(str);
                  
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("1err");
            }

        }
      public List<string> ReadFromFile()
        {
           
            List<string> str = new List<string>();
            try
            { 
                  using (Reader = new StreamReader(path))
                  {
                    string line;
                    while ((line =  Reader.ReadLine())!=null)
                    {  
                        str.Add(line);
                       
                    }
                   
                  }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return str;
            }

            return str;


        }
    }
}
