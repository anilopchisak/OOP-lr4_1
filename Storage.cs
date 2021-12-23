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
    class Storage
    {
		private List<BaseObject> _objects; //создание массива объектов
		private int _count; //количество объектов в массиве
		private int _size; //размер массива
		private int current;

		public Storage() //constructor with parameters
		{
			_size = 0;
			_count = 0;
			_objects = new List<BaseObject>();
			for (int i = 0; i < _size; i++) _objects[i] = null;
		}

		~Storage()
		{
			_objects.Clear();
		}

		public int getCount()
		{
			return _size;
		}

		public void addObject(int index, Circle b)
		{
			_objects.Add(new BaseObject(b));
			_count = _count + 1;
			_size = _size + 1;
			//setObject(index, b);
		}

		public void change_array()
        {
			List<BaseObject> _objects2 = new List<BaseObject>();
			int _count2 = 0; int _size2 = 0;
			for (int i = 0; i < _size; i++)
			{
				if (_objects[i] != null)
				{
					_objects2.Add(_objects[i]);
					_count2 = _count2 + 1;
					_size2 = _size2 + 1;
				}
			}
			_objects.Clear();
			for (int i = 0; i < _size2; i++) _objects.Add(_objects2[i]);
			//_objects = _objects2;
			_count = _count2; _size = _size2;

			_objects2.Clear(); _count2 = 0; _size2 = 0;
		}

		public void deleteObject(int index)
		{
			if (_objects[index] != null)
				_objects[index] = null;
		}

        public void set_current_index(int index)
        {
			current = index;
        }

		public Circle get_current_obj(int current)
        {
			return _objects[current]._circle; 
        }

		public int get_current_index()
        {
			return current;
        }
	}
}
