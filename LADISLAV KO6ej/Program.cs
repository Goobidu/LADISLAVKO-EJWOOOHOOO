Console.WriteLine("Chcete si zahrát?");
string odpoved = Console.ReadLine();
if (odpoved == "ano")
{
    Random cislojuhu = new Random();
    int cislobuhu = cislojuhu.Next(100);
    int count = 1;
    for (int i = 0; i < 100; i++)
    {
        int odpovedalejetointprotozejetocislovisco = Convert.ToInt32(Console.ReadLine());
        if (odpovedalejetointprotozejetocislovisco == cislobuhu)
        {
            Console.WriteLine("Výhra, měl jsi " + count + " pokusů");
            break;
        }
        else if (odpovedalejetointprotozejetocislovisco > cislobuhu)
        {
            Console.WriteLine("Vygenerované číslo je menší.");
            count++;
        }
        else if (odpovedalejetointprotozejetocislovisco < cislobuhu)
        {
            Console.WriteLine("Vygenerované číslo je větší.");
            count++;
        }
        else
        {
            Console.WriteLine("Špatnej znak ty troubo :-(");
        }
    }
}



