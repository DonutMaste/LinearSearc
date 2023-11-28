int[] vyskaLidi = new int[200];
string[] jmena = { "Gregor", "Lucie", "Martin", "Eva", "Petr", "Anna", "David", "Klára", "Jan", "Jana" };

Random vyska = new Random();
Random jmeno = new Random();

for (int j = 0; j < vyskaLidi.Length; j++)
{
    string randomjmeno = jmena[jmeno.Next(jmena.Length)];
    vyskaLidi[j] = vyska.Next(40, 220);
    Console.WriteLine($"{randomjmeno} - {vyskaLidi[j]}");


}


Console.WriteLine("Chci najít toho short člověka");
int zadanavyska = Convert.ToInt32(Console.ReadLine());

bool naseljsi = false;
for (int j = 0; j < vyskaLidi.Length; j++)
{
    string randomjmeno = jmena[jmeno.Next(jmena.Length)];
    if (zadanavyska == vyskaLidi[j])
    {
        naseljsi = true; ;
        Console.WriteLine("___ _   _  ___ ___ ___  ___ ___ \r\n/ __| | | |/ __/ __/ _ \\/ __/ __|\r\n\\__ \\ |_| | (_| (_|  __/\\__ \\__ \\\r\n|___/\\__,_|\\___\\___\\___||___/___/");
        Console.WriteLine($"V tomto seznamu se tato výška: {zadanavyska} nachází a jmenuje se {randomjmeno} :DDDD");

        if (zadanavyska <= 130)
        {
            Console.WriteLine("Toto je dítě");
        }
        else
        {
            Console.WriteLine("Toto je dospělý");
        }

        break;
    }
}

if (!naseljsi)
{
    Console.WriteLine($"V tomto seznamu se výška {zadanavyska} nenachází.");
}
