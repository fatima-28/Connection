using System;
using System.Data.SqlClient;

namespace ConsoleApp6
{
    class Program
    {
        private const string connectstr = "Server=DESKTOP-4EOUDP3;Database=CLASSWORK;Integrated Security=true;";
        static void Main(string[] args)
        {

            //  insert

            //Console.Write("Enter your name:");
            //string Name = Console.ReadLine();
            //Console.Write("Enter your age:");
            //int Age = int.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection(connectstr);
            //
            //
            //conn.Open();
            //string query = $"INSERT INTO  STUDENT VALUES ('{Name}',{Age})";
            //SqlCommand command = new SqlCommand(query, conn);
            //int result = command.ExecuteNonQuery();
            //if (result < 1)
            //{
            //    Console.WriteLine("Hech bir proses getmedi");
            //}

            //conn.Close();


            //uptade
            //     Console.Write("enter your id:");

            // int id = int.Parse(Console.ReadLine());
            // Console.Write("enter your NAME:");
            //string NAME = Console.ReadLine();

            // SqlConnection conn = new SqlConnection(connectstr);
            // conn.Open();
            // string query2 = $"update STUDENT  set NAME = '{NAME}'   where id = {id}";
            // SqlCommand command = new SqlCommand(query2, conn);
            // int result = command.ExecuteNonQuery();
            // if (result < 1)
            // {
            //     Console.WriteLine("Hech bir proses getmedi");
            // }
            // conn.Close();


            //DELETE

            //Console.Write("enter your id:");

            //int ID = int.Parse(Console.ReadLine());


            //SqlConnection conn = new SqlConnection(connectstr);
            //conn.Open();
            //string query2 = $"DELETE FROM STUDENT WHERE ID = {ID}";
            //SqlCommand command = new SqlCommand(query2, conn);
            //int result = command.ExecuteNonQuery();
            //if (result < 1)
            //{
            //    Console.WriteLine("Hech bir proses getmedi");
            //}
            //conn.Close();

            //GROPUTASK

            //  insert

            //Console.Write("Enter GROUP name:");
            //string Name = Console.ReadLine();

            //Console.Write("Enter GROUP LIMIT:");
            //int LIMIT = int.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection(connectstr);

            //conn.Open();
            //string query = $"INSERT INTO [GROUP] VALUES ('{Name}',{LIMIT})";



            //SqlCommand command = new SqlCommand(query, conn);


            //try
            //{
            //    int result = command.ExecuteNonQuery();

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("bu adda qrup vardir");
            //}


            //conn.Close();




            //DELETE

            //Console.Write("ENTER GROUP ID:");
            //int ID = int.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection(connectstr);
            //conn.Open();
            //string query = $"DELETE FROM [GROUP] WHERE ID={ID}";
            //SqlCommand command = new SqlCommand(query, conn);
            //int result = command.ExecuteNonQuery();
            //if (result < 1)
            //{
            //    Console.WriteLine("Hech bir proses getmedi");
            //}
            //conn.Close();

            //update

            Console.Write("ENTER name:");
            string name = Console.ReadLine();
            Console.Write("ENTER GROUP ID:");
            int ID = int.Parse(Console.ReadLine());
            SqlConnection conn = new SqlConnection(connectstr);
            conn.Open();
            string query = $"update[GROUP] set name = '{name}' where id = {ID}";
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                int result = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                Console.WriteLine("bu adda qrup vardir");
            }




            //select all GROUP

            //SqlConnection conn = new SqlConnection(connectstr);
            //conn.Open();
            //string query = $"SELECT * FROM [GROUP]";
            //SqlCommand command = new SqlCommand(query, conn);
            //int result = command.ExecuteNonQuery();
            //if (result < 1)
            //{
            //    Console.WriteLine("Hech bir proses getmedi");
            //}
            //conn.Close();
        }
    }
}
