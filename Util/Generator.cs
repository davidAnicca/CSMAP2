using System;
using System.Collections.Generic;
using System.IO;
using CSMAP.Entities;

namespace CSMAP.Util
{
    public static class Generator
    {
        public static void GenerateStudends()
        {
            Dictionary<String, String> schoolsTeams = GetSchools();
            Random random = new Random();
            List<string> studentNames = new List<string> {"Ion", "Maria", "Ana", "Gheorghe", "Elena", "Adrian", "Mihai", "Ioana", "Gabriel", "Diana", "Alexandru", "Raluca", "Cristian", "Andreea", "Marius", "Oana", "Lucian", "Roxana", "Paul", "Loredana", "Bogdan", "Iulia", "Catalin", "Adriana", "Ionut", "Georgeta", "Tudor", "Carmen", "Dragos", "Dora"};
            List<Student> students = new List<Student>();
            int id = 1;
            using (var writer = new StreamWriter("students.csv"))
            {
                foreach (var school in schoolsTeams.Keys)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        var studentName = studentNames[random.Next(studentNames.Count)] + "-" + studentNames[random.Next(studentNames.Count)];
                        writer.WriteLine($"{id},{studentName},{school}");
                        id++;
                    }
                }
            }
        }

        private static Dictionary<string, string> GetSchools()
        {
            Dictionary<string, string> schoolsTeams = new Dictionary<string, string>();

            // Citirea datelor din fisier
            using (var reader = new StreamReader("scoliEchipe.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // Adaugarea datelor in dictionar
                    schoolsTeams.Add(values[0], values[1]);
                }
            }

            return schoolsTeams;
        }
    }
}