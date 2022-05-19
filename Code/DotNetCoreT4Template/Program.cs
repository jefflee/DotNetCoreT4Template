// See https://aka.ms/new-console-template for more information
using System.Reflection;
using DotNetCoreT4Template.T4;

AppSettingsT4 settings = new AppSettingsT4();
string t = settings.TransformText();
Console.Write(t);
