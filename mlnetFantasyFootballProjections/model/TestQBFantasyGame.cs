using System;

namespace model
{
    public class TestQBFantasyGame
    {

        //1,2012-09-09,ATL,KAN,W 40-24,QB,6,10,48,3,1,5,1,2,5,0,2,1,5,1,55,100.0%,0,0.0%
        //,0,0.0%,32.46
        public static QBFantasyGame QBFantasyGame1 = new QBFantasyGame
        {
            GameNumber = "1",
            //Date = DateTime.Parse("2012-09-09"),
            Team = "ATL",
            Opponent = "KAN",
            Result = "W 40-24",
            Position = "QB",
            Inside20PassCompletions = 6f,
            Inside20PassAttempts = 10f,
            Inside20PassYards = 48f,
            Inside20PassTouchdowns = 3f,
            Inside20RushAttempts = 1f,
            Inside20RushYards = 5f,
            Inside20RushTouchdowns = 1f,
            Inside10PassCompletions = 2f,
            Inside10PassAttempts = 5f,
            Inside10PassYards = 0f,
            Inside10PassTouchdowns = 2f,
            Inside10RushAttempts = 1f,
            Inside10RushYards = 5f,
            Inside10RushTouchdowns = 1f,
            OffensiveSnapNumber = 55f,
            OffensiveSnapPercentage = "100.0%",
            DefensiveSnapNumber = 0f,
            DefensiveSnapPercentage = "0.0%",
            SpecialTeamsSnapNumber = 0f,
            SpecialTeamsSnapPercentage = "0.0%",
            FantPt = 0

        };

        public static QBFantasyGame BradyVsJax = new QBFantasyGame
        {
            GameNumber = "2",
            //Date = DateTime.Parse("2012-09-09"),
            Team = "NWE",
            Opponent = "JAX",
            Result = "L 20-31",
            Position = "QB",
            Inside20PassCompletions = 2f,
            Inside20PassAttempts = 4f,
            Inside20PassYards = 7f,
            Inside20PassTouchdowns = 1f,
            Inside20RushAttempts = 0f,
            Inside20RushYards = 0f,
            Inside20RushTouchdowns = 0f,
            Inside10PassCompletions = 1f,
            Inside10PassAttempts = 1f,
            Inside10PassYards = 0f,
            Inside10PassTouchdowns = 1f,
            Inside10RushAttempts = 0f,
            Inside10RushYards = 0f,
            Inside10RushTouchdowns = 0f,
            OffensiveSnapNumber = 61f,
            OffensiveSnapPercentage = "100.0%",
            DefensiveSnapNumber = 0f,
            DefensiveSnapPercentage = "0.0%",
            SpecialTeamsSnapNumber = 0f,
            SpecialTeamsSnapPercentage = "0.0%",
            FantPt = 0

        };

        public static QBFantasyGame RyanVsPanthers = new QBFantasyGame
        {
            GameNumber = "2",
            //Date = DateTime.Parse("2012-09-09"),
            Team = "ATL",
            Opponent = "CAR",
            Result = "W 31-24",
            Position = "QB",
            Inside20PassCompletions = 3f,
            Inside20PassAttempts = 3f,
            Inside20PassYards = 27f,
            Inside20PassTouchdowns = 2f,
            Inside20RushAttempts = 2f,
            Inside20RushYards = 9f,
            Inside20RushTouchdowns = 2f,
            Inside10PassCompletions = 1f,
            Inside10PassAttempts = 1f,
            Inside10PassYards = 0f,
            Inside10PassTouchdowns = 1f,
            Inside10RushAttempts = 2f,
            Inside10RushYards = 9f,
            Inside10RushTouchdowns = 2f,
            OffensiveSnapNumber = 62f,
            OffensiveSnapPercentage = "98.4%",
            DefensiveSnapNumber = 0f,
            DefensiveSnapPercentage = "0.0%",
            SpecialTeamsSnapNumber = 0f,
            SpecialTeamsSnapPercentage = "0.0%",
            FantPt = 0

        };
    }
}
