// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string pattern = "[A-Z]";

Regex regex = new Regex(pattern);

return regex.Replace("Hello World", match => $" {match}");

