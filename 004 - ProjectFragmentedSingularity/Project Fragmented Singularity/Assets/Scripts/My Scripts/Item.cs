using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.My_Scripts
{
	class Item
	{
		private readonly string _name;
		private readonly int _id;

		public string name
		{
			get
			{
				return _name;
			}
		}


		public int id
		{
			get
			{
				return _id;
			}
		}

		public Item(string name, int id)
		{
			_name = name;
			_id = id;
		}

		/** Returns a copy of this item. */
		public Item copy()
		{
			return new Item(this.name, this.id);
		}
	}
}
