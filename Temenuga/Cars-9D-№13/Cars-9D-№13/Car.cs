using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Cars_9D__13
{
    internal class Car
    {
		private string marka;

		public string Marka
		{
			get { return marka; }
			set { marka = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private string  rNomer;

		public string  RNomer
		{
			get { return rNomer; }
			set { rNomer = value; }
		}

		private int godinaProizv;

		public int GodinaProizv
		{
			get { return godinaProizv; }
			set 
			{
				godinaProizv = value;
				//if (value<1768 || value>2000)
				//{
				//	Console.WriteLine("I’m NOT Eco CAR");				

    //            }
				//else
				//{
				//	Console.WriteLine("ECO");
                    
				//}
				 
			}
		}

		private static byte counter;

		public static byte Counter
		{
			get { return counter; }
			set { counter = value; }
		}
		public void EcoIs()
		{
			if (godinaProizv>1768 && godinaProizv<2000)
			{
				Console.WriteLine("I’m NOT Eco CAR");
			}
			else
			{
				if (godinaProizv>2000)
				{
                     Console.WriteLine("ECO");
				}
				
			}
		}

		public void MoveCar()
		{
			Console.WriteLine($"{this.Marka} {this.Model}: Brum-Brum !");
		}

		public void PrintMe()
		{
			Console.WriteLine($"{this.Marka} {this.Model} {this.RNomer} {this.GodinaProizv}");
		}

	
		//public Car( string marka,string model ,string rNomer,int godinaProizv)
		//{
		//	Marka = marka;
		//	Model = model;
		//	RNomer = rNomer;
		//	GodinaProizv=godinaProizv;
		//	counter++;
		//}
	}
}
