//Void quiere decir que no va a devolver nada, el saludo el nombre del código y el parametro 

//Cuando un bloque de código no devuelve valor, se llama método, y cuando devuelve un valor de cualquier tipo se identifica como una función.
static void saludar(String nomsal)
{
    Console.WriteLine($"\tUn gran saludo a {nomsal}");

}

static int calculo_año_nacimiento(int edad)
{
    int añon = 2023 - edad;
    return añon;
}
//string nombre;
//int edad;
//char letra = 'a';
//String palabra = letra;

//Console.WriteLine("\tCómo te llamas?");
//nombre = Console.ReadLine();
//saludar(nombre);

//Console.WriteLine($"\tHola, gusto saludarte {nombre}\n\tCuántos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Bonida edad:{edad} \n\t naciste en {calculo_año_nacimiento(edad)}");

static void marque(String palabra)
{
    int longitud = palabra.Length;

    for (int c = longitud - 1; c >= 0; c--)
    {
        Console.SetCursorPosition(5 + c, 10);
        Console.WriteLine(palabra[c]);
        Thread.Sleep(500);

    }
}
static bool palindromo(String palabra)
{
    int longitud = palabra.Length;
    string pal = "";
    for (int c = longitud-1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();

    }
    if (palabra.Equals(pal))
    {
        return true;
    }
    return false;

}
String palabra;
palabra = "maria";
marque(palabra);
bool esPalindrom = palindromo("Ana".ToUpper());
if (esPalindrom)
{
    Console.WriteLine("\tEs palindromo");

}else
{
    Console.WriteLine("\tNel");
}

