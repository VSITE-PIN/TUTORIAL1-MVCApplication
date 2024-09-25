using System;

public class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    public override void IspisiInformacije()
    {
        base.IspisiInformacije();
        Console.WriteLine($"Operativni sustav: {OperativniSustav}");
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
    }
}