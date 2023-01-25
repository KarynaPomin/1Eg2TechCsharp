// Funkcje są nam znane z mat i z inf: f(x) WriteLine
// typ_zwracalny nazwa(parametry);
//{
//      instrukcje
//}

void przywitaj()
{
    Console.WriteLine("Witam Sensej");
}

przywitaj();
przywitaj();

// Napisz funkcję, która oblicza sumę przekazanych przez parametr 2 liczb

void suma1(int a, int b)
{
    Console.WriteLine(a + b);
}
suma1(4, 7);

int suma2(int x, int y)
{
    return (x + y);
}
Console.WriteLine(suma2(4, 7));

// Napisz funkcję dająca rabat(cewna, rabat) na towar
double Dajrabat(double cena, int rabat)
{
    return cena * (1 - rabat / 100d);
}
Console.WriteLine(Dajrabat(100d, 25));
