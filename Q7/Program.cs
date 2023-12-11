using Q7;

Student s1 = new Student("Tuan", 27, 9.1, 9.5, 7.0);
Student s2 = new Student("Huy", 22, 9.3, 5.0, 8.7);
Student s3 = new Student("Ngoc", 19, 1.4, 7.5, 6.4);
Student s4 = new Student("Sy", 20, 3.6, 8.2, 9.7);
Student s5 = new Student("Minh", 18, 6.5, 4.5, 5.9);
Student s6 = new Student("Tuan", 24, 2.9, 10, 5.0);
Student s7 = new Student("Huyen", 33, 9.2, 7.1, 9.1);
Student s8 = new Student("Tuan", 17, 4.0, 0, 9.9);
ManagerStudent service = new ManagerStudent();
service.addStudentwithAvgRank(s1);
service.addStudentwithAvgRank(s2);
service.addStudentwithAvgRank(s3);
service.addStudentwithAvgRank(s4);
service.addStudentwithAvgRank(s5);
service.addStudentwithAvgRank(s6);
service.addStudentwithAvgRank(s7);
service.addStudentwithAvgRank(s8);

List<Student> goodstudents = service.getGoodStudent();
foreach (Student student in service.sortByName())
{
    Console.WriteLine(student.Name +"\t\t"+ student.Avg + "\t\t" + student.Rank);
}
