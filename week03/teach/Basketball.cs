/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            if (players.ContainsKey(playerId))
            {
                //added all the points related with a player
                players[playerId] += points;
            } else
            {
                players[playerId] = points;
            }
        }
        var playersPoints = players.ToArray();

        Array.Sort(playersPoints, (player1, player2) => player1.Value - player2.Value);

        for(int index = 0; index < 10;index++ ) {
            Console.WriteLine(playersPoints[index].Key, playersPoints[index].Value);

        }
        Console.ReadKey(); 
        Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        var topPlayers = new string[10];
    }
}