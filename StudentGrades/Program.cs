using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            

            static void Menu() {

                
                    Console.WriteLine("welcome to Lecturer Appliction \n" +
                                    "to add a student enter 1 ");
                    int result = int.Parse(Console.ReadLine());
                    switch (result)
                    {
                        case 1:
                            List<Lecturer> lecturersList = new List<Lecturer>();
                            CreatNewInstans(lecturersList);
                
                            break;
                            Menu();
                
                    }
               


            }
            Menu();

            List<string> studendList = new List<string>();
            ReadFile(studendList, "yhial");
            Console.WriteLine(studendList[1]);
            
        }


        static void CreatNewInstans(List<Lecturer> sList)
        {
            try
            {

                Console.WriteLine("Hello Lecturer, what is your name?");
                string LecturerName = Console.ReadLine();

                Console.WriteLine("How mane student you went to save?");
                int numOfStudent = int.Parse(Console.ReadLine());


                for (int i = 0; i < numOfStudent; i++)
                {
                    Lecturer lecturer = new Lecturer();
                    lecturer.lecturerName = LecturerName;

                    Console.WriteLine("what is the student name");

                    string stName = Console.ReadLine();
                    lecturer.studentName = stName;

                    Console.WriteLine("enter a taz");
                    string TazName = Console.ReadLine();
                    lecturer.taz = TazName;

                    lecturer.Grades = new List<int> { };

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("enter a grades:");
                        lecturer.Grades.Add(int.Parse(Console.ReadLine()));
                    }
                    sList.Add(lecturer);
                }
                SaveToFile(sList, LecturerName);


            }


            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void SaveToFile(List<Lecturer> sList, string nameLecturer)
        {
            int id = 0;
            FileStream FileStreamObj = new FileStream($@"C:\Users\liory\source\repos\{nameLecturer}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(FileStreamObj))
            {
                foreach (Lecturer someItem in sList)
                {
                    writer.Write($"ID:0-{id} lecturer Name: {someItem.lecturerName}, student Name: {someItem.studentName}, Taz: {someItem.taz} GRADE: ");
                    for (int j = 0; j < someItem.Grades.Count; j++)
                    {
                        writer.Write($"{someItem.Grades[j]},");
                    }
                    writer.WriteLine();
                    id++;
                }

            }
        }


        //Q num 9 

        static void ReadFile(List<string> List, string FileName)
        {
            try
            {

                FileStream fs2 = new FileStream($@"C:\Users\liory\source\repos\{FileName}.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fs2))
                {
                    for (int i = 0; i < reader.Peek(); i++)
                        List.Add(reader.ReadLine());
                }
                throw new ArgumentException("The list not found");
            }

            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

    }
}