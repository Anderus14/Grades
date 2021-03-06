﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            /*GradeBook g2 = g1;

            g1.Name = "Scott's grade book";
            Console.WriteLine(g2.Name);*/
            GradeBook book = new GradeBook();
            book.Name = "Scott's Grade Book";
            book.Name = null;
            book.AddGrade(94);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average",stats.AverageGrade);
            WriteResult("Highest",(int)stats.HighestGrade);
            WriteResult("Lowest",stats.LowestGrade);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}
