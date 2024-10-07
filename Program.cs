using D241007_13B_Vinklárik_Péter_CS3;
using System.Text;

List<olvas> Versenyzők = [];

using StreamReader sr = new(
    path: @"..\..\..\src\forras.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    Versenyzők.Add(new(sr.ReadLine()));
}
Console.WriteLine($"1.feladat: {Versenyzők.Count}");
/* Console.WriteLine($"2.feladat: 25 és 29 éves korú versenyzők száma: {Versenyzők}"); */
