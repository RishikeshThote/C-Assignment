﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //studentmarks   1

    internal class Student
    {
        int rollno;
        String name;
        String branch;
        String sem;
        String clas;

        static public void displayResult()
        {
            int[] marks = new int[5];
            marks[0] = 23;
            marks[1] = 40;
            marks[2] = 30;
            marks[3] = 35;
            marks[4] = 44;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("the marks of " + i + " subs are: " + marks[i]);
            }

            double average = marks.Average();

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("FAILED");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("FAILED");
                }
                else if (average > 50)
                {
                    Console.WriteLine("PASSED");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
        public Student(int rollno, String name, String branch, String sem, String clas)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.sem = sem;
            this.clas = clas;
            Console.WriteLine($"\nRollno is: {rollno}, Name is {name},Student class is {clas}, Sem is {sem},Branch is : {branch}");
        }
        static public void displayData()
        {
            Console.WriteLine("\nthe marks: ");
        }
    }

    //car details  2

    internal class Car
    {
        int car_no;
        string car_name;
        string car_type;
        readonly double cost = 2000000;
        public Car(int car_no, string car_name, string car_type, double cost)
        {
            this.car_no = car_no;
            this.car_name = car_name;
            this.car_type = car_type;
            this.cost = cost;
            Console.WriteLine($"\nthe car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");
        }
        public void showDetails()
        {
            Console.WriteLine("\nbefore changing");
            Console.WriteLine($"the car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");
        }
        public Car(double car_cost)
        {
            Console.WriteLine("\nafter changing");
            car_cost = cost;
            Console.WriteLine($"the car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");

        }
    }

    //bank loan    3 
    internal class bank
    {
        double interestRate;
        public void loanCalculator(double loanamt)
        {
            Console.WriteLine("\nPlease enter rate of interest");
            interestRate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * interestRate) / 100;
            Console.WriteLine("\nRate of interest for " + interestRate + "(in percentage ) %  is : " + interest);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //student
            Student.displayResult();
            Student student = new Student(61, "Rishikesh", "mechanical", "8", "mechancial-A");
            Student.displayData();

            //car
            Car car = new Car(13, "SCARPIO", "XUV", 1500000);
            car.showDetails();
            Car car2 = new Car(2000000);
            
            
            //bank

            bank bank = new bank();
            Console.WriteLine("\nenter the loan amount: ");
            bank.loanCalculator(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();


        }
    }
}