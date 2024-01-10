// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern.Assets;
using BuilderDesignPattern.Builder;

Console.WriteLine("***Builder Design Pattern Demo***\n");

Director director = new Director();

// Build business computer
IBuilder businessComputer = new BusinessComputer("HP");
director.Construct(businessComputer);
Product productBusinessComputer = businessComputer.GetComputer();
productBusinessComputer.Show();

// Build gaming computer
IBuilder gamingComputer = new GamingComputer("Monster");
director.Construct(gamingComputer);
Product productGamingComputer = gamingComputer.GetComputer();
productGamingComputer.Show();