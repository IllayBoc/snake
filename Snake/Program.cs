using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

		// HomeWork
			List<char> symList = new List<char>();
			symList.Add('@');
			symList.Add('&');
			symList.Add('$');

			char Q = symList[0];
			char W = symList[1];
			char E = symList[2];
		// HomeWork

			List<int> numList = new List<int>();
			numList.Add(0);
			numList.Add(1);
			numList.Add(2);

			int x = numList[0];
			int y = numList[1];
			int z = numList[2];

			foreach(int i in numList)
			{
				Console.WriteLine(i);
			}
			
			numList.RemoveAt(0);

		// HomeWork
			Point p3 = new Point(x, z, Q);
			p3.Draw();
			Point p4 = new Point(y, x, E);
			p4.Draw();

			List<Point> pList_HW = new List<Point>();
			pList_HW.Add(p1);
			pList_HW.Add(p2);
			pList_HW.Add(p3);
			pList_HW.Add(p4);
			// HomeWork

			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);

				Console.ReadLine();
		}
	}
}
