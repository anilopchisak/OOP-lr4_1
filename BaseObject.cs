using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ооп_лаба_4_часть_1
{
    class BaseObject
    {
		//public Circle _circle;
		public BaseObject() { }
        //public BaseObject(Circle circle)
        //{
        //    this._circle = circle;
        //}
        ~BaseObject()
		{
		}
        public virtual void draw(PaintEventArgs e)
        {

        }
        public virtual bool ifselected(int _x, int _y)
        {
            return false;
        }
        public virtual void set_select(bool select) { }

        public virtual bool get_select() { return false; }

        public virtual int get_x() { return 0; }

        public virtual int get_y() { return 0; }

        //public void set_circle(Circle circle)
        //{
        //    this._circle = circle;
        //}

    }
}
