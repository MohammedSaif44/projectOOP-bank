using System.Xml.Linq;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to our bank!");
            Bank bank=new Bank("MyBank", "001");
            Customer customer = new Customer();


            while (true)
            {
                Console.WriteLine("\n1. Add Customer");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Show Report");
                Console.WriteLine("5. remove customer");
                Console.WriteLine("6. update customer");
                Console.WriteLine("7. search customer");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 0) break;

                switch (ch)
                {
                    case 1:
                        Console.Write("Name: "); string n = Console.ReadLine();
                        Console.Write("NID: "); string nid = Console.ReadLine();
                        Console.Write("DOB (yyyy-mm-dd): "); string dob = Console.ReadLine();
                        bank.AddCustomer( n,  nid,  dob);
                        break;

                   
                    case 2:
                        Console.Write("Customer ID: "); int depId = int.Parse(Console.ReadLine());
                        Console.Write("Account No: "); int depAcc = int.Parse(Console.ReadLine());
                        Console.Write("Amount: "); double depAmt = double.Parse(Console.ReadLine());
                        var depCust = bank.SearchCustomer(depId.ToString());
                        if (depCust != null)
                            foreach (var acc in depCust.accounts)
                                if (acc.AccountId == depAcc) acc.Deposit(depAmt);
                        break;

                    case 3:
                        Console.Write("Customer ID: "); int wId = int.Parse(Console.ReadLine());
                        Console.Write("Account No: "); int wAcc = int.Parse(Console.ReadLine());
                        Console.Write("Amount: "); double wAmt = double.Parse(Console.ReadLine());
                        var wCust = bank.SearchCustomer(wId.ToString());
                        if (wCust != null)
                            foreach (var acc in wCust.accounts)
                                if (acc.AccountId == wAcc) acc.Withdrawing(wAmt);
                        break;

                    case 4:
                        bank.ShowReport();
                        break;
                    case 5:
                     // Remove Customer
                        Console.Write("Enter customer ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            bank.RemoveCustomer(removeId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid customer ID.");
                        }
                        break;
                    case 6: // Update Customer
                        Console.Write("Enter customer ID to update: ");
                        if (int.TryParse(Console.ReadLine(), out int updateId))
                        {
                            Console.Write("Enter new name: ");
                            string newName = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newName))
                            {
                                bank.UpdateCustomer(updateId, newName);
                            }
                            else
                            {
                                Console.WriteLine("Name cannot be empty.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid customer ID.");
                        }
                        break;
                    case 7: // Search Customer
                        Console.Write("Enter customer name  ");
                        string searchKey = Console.ReadLine();
                        Customer found = bank.SearchCustomer(searchKey);
                        if (found != null)
                        {
                            Console.WriteLine($"Customer found - ID: {found.CustomerId}, Name: {found.Fullname}, National ID: {found.NationalID}");
                        }
                        else
                        {
                            Console.WriteLine("Customer not found.");
                        }
                        break;





                }
            }
        }
    }
}
