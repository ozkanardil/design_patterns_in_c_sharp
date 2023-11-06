// See https://aka.ms/new-console-template for more information
using ProxyDesignPatternModified.Assets;

Console.WriteLine("***Proxy Pattern Modified Demo***\n");

//Authorized user-Admin
ProxyModified px1 = new ProxyModified("Admin");
px1.DoSomeWork();

//Unwanted User-Manager
ProxyModified px2 = new ProxyModified("Manager");
px2.DoSomeWork();

//Unwanted User-Visitor
ProxyModified px3 = new ProxyModified("Visitor");
px3.DoSomeWork();

Console.ReadKey();