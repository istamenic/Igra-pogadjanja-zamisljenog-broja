//Samo vezba

Random rnd = new Random();
int num = rnd.Next(100);
int x = 0;
int broj_pokusaja = 1;

Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
Console.WriteLine("******************** POGODI BROJ ***************************");
Console.WriteLine("↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑");
Console.WriteLine("\n► Ovo je igra pogadjanja zamisljenog broja.\n\n"
  + "► Ja cu zamisliti jedan broj izmedju 0 i 100.\n\n"
  + "► Ti pogadjaj koji je broj.\n\n"
  + "► Ako je broj veci ili manji od zamisljenog pogadjas ponovo.\n\n"
  + "► Kada pogodis broj recicu ti iz kog pokusaja si ga pogodio.\n\n"
  + @"► Srecna igra!!!
 ");
do
{
  Console.Write("Unesi broj: ");
  x = Convert.ToInt32(Console.ReadLine());
  if (x > num)
  {
    Console.WriteLine("Broj je veci od zamisljenog, pokusajte ponovo");
    broj_pokusaja++;
  }
  else if (x < num)
  {
    Console.WriteLine("Broj je manji od zamisljenog, pokusajte ponovo");
    broj_pokusaja++;
  }
  else
  {    
    Console.WriteLine($"\nCestitamo!!!!!\n\nPogodili ste broj iz {broj_pokusaja} pokusaja!");    
  }
}
while (x != num);