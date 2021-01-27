using GameStore_Project1.Abstract;
using GameStore_Project1.Concrete;
using GameStore_Project1.Entities;
using System;
using System.Collections.Generic;

namespace GameStore_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.FirstName = "Can";
            player1.LastName = "Gündoğdu";
            player1.DateOfBirth = new DateTime(1990,5,19);
            player1.NationaltyNumber = "12345678910";

            Player player2 = new Player();
            player2.FirstName = "Fatma";
            player2.LastName = "Gündoğdu";
            player2.DateOfBirth = new DateTime(1992, 8, 22);
            player2.NationaltyNumber = "12345678911";
            Player[] players = new Player[] { player1, player2 };
            foreach (var player in players)//kullanıcı listesi
            {
                Console.WriteLine(player.NationaltyNumber + " " + player.FirstName + " " + player.LastName);
            }
            Console.WriteLine("---------------");
            string number = players[1].NationaltyNumber;
            Console.WriteLine("-------------------");
            if (players[1].NationaltyNumber == number)
            {
                Console.WriteLine("Giriş başarılı. Kullanıcı :" + players[1].FirstName);
            }
            /////////////////////////////////////////////////////////////
            Game game1 = new Game();
            game1.FirstName = "Pes2021";
            game1.Price = 20;
            game1.Stock = 10;


            Game game2 = new Game();
            game2.FirstName = "Tekken 5";
            game2.Price = 30;
            game2.Stock = 30;

            List<Game> game = new List<Game>();//oyun listesi
            game.Add(game1);
            game.Add(game2);

            for (int i = 0; i < game.Count; i++)
            {
                Console.WriteLine(game[i].FirstName+" "+game[i].Price+" "+game[i].Stock);
            }

            Console.WriteLine("---------------");
            BasePlayerService playerService = new GameManager();
            playerService.Add(players[0]);
            playerService.Update(game[1]);
            playerService.Delete(players[1]);

            Console.ReadLine();

        }
    }
}
