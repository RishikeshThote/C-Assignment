﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_test1
{
    internal class Program
    {
        class Passanger
        {
            public String Name { get; set; }
            public int Age { get; set; }
            Ticket Ticket { get; set; }
            public Passanger(String name, int age)
            {
                Name = name;
                Age = age;
                Ticket = new Ticket();
            }
            public void TicketBooking(int tickets)
            {
                Ticket.Tickets = tickets;
                Console.WriteLine("Ticket Booked Successfully");



            }
        }
        class Ticket
        {
            public int tickets;
            public int Tickets



            {
                get => tickets;
                set
                {
                    if (value > 5)
                        throw new Exception("Cannot book more than 5 tickets");
                    else
                        tickets = value;
                }



            }



        }
        static void Main(string[] args)
        {
            Passanger passanger = new Passanger("Rishikesh", 5);
            Console.Write("Enter the number of tickets you want to book:");
            passanger.TicketBooking(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}