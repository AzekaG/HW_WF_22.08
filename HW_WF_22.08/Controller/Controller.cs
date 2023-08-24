using HW_WF_22._08.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_WF_22._08.Controller
{
    internal class Controller
    {
        Bank bank;
        FileWork fileWork;


        public Controller()
        {
            bank = new Bank();
            fileWork = new FileWork();
        }

        public List<string> GetcardData()
        {
            List<string> list = new List<string>();
            list.Add($"Name : {bank.Name}");
            list.Add($"Money :  {bank.Money} грн.");
            list.Add($"Percent  : {bank.Percent} %");
            return list;
        }
        public List<string> GetLogData()
        {
            return fileWork.ReadFromFile();
        }

        public void ChangeName(string Name)
        {
            bank.Name = Name;
            Thread thr = new Thread(Logger);
            thr.Start($"Изменение money : {bank.Name}  {DateTime.Now} ");

            
        }
        public void ChangePercent(string Percent) 
        {
            bank.Percent = int.Parse(Percent);
            Thread thr = new Thread(Logger);
            thr.Start($"Изменение money : {bank.Percent}  {DateTime.Now} ");
         




           
        }
        public void ChangeMoney(string  Money)
        {
            bank.Money = int.Parse(Money);
            Thread thr = new Thread(Logger);
            thr.Start($"Изменение money : {bank.Money}  {DateTime.Now} ");
        
        }
       





        void Logger(object str)

        {
            string res = str as string;
            fileWork.WriteToFile(res);
        }





    }
}
