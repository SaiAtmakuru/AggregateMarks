using System;
using System.Collections.Generic;
using System.Linq;

namespace MarksAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test1 - with 3 students and 5 subjects 
            StudentMarks test1 = new StudentMarks(3, 5, new int[,] { { 75, 76, 65, 87, 87 }, { 78, 76, 68, 56, 89 }, { 67, 87, 78, 77, 65 } });
            int minSubjectIndex = test1.FindAverageSubjectIndex();
            int[] finalAggrgateMarks = test1.TotalMarksExcludingSubject(minSubjectIndex);
            Array.Sort(finalAggrgateMarks);
            Console.WriteLine(string.Join(" , ", finalAggrgateMarks));

            // Test2 - When students and subject count dosent match array length  
            // Output - says with message "Enter correct array with specified students and subjects"
            StudentMarks test2 = new StudentMarks(3, 4, new int[,] { { 75, 76, 65, 87, 87 }, { 78, 76, 68, 56, 89 }, { 67, 87, 78, 77, 65 } });

            //Test3 - with 5 students and 6 subjects 
            StudentMarks test3 = new StudentMarks(5, 6, new int[,] { { 75, 76, 65, 87, 87,99}, { 78, 76, 68, 56, 89 ,95 }, { 67, 87, 78, 77, 65,35 }, { 67, 87, 34, 77, 65, 35 }, { 67, 87, 78, 36, 65, 35 } });
            minSubjectIndex = test3.FindAverageSubjectIndex();
            finalAggrgateMarks = test3.TotalMarksExcludingSubject(minSubjectIndex);
            Array.Sort(finalAggrgateMarks);
            Console.WriteLine(string.Join(" , ", finalAggrgateMarks));
        }
    }
}
