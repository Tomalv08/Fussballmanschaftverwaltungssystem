using Fussballverwaltungssystem;
using System.Xml.Linq;
using System;

public class Spieler : Mitglied, ISpieler, ITrainierbar
{
    public int spielstunden { get; private set; }

    public Spieler(string name, int alter, int gehalt) : base(name, alter, gehalt)
    {
        spielstunden = 0;
    }

    public virtual void Trainieren()
    {
        Console.WriteLine($"{name} trainiert.");
        spielstunden++;
    }

    public void Spielen()
    {
        Console.WriteLine($"{name} spielt ein Fußballspiel.");
    }

    public override void InfoAnzeigen()
    {
        Console.WriteLine($"Spieler: {name}, Alter: {alter}, Gehalt: {gehalt}, Spielstunden: {spielstunden}");
    }
}