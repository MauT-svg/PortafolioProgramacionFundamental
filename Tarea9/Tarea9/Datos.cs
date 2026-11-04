using System.Collections.Generic;

public class Libro
{
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }
}

public static class Datos
{
    public static List<Libro> Libros = new List<Libro>();
}