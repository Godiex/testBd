namespace ConsoleApp;

public class Departamento
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Departamento(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}