using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ооп_лаба_4_часть_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circle circle = new Circle();
        Storage storage = new Storage();
        int index = -1;
        bool ctrl = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool new_circle = true;
                for (int i = 0; i < storage.getCount(); i++) //для каждого объекта массива
                {
                    if (storage.get_current_obj(i).ifselected(e.X, e.Y) == true) //если на объект нажали
                    {
                        new_circle = false;
                        if (ctrl == true) 
                            storage.get_current_obj(i).set_select(true);
                        else
                        {
                            for (int j = 0; j < storage.getCount(); j++)
                            {
                                if (storage.get_current_obj(j).get_select() == true) //снимаем выделение у всех объектов
                                    storage.get_current_obj(j).set_select(false);
                               
                            }
                            storage.get_current_obj(i).set_select(true); //ставим выделение у объекта на который нажали
                        }
                    }
                }

                if (new_circle == true)
                {
                    for (int i = 0; i < storage.getCount(); i++) storage.get_current_obj(i).set_select(false); //снимаем выделение у всех объектов
                    circle = new Circle(e.X, e.Y);
                    index = index + 1;
                    storage.addObject(index, circle);
                    storage.get_current_obj(index).set_select(true);
                }
                Refresh();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl = true;
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < storage.getCount(); i++)
                    if (storage.get_current_obj(i).get_select() == true)
                    {
                        storage.get_current_obj(i).set_select(false);
                        storage.deleteObject(i);
                    }
                storage.change_array();
                storage.set_current_index(0);
                index = storage.getCount() - 1;
                
                Refresh();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                ctrl = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (storage.getCount() != 0)
            {
                for (int i = 0; i < storage.getCount(); i++) storage.get_current_obj(i).draw(e);
                storage.set_current_index(index);
            }
        }


    }
        
}
