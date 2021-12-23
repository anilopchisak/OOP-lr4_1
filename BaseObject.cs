using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_лаба_4_часть_1
{
    class BaseObject
    {
		public Circle _circle;
		public BaseObject() { }
        public BaseObject(Circle circle)
        {
            this._circle = circle;
        }
        ~BaseObject()
		{
		}
        public void set_circle(Circle circle)
        {
            this._circle = circle;
        }

	}
}
