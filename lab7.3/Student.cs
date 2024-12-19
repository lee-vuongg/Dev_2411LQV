using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._3
{
    internal class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        private int theoryMark;
        private int labMark;

        public int TheoryMark
        {
            get { return theoryMark; }
            set
            {
                if (value < 0 || value > 10)
                    throw new InvalidMarkException($"Điểm lý thuyết không hợp lệ: {value}. Điểm phải trong khoảng 0-10.");
                theoryMark = value;
            }
        }

        public int LabMark
        {
            get { return labMark; }
            set
            {
                if (value < 0 || value > 10)
                    throw new InvalidMarkException($"Điểm thực hành không hợp lệ: {value}. Điểm phải trong khoảng 0-10.");
                labMark = value;
            }
        }

        public Student(string id, string name, int theoryMark, int labMark)
        {
            ID = id;
            Name = name;
            TheoryMark = theoryMark;
            LabMark = labMark;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {ID}, Name: {Name}, Theory Mark: {TheoryMark}, Lab Mark: {LabMark}");

        }
    }
