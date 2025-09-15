
//ID del estudiante: 1
// Retos C#

// Cuento 
string cuento = "En el vasto universo existía un ser llamado Bitín." +
" Bitín era un explorador intrépido, siempre buscando aventuras en el espacio." +
" A veces viajaba por ciudades luminosas y otras veces se encontraba en la inmensidad de la nube." +
" Sin embargo, un día se encontró con un firewall misterioso que bloqueaba su acceso a nuevos mundos." +
" A medida que avanzaba, se dio cuenta de que el firewall era más poderoso de lo que imaginaba." +
" Pero su mayor sueño era encontrar la respuesta a los misterios del cosmos, para comprender cómo funcionaba todo en el universo." +
" Mientras navegaba, pensó que tal vez necesitaría algo más que su nave para superar estos obstáculos." +
" En un mundo cercano, encontró los secretos del firewall y cómo evitar que bloqueara sus sueños.";



// Reto 1
string personaje = "Bitín";
string Palabra = personaje + " Explorador";
Console.WriteLine("Reto 1: " + Palabra + "\n");


// Reto 2
string[] oraciones = cuento.Split('.');
string oracionesJuntas = string.Join(" | ", oraciones);
Console.WriteLine("Reto 2: " + oracionesJuntas + "\n");

// Reto 3
int CantCaracteres = cuento.Length;
int CantPalabras = cuento.Split(' ').Length;
Console.WriteLine($"Reto 3: El cuento tiene {CantCaracteres} caracteres y {CantPalabras} palabras. \n");

// Reto 4
string nombre = "Bitín";
string metaDeBitin = "misterios del cosmos";
Console.WriteLine($"Reto 4: El protagonista es {nombre} y busca {metaDeBitin}.\n");

// Reto 5
string longitud = cuento.Length.ToString();
Console.WriteLine("Reto 5: El cuento tiene " + longitud + " caracteres.\n");

// Reto 6
int PosicionMundo = cuento.IndexOf("mundo");
Console.WriteLine("Reto 6: " + (PosicionMundo >= 0 ? $"Se encontró 'mundo' en la posición {PosicionMundo}\n" : "No se encontró 'mundo'.\n"));

// Reto 7
int PosicionCeros = cuento.LastIndexOf("ceros");
Console.WriteLine("Reto 7: " + (PosicionCeros >= 0 ? $"Se encontró 'ceros' en la posición {PosicionCeros}\n" : "No se encontró 'ceros'.\n"));

// Reto 8
bool HayPalabraNube = cuento.Contains("Nube");
Console.WriteLine("Reto 8: " + (HayPalabraNube ? "El cuento tiene la palabra Nube.\n" : "El cuento no tiene la palabra Nube.\n"));

// Reto 9
bool IniciaCon = cuento.StartsWith("En el vasto universo");
Console.WriteLine("Reto 9: " + (IniciaCon ? "El cuento empieza con 'En el vasto universo'.\n" : "El cuento no empieza con 'En el vasto universo'.\n"));

// Reto 10
bool TerminaCon = cuento.EndsWith("ceros");
Console.WriteLine("Reto 10: " + (TerminaCon ? "El cuento termina con 'ceros'.\n" : "El cuento no termina con 'ceros'.\n"));

// Reto 11
string subString = cuento.Substring(cuento.IndexOf("ciudades luminosas"), "ciudades luminosas".Length);
Console.WriteLine("Reto 11: " + subString + "\n");

// Reto 12
string cuentoIncompleto = cuento.Remove(0, 15);
Console.WriteLine("Reto 12: " + cuentoIncompleto + "\n");

// Reto 13
string cuentoConReemplazo = cuento.Replace("Bitín", "Programax");
Console.WriteLine("Reto 13: " + cuentoConReemplazo + "\n");

// Reto 14
string cuentoConInsercion = cuento.Insert(cuento.IndexOf("firewall") + "firewall".Length, " (IMPORTANTE)");
Console.WriteLine("Reto 14: " + cuentoConInsercion + "\n");

// Reto 15
string RellenarALaIzquierda = "Bitín".PadLeft(10, '*');
Console.WriteLine("Reto 15: " + RellenarALaIzquierda + "\n");

// Reto 16
string RellenarALaDerecha = "Nube".PadRight(12, '-');
Console.WriteLine("Reto 16: " + RellenarALaDerecha + "\n");

// Reto 17
string EliminacionDeEspacios = " firewall ".Trim();
Console.WriteLine("Reto 17: " + EliminacionDeEspacios + "\n");

// Reto 18
string EliminacionDeEspacionIniciales = " Mundo binario".TrimStart();
Console.WriteLine("Reto 18: " + EliminacionDeEspacionIniciales + "\n");

// Reto 19
string EliminacionDeEspaciosFinales = "Bitín explorador ".TrimEnd();
Console.WriteLine("Reto 19: " + EliminacionDeEspaciosFinales + "\n");

// Reto 20
string[] palabrasDelCuento = cuento.Split(' ');
Console.WriteLine("Reto 20: Las primeras 10 palabras son:");
for (int i = 0; i < 10 && i < palabrasDelCuento.Length; i++)
{
    Console.WriteLine(palabrasDelCuento[i]);
}

// Reto 21
bool SonIguales = "Nube".Equals("nube");
Console.WriteLine("\nReto 21: " + (SonIguales ? "Son iguales." : "No son iguales.\n"));

// Reto 22
int Comparacion = string.Compare("Bitín", "Firewall");
Console.WriteLine($"Reto 22: {Comparacion} \n");

// Reto 23
int Comparacion2 = "Nube".CompareTo("Cielo");
Console.WriteLine($"Reto 23: {Comparacion2}\n");

// Reto 24
bool EsNuloOEmpty = string.IsNullOrEmpty("");
Console.WriteLine("Reto 24: " + (EsNuloOEmpty ? "La cadena está vacía.\n" : "La cadena no está vacía.\n"));

// Reto 25
bool EsNuloOWhiteSpace = string.IsNullOrWhiteSpace("   ");
Console.WriteLine("Reto 25: " + (EsNuloOWhiteSpace ? "La cadena solo tiene espacios.\n" : "La cadena no tiene solo espacios.\n"));

// Reto 26
string CuentoConMinusculas = cuento.ToLower();
Console.WriteLine("Reto 26: " + CuentoConMinusculas + "\n");

// Reto 27
string CuentoConMayusculas = cuento.ToUpper();
Console.WriteLine("Reto 27: " + CuentoConMayusculas + "\n");

// Reto 28
string NubeEnMinuscula = "NUBE".ToLowerInvariant();
Console.WriteLine("Reto 28: " + NubeEnMinuscula + "\n");

// Reto 29
string BitinEnMayusculas = "bitín".ToUpperInvariant();
Console.WriteLine("Reto 29: " + BitinEnMayusculas + "\n");
