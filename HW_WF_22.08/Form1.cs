using HW_WF_22._08.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Создайте класс Банк , в котором будут следующие свойства : 
 money , name, percent
постройте класс так , чтобы при изменении класса создавался новый поток, 
который записывал данные о свлйствах класса в текстовый файл
 на жестком диске. Класс должен инкапсулировать в себе всю логику многопоточности*/
namespace HW_WF_22._08
{
    public partial class Form1 : Form
    {
        Controller.Controller controller = new Controller.Controller();
        public Form1()
        {
            InitializeComponent();

        }


      

        private void Form1_Load(object sender, EventArgs e)
        {

           
           listBoxCardData.DataSource =  controller.GetcardData();
           listBox1.DataSource = controller.GetLogData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "") 
            {
            controller.ChangeName(textBoxName.Text);
                textBoxName.Text = "";


            }
            if(textBoxMoney.Text !="")
            {
                
                controller.ChangeMoney(textBoxMoney.Text);
                textBoxMoney.Text = "";
            }
            if(textBoxpercent.Text!="")
            {
                controller.ChangePercent(textBoxpercent.Text);
                textBoxpercent.Text = "";
            }
            listBoxCardData.DataSource = controller.GetcardData();
            listBox1.DataSource = controller.GetLogData();
        }

    

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0'&& e.KeyChar <= '9') return;
            e.Handled = true;
        }

        private void textBoxpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            e.Handled = true;
        }
    }
}
