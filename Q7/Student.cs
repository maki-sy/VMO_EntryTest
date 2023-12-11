using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Math {  get; set; }
		public double Physical {  get; set; }
		public double Chemistry {  get; set; }
		public double Avg {  get; set; }
		public string Rank {  get; set; }

		public Student(string name, int age, double math, double physical, double chemistry)
		{
			Name = name;
			Age = age;
			Math = math;
			Physical = physical;
			Chemistry = chemistry;
		}

		public Student()
		{
		}

		public Student(string name, int age, double math, double physical, double chemistry, double avg, string rank) : this(name, age, math, physical, chemistry)
		{
			Avg = avg;
			Rank = rank;
		}
	}

}
