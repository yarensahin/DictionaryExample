using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExample
{
    public class MyDictionary<TStudentID, TStudentName>
    {
        TStudentID[] studentIDs;
        TStudentName[] studentNames;

        public MyDictionary()
        {
            studentIDs = new TStudentID[0];
            studentNames = new TStudentName[0];

        }

        public void Add(TStudentID studentID,TStudentName studentName)
        {
            TStudentID[] tempID = studentIDs;
            TStudentName[] tempNames = studentNames;

            studentIDs = new TStudentID[studentIDs.Length + 1];
            studentNames = new TStudentName[studentNames.Length + 1];

            for (int i = 0; i < tempID.Length; i++)
            {
                studentIDs[i] = tempID[i];
                studentNames[i] = tempNames[i];
            }

            studentIDs[studentIDs.Length - 1] = studentID;
            studentNames[studentNames.Length - 1] = studentName;

        }

        public void Display()
        {
            Console.WriteLine("-----------------List of Students-----------------");
            for (int i = 0; i < studentIDs.Length; i++)
            {
                Console.WriteLine($"Id: {studentIDs[i]}  Name: {studentNames[i]}");
            }

        }
    }
}
