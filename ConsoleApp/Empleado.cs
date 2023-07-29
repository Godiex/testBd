namespace ConsoleApp;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Cargo { get; set; }
    public int DepartamentoId { get; set; }

    public Empleado(int id, string nombre, int edad, string cargo, int departamentoId)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
        Cargo = cargo;
        DepartamentoId = departamentoId;
    }
}