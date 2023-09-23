using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Bank
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }





        public static string Transaction(Bank user1, Bank user2, decimal amount)
        {
            if (user1.Balance >= amount)
            {
                user1.Balance -= amount;
                user2.Balance += amount;     
            }
            
            Console.WriteLine($"{user1.User.UserName} transfer to {user2.User.UserName}  {amount} $  trasaction time {DateTime.Now}");
            return $"{user1.User.UserName} transfer to {user2.User.UserName}  {amount} $  trasaction time {DateTime.Now}";
        }

        public static string AddCash(decimal amount, Bank user)
        {
            if (amount > 0)
            {
                user.Balance += amount;
                Console.WriteLine($"Added {amount:C} to the account. new balance {user.Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            return $"Added {amount:C} to the account. new balance {user.Balance:C} Time {DateTime.Now}";
        }

        public void CashOut(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Cashed out {amount:C} from the account. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }



        public static void Writer(FileInfo f, string content)
        {
            using(StreamWriter sw = f.AppendText())
            {
                sw.WriteLine(content);
            }
        }
        public static void Writer(string path, string content)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
            }
        }


        public static void Reader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            } 
        }





        public override string ToString()
        {
            return $"AccountNumber {AccountNumber} Balance {Balance} User {User}";
        }
    }
}
