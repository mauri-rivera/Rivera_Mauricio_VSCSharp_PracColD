// Tres matrices básicas
// Crea una matriz para contener los valores enteros 0 a 9.​

int[] numArray = new int[10];

for (int i = 0; i < 10; i++)
{
    Random num = new Random();
    numArray[i] = num.Next(10);
    Console.WriteLine(numArray[i]);
}

Console.WriteLine("------------------------------------------");

// Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​

string[] nombres = new string[] { "Tim", "Martin", "Nikki", "Sara" };

foreach (string nom in nombres)
{
    Console.WriteLine(nom);
}

Console.WriteLine("------------------------------------------");

// Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​

bool[] boolArray = new bool[10];
bool nomBool = true;

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        nomBool = true;
    }
    else
    {
        nomBool = false;
    }

    boolArray[i] = nomBool;
    Console.WriteLine(boolArray[i]);
}

Console.WriteLine("------------------------------------------");

// Lista de Sabores
// Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​

List<string> saboresHelados = new List<string>();

saboresHelados.Add("Vainilla");
saboresHelados.Add("Chocolate");
saboresHelados.Add("Canela");
saboresHelados.Add("Piña");
saboresHelados.Add("Frutilla");
saboresHelados.Add("Naranja");

foreach (string helado in saboresHelados)
{
    Console.WriteLine(helado);
}

Console.WriteLine("------------------------------------------");

// Imprime la longitud de esta lista después de construirla. ​

Console.WriteLine($"La cantidad de sabores de helados es: {saboresHelados.Count}");

Console.WriteLine("------------------------------------------");

// Imprime el tercer sabor de la lista y luego elimina ese valor. ​

Console.WriteLine(saboresHelados[2]);
saboresHelados.RemoveAt(2);

Console.WriteLine("------------------------------------------");

foreach (string helado in saboresHelados)
{
    Console.WriteLine(helado);
}

Console.WriteLine("------------------------------------------");

// Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​

Console.WriteLine($"La nueva cantidad de sabores de helados es: {saboresHelados.Count}");

Console.WriteLine("------------------------------------------");

// Diccionario de Información del Usuario
// Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​

Dictionary<string, string> infoUsuario = new Dictionary<string, string>();

infoUsuario.Add("Nombre1", "Mauricio");
infoUsuario.Add("Apellido", "Rivera");
infoUsuario.Add("Profesión", "Informático");

foreach (var datos in infoUsuario)
{
    Console.WriteLine($"{datos.Key}: {datos.Value}");
}

/* 
Añade pares clave/valor a este diccionario donde:​
    * cada clave sea un nombre de la matriz de nombres​
    * cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
*/
//infoUsuario.Remove("Nombre");
infoUsuario.Remove("Apellido");
infoUsuario.Remove("Profesión");

Console.WriteLine("------------------------------------------");

foreach (var datos in infoUsuario)
{
    Console.WriteLine($"{datos.Key}: {datos.Value}");
}

Console.WriteLine("------------------------------------------");

int j = 2;
for (int i = 0; i < nombres.Length; i++) {
    infoUsuario.Add($"Nombre{j}", nombres[i]);
    j++;
}

foreach (var nom in infoUsuario) 
{
    Console.WriteLine($"{nom.Key}: {nom.Value}"); 
}
