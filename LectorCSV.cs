using System;
using System.IO;
using EspacioCadeteria;
public class CargadorCsv
{
    public static Cadeteria CargarCadeteria(string archivoCsv)
    {
        using (var reader = new StreamReader(archivoCsv))
        {
            var line = reader.ReadLine(); // Leer la primera línea
            if (line != null)
            {
                var partes = line.Split(',');
                return new Cadeteria
                {
                    Nombre = partes[0].Trim(),
                    Numero = partes[1].Trim() // Convierte el número a int
                };
            }
            return null;
        }
    }

    public static List<Cadete> CargarCadetes(string archivoCsv)
    {
        var cadetes = new List<Cadete>();
        using (var reader = new StreamReader(archivoCsv))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var partes = line.Split(',');
                var cadete = new Cadete
                {
                    Id = int.Parse(partes[0].Trim()), // Convierte el ID a int
                    Nombre = partes[1].Trim(),
                    Direccion = partes[2].Trim(),
                    Telefono = partes[3].Trim() 
                };
                cadetes.Add(cadete);
            }
        }
        return cadetes;
    }
}