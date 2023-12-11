using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q7
{

	internal class ManagerStudent
	{
		private List<Student> students;

		public ManagerStudent()
		{
			this.students = new List<Student>();
		}
		public string getRank(double avg)
		{
			if (avg >= 8.0)
			{
				return "GIOI";
			}
			else
			{
				if (avg >= 6.5)
				{
					return "KHA";
				}
				else
				{
					if (avg >= 5.0)
					{
						return "TB";
					}
					else
					{
						return "YEU";
					}
				}
			}
		}
		public void addStudentwithAvgRank(Student student)
		{
			double avg = (student.Math + student.Physical + student.Chemistry)/3;
			string rank = getRank(avg);
			Student rankedstudent = new Student(student.Name, student.Age, student.Math, student.Physical, student.Chemistry, avg, rank);
			students.Add(rankedstudent);
		}
		
		public List<Student> getGoodStudent()
		{
			List<Student> goodstudents = students.Where(x => x.Rank.Equals("GIOI")).ToList();
			return goodstudents;
		}
		public Student searchByName(string name)
		{
			Student? student = students.FirstOrDefault(x => x.Name == name);
			if (student != null)
				return student;
			else return null;
		}
		public List<Student> sortByName()
		{
			students = students.OrderByDescending(x => x.Name).ThenByDescending(x => x.Avg).ToList();
			return students;
		}
		public List<Student> smartSearch(string content)
		{			
			List<Student>? search_9 = students.Where(x => x.Name.Contains(content)).ToList();     //rank 9
			List<Student>? search_10 = search_9.Where(x => x.Name.Equals(content)).ToList();      //rank 10
			return search_9;
		}
	}
}
