using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarksAggregation
{
    class StudentMarks
    {
        int _numOfStudents;
        int _numOfSubjects;
        int[,] marks;
        public StudentMarks(int numOfStudents , int numOfSubjects, int[,] studentMarks)
        {
            if (numOfStudents != studentMarks.GetLength(0) || numOfSubjects != studentMarks.GetLength(1))
            {
                Console.WriteLine("Enter correct array with specified students and subjects");
            }
            else
            {
                _numOfStudents = numOfStudents;
                _numOfSubjects = numOfSubjects;
                marks = studentMarks;
            }

        }

        public int FindAverageSubjectIndex()
        {
            Dictionary<int, double> marksAverage = new Dictionary<int, double>();
            for (int i = 0; i < _numOfSubjects; i++)
            {
                List<int> subAverage = new List<int>();
                for (int j = 0; j < _numOfStudents; j++)
                {
                    subAverage.Add(marks[j, i]);
                }
                marksAverage.Add(i, subAverage.Average());
            }
            return marksAverage.OrderBy(t => t.Value).ToDictionary(t => t.Key, t => t.Value).First().Key;
        }

        public int[] TotalMarksExcludingSubject(int minSubjectIndex)
        {
            int[] resultMarks = new int[_numOfStudents];
            for (int i = 0; i < _numOfStudents; i++)
            {
                int totalMarks = 0;
                for (int j = 0; j < _numOfSubjects; j++)
                {
                    if (j != minSubjectIndex)
                        totalMarks += marks[i, j];
                }
                resultMarks[i] = totalMarks;
            }
            return resultMarks;
        }
    }
}
