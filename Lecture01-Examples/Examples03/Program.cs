﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLibrary;

namespace Examples03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("請輸入學生姓名");
            student.name = Console.ReadLine();
            Console.Write("請輸入學生電話");
            student.phone = Console.ReadLine();
            Console.Write("請輸入學生地址");
            student.address = Console.ReadLine();
            Console.WriteLine(
               "學生姓名:{0},電話:{1},住址:{2}"
               , student.name
               , student.phone
               , student.address
           );
        }
    }
}