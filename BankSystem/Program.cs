using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank user1 = new Bank()
            {
                AccountNumber = "G45",
                Balance = 500,
                User = new User()
                {
                    UserName = "Jony",
                    LastName = "Smith",
                    Age = 24,

                }
            };


            Bank user2 = new Bank()
            {
                AccountNumber = "F67",
                Balance = 500,
                User = new User()
                {
                    UserName = "Mary",
                    LastName = "Pascal",
                    Age = 23,

                }
            };

          

            Console.WriteLine($"User1 {user1}\nUser2 {user2}");
            Console.WriteLine("--------------");

            Bank.Transaction(user1,user2,300);
            Bank.Transaction(user2, user1, 200);
            Bank.AddCash(1000,user2);
            user2.CashOut(2000);    
            

            Console.WriteLine("--------------");

            Console.WriteLine($"User1 {user1}\nUser2 {user2}");



            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/BankTransfer";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (!dir.Exists)
                dir.Create();
            DirectoryInfo subDir = dir.CreateSubdirectory("UserFolder");
            FileInfo fileInfo = new FileInfo(subDir.FullName + @"/User.txt");



            Bank.Writer(fileInfo, Bank.Transaction(user2, user1, 200));
            Bank.Writer(fileInfo, Bank.Transaction(user1, user2, 200));
            Bank.Writer(fileInfo, Bank.AddCash(1000, user2));
            Console.WriteLine("-----------");
            Bank.Reader(fileInfo.FullName);



        }
    }
}
