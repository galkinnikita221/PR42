using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShopContent_Galkin.Modell
{
	public class Items : INotifyPropertyChanged
	{
		private int id;
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
		public int Id
		{
			get { return id; }
			set
			{
				id = value;
				OnPropertyChanged("Id");
			}
		}
		private string name;
		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				OnPropertyChanged("Name");
			}
		}
		private double price;
		public double Price
		{
			get { return price; }
			set
			{
				price = value;
				OnPropertyChanged("Price");
			}
		}
		private Categorys category;
		public Categorys Category
		{
			get { return category; }
			set
			{
				category = value;
				OnPropertyChanged("Category");
			}
		}
	}
}
