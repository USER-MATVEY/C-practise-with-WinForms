using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise_work_10
{
    public partial class house_creation : Form
    {
        public house_creation()
        {
            InitializeComponent();
        }

        private void Create_house_Click(object sender, EventArgs e)
        {
            
            try
            {
                string name = House_name.Text;
                int floors = Convert.ToInt32(floors_count.Text);
                int paradnie = Convert.ToInt32(paradnaya_count.Text);
                int apps_on_floors = Convert.ToInt32(apps_on_floor_count.Text);
                House house = new House(name, floors, paradnie, apps_on_floors);
                house.Info();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

    class House
    {
        private string name;
        private int floors;
        private int paradnayas;
        private int apps_on_floor;
        public House() { }
        public House(string name, int floors, int paradnayas, int apps_on_floor)
        {
            Name = name;
            Floors = floors;
            Paradnayas = paradnayas;
            Apps_on_floor = apps_on_floor;
        }

        public string Name
        {
            get => name;
            set => name = (value != "") ? value : "error";
        }
        public int Floors
        {
            get => floors;
            set => floors = (value <= 0) ? -1 : value;
        }
        public int Paradnayas
        {
            get => paradnayas; 
            set => paradnayas = (value < 1) ? -1 : value;
        }
        public int Apps_on_floor
        {
            get => apps_on_floor; 
            set => apps_on_floor = (value < 2) ? -1 : value;
        }

        public void Info()
        {
            string message = "";
            string caption = "";

            if (name != "error" && floors != -1 && paradnayas != -1 &&  apps_on_floor != -1) 
            {
                message += name + " - Здание на " + floors + " этажей с "
                    + paradnayas + " парадными и " + apps_on_floor + " квартирами на каждом этаже!!";
                caption += "Домик :З";
            }
            else
            {
                message += "Ошибка!! Что-то пошло не так апри строительстве и всё разволилось!!";
                caption += "Не домик :(";
            }
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
