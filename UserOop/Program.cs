using System;

namespace UserOop
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuChoice();
        }
        static void MenuChoice()
        {
            Activity a = new Activity();
            bool isLoop = false;
            int menu;
            do
            {
                try
                {
                    Console.WriteLine("1.Create User");
                    Console.WriteLine("2.Show User");
                    Console.WriteLine("3.Search User");
                    Console.WriteLine("4.Login User");
                    Console.WriteLine("5.Delete User Data");
                    Console.WriteLine("6.Edit User Data");
                    Console.WriteLine("7.Exit");
                    Console.Write("Enter your menu (1-7): ");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            for (int i = 0; i < 1; i++)
                            {
                                Console.WriteLine("=====Create User========");
                                try
                                {
                                    User u = new User(a);
                                    a.CreateUser(u);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Input not invalid...");
                                    i--;
                                    AnyKey();
                                }
                            }
                            isLoop = true;
                            AnyKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("=====Show User========");
                            a.ShowUser();
                            isLoop = true;
                            AnyKey();
                            break;
                        case 3:
                            Console.Clear();
                            bool isLoopInner = false;
                            do
                            {
                                    if (a.user.Count > 0)
                                    {
                                        Console.WriteLine("=====Search User========");
                                        Console.Write("Input search keyword ");
                                        string nama = Console.ReadLine();
                                        a.SearchUser(nama);
                                    isLoopInner = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Data not found");
                                    isLoopInner = false;
                                    }
                                
                            } while (isLoopInner == true);
                            isLoop = true;
                            AnyKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("=====Login User========");
                            a.Login();
                            isLoop = true;
                            AnyKey();
                            break;
                        case 5:
                            Console.Clear();
                            if (a.user.Count > 0)
                            {
                                Console.WriteLine("=====Delete User========");
                                a.DeleteUser();
                            }
                            else
                            {
                                Console.WriteLine("Data not found");
                                isLoopInner = false;
                            }
                            isLoop = true;
                            AnyKey();
                            break;
                        case 6:
                            Console.Clear();
                            string userEdit;
                            if (a.user.Count > 0)
                            {
                                Console.WriteLine("=====Edit User========");
                            Console.Write("Enter username ");
                            userEdit = Console.ReadLine();
                            a.EditUser(userEdit);
                            }
                            else
                            {
                                Console.WriteLine("Data not found");
                                isLoopInner = false;
                            }
                            isLoop = true;
                            AnyKey();
                            break;
                        case 7:
                            isLoop = false;
                            break;
                        default:
                            Console.WriteLine("Menu not found!");
                            isLoop = true;
                            AnyKey();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Menu shoulb be number!");
                    AnyKey();
                    isLoop = true;
                }
                
            } while (isLoop == true);

            
            static void AnyKey()
            {
                Console.WriteLine("Press Any Key....");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }

    
}
