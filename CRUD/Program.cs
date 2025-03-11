using PharmaCare.Models;
using System;
using System.Text.RegularExpressions; // for Regex
using System.Security.Cryptography; // for password encryption
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;
using System.Net;

namespace PharmaCare
{
    internal class Program
    {
        static string GetValidInput(string field)
        {
            string input;
            do
            {
                Console.WriteLine(field);
                input = Console.ReadLine()?.Trim();
            }
            while (string.IsNullOrEmpty(input));

            return input;
        }
        static DateTime GetValidDate(string field)
        {
            DateTime date;
            do
            {
                Console.WriteLine(field);
            }
            while (!DateTime.TryParse(Console.ReadLine()?.Trim(), out date));

            return date;
        }
        static string GetValidEmail()
        {
            string email;
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine()?.Trim();

                if (!emailRegex.IsMatch(email))
                    Console.WriteLine("Invalid email format, please try again");
            }
            while (!emailRegex.IsMatch(email));

            return email;
        }
        static string GetValidPassword()
        {
            string password;

            do
            {
                Console.Write("Password (min 8 characters: ");
                password = Console.ReadLine()?.Trim();

                if (password.Length < 8)
                    Console.WriteLine("Password must be at least 8 characters!");
            }
            while (password.Length < 8);

            return password;
        }
        static string HashPassword(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        static void Menu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Create");
            Console.WriteLine("Read");
            Console.WriteLine("Update");
            Console.WriteLine("Delete");
        }
        static void Ss()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an entity:");
            Console.WriteLine("Client");
            Console.WriteLine("Review");
            Console.WriteLine("Medicine");

            string Entity = Console.ReadLine().ToLower().Trim();

            switch (Entity)
            {
                case "client":
                    Menu();
                    string option = Console.ReadLine().ToLower().Trim();
                    switch (option)
                    {
                        case "create":
                            Console.WriteLine("Customer from:");

                            string firstName = GetValidInput("First Name");
                            string lastName = GetValidInput("Last Name");
                            string password = GetValidPassword();
                            string hashPassword = HashPassword(password);
                            string email = GetValidEmail();
                            string address = GetValidInput("Address");
                            DateTime birthDate = GetValidDate("Birth Date (YYYY-MM-DD)");

                            InsertClient(firstName, lastName, hashPassword, email, address, birthDate);
                            break;

                        case "read":

                            break;

                        case "update":

                            break;

                        case "delete":

                            break;
                        default:
                            Console.WriteLine("Invalid ooption, please try again");
                            break;
                    }
                     break;

                case "review":

                    break;

                case "medicine":

                    break;
            }




        }
        static void InsertClient(string firstName, string lastName, string hashPassword, string email, string address, DateTime birthDate)
        {
            using (var _context = new PharmaCareContext())
            {
                Client client = new Client
                {
                    FName = firstName,
                    LName = lastName,
                    HashPassword = hashPassword,
                    Email = email,
                    Address = address,
                    BirthDate = birthDate,
                    IsVendor = false
                };
                _context.Clients.Add(client);
                _context.SaveChanges();
            }
        }
    }
}
