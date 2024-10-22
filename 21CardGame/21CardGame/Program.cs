using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _21CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text";
            //File.WriteAllText(@"\\Mac\Home\Desktop\Log.txt", text);
            // string text = File.ReadAllText(@"\\Mac\Home\Desktop\Log.txt");

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime YearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = YearOfGraduation - yearOfBirth;

            //// part of Constructor Chaining
            //Player player2 = new Player("Adam");

            // Creating a Global Unique Identifier
            //Guid identifier = Guid.NewGuid();


            Console.WriteLine("Welcome to the Grand Hotel and Casino. lets start by telling me your name.");
            string playerName = Console.ReadLine();
            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(); 
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine(); 
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter Digits only, no decimals!");
                }
            }




            Console.WriteLine("hello, {0}. Would you like to join a game of 21 right now?", playerName);

            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // creting the player object while passing into it the data of the player, their name and how much money they brough with them.
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                // This code will write the users Guid to the file
                using (StreamWriter file = new StreamWriter(@"\\Mac\Home\Desktop\Log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured, please contact your system admin.");
                        UpdateDbWithException(ex); 
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            // int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList() ;

            //List<int> numberlist = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //int sum = numberlist.Where(x => x > 20).Sum();


            
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                   (@ExceptionType, @ExceptionMessage, @TimeSTamp)" ;
            // using statement inside main is for managing and controlling memory when dealing with external resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close(); 
            }
             

        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection =  new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions; 
        }

       
    }

    //public enum DaysOfTheWeek { 
    //Monday,
    //Tuesday,
    //Wednesday,
    //Thursday,
    //Friday,
    //Saturday,
    //Sunday
    //}
}
