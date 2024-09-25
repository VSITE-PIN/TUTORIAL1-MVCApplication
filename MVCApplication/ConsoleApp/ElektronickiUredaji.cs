using System;

public class ElektronickiUredjaj
{
    public string Naziv { get; set; }
    public string Proizvodjac { get; set; }
    public int GodinaProizvodnje { get; set; }

    public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
    {
        Naziv = naziv;
        Proizvodjac = proizvodjac;
        GodinaProizvodnje = godinaProizvodnje;
    }

    public virtual void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
    }
}