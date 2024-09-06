public class ManejoArchivo {
    public void lectorArchivo(string nombre, List<string[]> listaArreglo) {
    string nombreArchivo = nombre + ".csv";
    using (StreamReader sr = new StreamReader(nombreArchivo))
    {
        string linea;
        while ((linea = sr.ReadLine()) != null)
        {
            string[] datos = linea.Split(',');
            listaArreglo.Add(datos);
        }
    }
    }
}