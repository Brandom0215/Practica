
// ID del estudiante: 1
// Retos en C# 


// Ruta del archivo Cuento y lo guardamos en la variable contenido 
string Cuento = @"C:\Users\Adalberto\Practica\Cuento.txt";

// Nombre del archivo donde se guardarán los resultados
string Resultado = "Resultado.txt";

// Primero verificamos que exista el cuento en los archivos 
if (!File.Exists(Cuento))
{
    Console.WriteLine("No se encontró el archivo Cuento.txt");
    return;
}

// Se lee todo el contenido del cuento en una sola cadena
string contenido = File.ReadAllText(Cuento);

// Creamos el archivo Resultado.txt y escribimos los resultados
using (StreamWriter resultado = new StreamWriter(Resultado))
{

    // 1 -- string.Concat()
    Console.WriteLine("Reto 1: " + string.Concat("Bitín", " Explorador") + "\n");
    resultado.WriteLine("Reto 1: " + string.Concat("Bitín", " Explorador"));

    // 2 -- string.Join() 
    Console.WriteLine("Reto 2: " + string.Join(" | ", contenido.Split('.')) + "\n");
    resultado.WriteLine("Reto 2: " + string.Join(" | ", contenido.Split('.')));

    // 3 -- string.Format()
    Console.WriteLine("Reto 3: " + string.Format("El cuento tiene {0} caracteres y {1} palabras",
        contenido.Length, contenido.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length) + "\n");
    resultado.WriteLine("Reto 3: " + string.Format("El cuento tiene {0} caracteres y {1} palabras",
        contenido.Length, contenido.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length));

    // 4 -- string.Interpolation($"...")
    string nombre = "Bitín";
    string meta = "el conocimiento";
    Console.WriteLine($"Reto 4: El protagonista es {nombre} y busca {meta}\n");
    resultado.WriteLine($"Reto 4: El protagonista es {nombre} y busca {meta}");

    // 5 -- Convert.ToString.
    Console.WriteLine("Reto 5: " + Convert.ToString(contenido.Length) + "\n");
    resultado.WriteLine("Reto 5: " + Convert.ToString(contenido.Length));

    // 6 -- IndexOf()
    Console.WriteLine("Reto 6: " + contenido.IndexOf("mundo") + "\n");
    resultado.WriteLine("Reto 6: " + contenido.IndexOf("mundo"));

    // 7 -- LastIndexOf()
    Console.WriteLine("Reto 7: " + contenido.LastIndexOf("ceros") + "\n");
    resultado.WriteLine("Reto 7: " + contenido.LastIndexOf("ceros"));

    // 8 -- Contains()
    Console.WriteLine("Reto 8: " + (contenido.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'") + "\n");
    resultado.WriteLine("Reto 8: " + (contenido.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'"));

    // 9 StartsWith()
    Console.WriteLine("Reto 9: " + (contenido.StartsWith("En el vasto universo") ? "Sí inicia" : "No inicia") + "\n");
    resultado.WriteLine("Reto 9: " + (contenido.StartsWith("En el vasto universo") ? "Sí inicia" : "No inicia"));

    // 10 - EndsWith()
    Console.WriteLine("Reto 10: " + (contenido.EndsWith("ceros y unos.") ? "Sí termina" : "No termina") + "\n");
    resultado.WriteLine("Reto 10: " + (contenido.EndsWith("ceros y unos.") ? "Sí termina" : "No termina"));


    // 11 -- Substring()
    int pos = contenido.IndexOf("ciudades luminosas");
    Console.WriteLine("Reto 11: " + (pos >= 0 ? contenido.Substring(pos, "ciudades luminosas".Length) : "No encontrada") + "\n");
    resultado.WriteLine("Reto 11: " + (pos >= 0 ? contenido.Substring(pos, "ciudades luminosas".Length) : "No encontrada"));

    // 12 -- Remove()
    Console.WriteLine("Reto 12: " + contenido.Remove(0, 15) + "\n");
    resultado.WriteLine("Reto 12: " + contenido.Remove(0, 15));

    // 13 -- Replace()
    Console.WriteLine("Reto 13: " + contenido.Replace("Bitín", "ProgramaX") + "\n");
    resultado.WriteLine("Reto 13: " + contenido.Replace("Bitín", "ProgramaX"));

    // 14 -- Insert()
    int fw = contenido.IndexOf("firewall");
    Console.WriteLine("Reto 14: " + (fw >= 0 ? contenido.Insert(fw + "firewall".Length, "(IMPORTANTE)") : "No encontrado") + "\n");
    resultado.WriteLine("Reto 14: " + (fw >= 0 ? contenido.Insert(fw + "firewall".Length, "(IMPORTANTE)") : "No encontrado"));

    // 15 -- PadLeft()
    Console.WriteLine("Reto 15: " + "Bitín".PadLeft(10, '*') + "\n");
    resultado.WriteLine("Reto 15: " + "Bitín".PadLeft(10, '*'));

    // 16 -- PadRight()
    Console.WriteLine("Reto 16: " + "Nube".PadRight(12, '-') + "\n");
    resultado.WriteLine("Reto 16: " + "Nube".PadRight(12, '-'));

    // 17 -- Trim()
    Console.WriteLine("Reto 17: " + "   firewall   ".Trim() + "\n");
    resultado.WriteLine("Reto 17: " + "   firewall   ".Trim());

    // 18 -- TrimStart()
    Console.WriteLine("Reto 18: " + "   Mundo binario".TrimStart() + "\n");
    resultado.WriteLine("Reto 18: " + "   Mundo binario".TrimStart());

    // 19 -- TrimEnd()
    Console.WriteLine("Reto 19: " + "Bitín explorador   ".TrimEnd() + "\n");
    resultado.WriteLine("Reto 19: " + "Bitín explorador   ".TrimEnd());

    // 20 -- Split()
    var palabras = contenido.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine("Reto 20: " + string.Join(", ", palabras.Take(10)) + "\n");
    resultado.WriteLine("Reto 20: " + string.Join(", ", palabras.Take(10)));

    // 21 -- Equals()
    Console.WriteLine("Reto 21: " + ("Nube".Equals("nube") ? "Iguales" : "Diferentes") + "\n");
    resultado.WriteLine("Reto 21: " + ("Nube".Equals("nube") ? "Iguales" : "Diferentes"));

    // 22 -- Compare() 
    Console.WriteLine("Reto 22: " + string.Compare("Bitín", "Firewall") + "\n");
    resultado.WriteLine("Reto 22: " + string.Compare("Bitín", "Firewall"));

    // 23 -- CompareTo()
    Console.WriteLine("Reto 23: " + "Nube".CompareTo("Cielo") + "\n");
    resultado.WriteLine("Reto 23: " + "Nube".CompareTo("Cielo"));

    // 24 -- IsNullOrEmpty()
    string vacia = "";
    Console.WriteLine("Reto 24: " + (string.IsNullOrEmpty(vacia) ? "Cadena vacía" : "No vacía") + "\n");
    resultado.WriteLine("Reto 24: " + (string.IsNullOrEmpty(vacia) ? "Cadena vacía" : "No vacía"));

    // 25 -- IsNullOrWhiteSpace()
    string espacios = "   ";
    Console.WriteLine("Reto 25: " + (string.IsNullOrWhiteSpace(espacios) ? "Cadena solo con espacios" : "No") + "\n");
    resultado.WriteLine("Reto 25: " + (string.IsNullOrWhiteSpace(espacios) ? "Cadena solo con espacios" : "No"));

    // 26 -- ToLower()
    Console.WriteLine("Reto 26: " + contenido.ToLower() + "\n");
    resultado.WriteLine("Reto 26: " + contenido.ToLower());

    // 27 -- ToUpper()
    Console.WriteLine("Reto 27: " + contenido.ToUpper() + "\n");
    resultado.WriteLine("Reto 27: " + contenido.ToUpper());

    // 28 -- ToLowerInvariant()
    Console.WriteLine("Reto 28: " + "NUBE".ToLowerInvariant() + "\n");
    resultado.WriteLine("Reto 28: " + "NUBE".ToLowerInvariant());

    // 29 -- ToUpperInvariant()
    Console.WriteLine("Reto 29: " + "bitín".ToUpperInvariant() + "\n");
    resultado.WriteLine("Reto 29: " + "bitín".ToUpperInvariant());
}

Console.WriteLine("\nTodos los resultados se guardaron en " + Resultado);
