﻿
using System;
using Microsoft.VisualBasic;



public class Client
{
    private static int test;
        public int id;
        public string name;

        public Client()
        {
            
            Console.Write("Введите id клиента: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");
            Console.Write("Введите имя клиента: ");
            this.name = Console.ReadLine();
        }

        public void PrintClientInfo()
        {
            Console.WriteLine("ID клиента - " + id);
            Console.WriteLine("Имя клиента - " + name);
        }
    }
