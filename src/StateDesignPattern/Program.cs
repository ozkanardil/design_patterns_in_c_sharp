// See https://aka.ms/new-console-template for more information
using StateDesignPattern.Assets;


Console.WriteLine("***State Pattern Demo***\n");
//Initially Tv is Off
Tv Tv = new Tv();
Console.WriteLine("User is pressing buttons in the following sequence: ");

Console.WriteLine("Off->Mute->On->On->Mute->Mute->Off\n");
//Tv is already in Off state
Tv.PressOffButton();
//Tv is already in Off state, still pressing the Mute button
Tv.PressMuteButton();
//Making the Tv on
Tv.PressOnButton();
//Tv is already in On state, pressing On button again
Tv.PressOnButton();
//Putting the Tv in Mute mode
Tv.PressMuteButton();
//Tv is already in Mute, pressing Mute button again
Tv.PressMuteButton();
//Making the Tv off
Tv.PressOffButton();
// Wait for user
Console.Read();