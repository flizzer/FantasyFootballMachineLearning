using Microsoft.ML.Runtime.Api;
using System;

public class QBFantasyGame
{
    [Column("0")]
    public int GameNumber; 

    [Column("1")]
    public DateTime Date;
    
    [Column("3")]
    public string Team;
    
    [Column("4")]
    public string Opponent;
    
    [Column("5")]
    public string Result;

    [Column("6")]
    public string Position;

    [Column("7")]
    public int Inside20PassCompletions;

    [Column("8")]
    public int Inside20PassAttempts;

    [Column("9")]
    public int Inside20PassYards;

    [Column("10")]
    public int Inside20PassTouchdowns;
    
    [Column("11")]
    public int Inside20RushAttempts;

    [Column("12")]
    public int Inside20RushYards;

    [Column("13")]
    public int Inside20RushTouchdowns;

    [Column("14")]
    public int Inside10PassCompletions;

    [Column("15")]
    public int Inside10PassAttempts;

    [Column("16")]
    public int Inside10PassYards;

    [Column("17")]
    public int Inside10PassTouchdowns;

    [Column("18")]
    public int Inside10RushAttempts;

    [Column("19")]
    public int Inside10RushYards;

    [Column("20")]
    public int Inside10RushTouchdowns;

    [Column("20")]
    public int OffensiveSnapNumber;

    [Column("21")]
    public string OffensiveSnapPercentage; 

    [Column("22")]
    public int DefensiveSnapNumber;

    [Column("23")]
    public string DefensiveSnapPercentage; 

    [Column("24")]
    public int SpecialTeamsSnapNumber;

    [Column("25")]
    public string SpecialTeamsSnapPercentage;

    [Column("26")]
    public float TotalFantasyPoints;
}