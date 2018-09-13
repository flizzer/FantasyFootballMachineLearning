using System;

namespace model
{
    public class TestQBFantasyGame
    {

        //1,2012-09-09,ATL,KAN,W 40-24,QB,6,10,48,3,1,5,1,2,5,0,2,1,5,1,55,100.0%,0,0.0%
        //,0,0.0%,32.46
        public static QBFantasyGame QBFantasyGame1 = new QBFantasyGame
        {
            GameNumber = 1f,
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
    }
}
