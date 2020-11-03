using System;
using System.Linq;

namespace FootballGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(";").ToArray();
            var team = new Team(input[1]);
            while (true)
            {
                var playersInput = Console.ReadLine().Split(";").ToArray();
                if (playersInput[0] == "END")
                {
                    break;
                }

                if (playersInput[0] == "Add")
                {
                    try
                    {
                        var stats = new Stats(int.Parse(playersInput[3]), int.Parse(playersInput[4]),
                            int.Parse(playersInput[5]), int.Parse(playersInput[6]), int.Parse(playersInput[7]));
                        var player = new Player(playersInput[2], stats);
                        team.Add(playersInput[1], player);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (playersInput[0] == "Remove")
                {
                    try
                    {
                        team.Remove(playersInput[2]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (playersInput[0] == "Rating")
                {
                    try
                    {
                        Console.WriteLine(team);
                    }
                    catch (Exception e )
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }
    }
}
