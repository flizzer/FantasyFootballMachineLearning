using Microsoft.ML.Runtime.Api;
using System;

public class QBFantasyGame
{
    [Column("0")]
    public float GameNumber; 

    //[Column("1")]
    //public DateTime Date;
    
    [Column("3")]
    public string Team;
    
    [Column("4")]
    public string Opponent;
    
    [Column("5")]
    public string Result;

    [Column("6")]
    public string Position;

    [Column("7")]
    public float Inside20PassCompletions;

    [Column("8")]
    public float Inside20PassAttempts;

    [Column("9")]
    public float Inside20PassYards;

    [Column("10")]
    public float Inside20PassTouchdowns;
    
    [Column("11")]
    public float Inside20RushAttempts;

    [Column("12")]
    public float Inside20RushYards;

    [Column("13")]
    public float Inside20RushTouchdowns;

    [Column("14")]
    public float Inside10PassCompletions;

    [Column("15")]
    public float Inside10PassAttempts;

    [Column("16")]
    public float Inside10PassYards;

    [Column("17")]
    public float Inside10PassTouchdowns;

    [Column("18")]
    public float Inside10RushAttempts;

    [Column("19")]
    public float Inside10RushYards;

    [Column("20")]
    public float Inside10RushTouchdowns;

    [Column("20")]
    public float OffensiveSnapNumber;

    [Column("21")]
    public string OffensiveSnapPercentage; 

    [Column("22")]
    public float DefensiveSnapNumber;

    [Column("23")]
    public string DefensiveSnapPercentage; 

    [Column("24")]
    public float SpecialTeamsSnapNumber;

    [Column("25")]
    public string SpecialTeamsSnapPercentage;

    [Column("26")]
    public float TotalFantasyPoints;
}