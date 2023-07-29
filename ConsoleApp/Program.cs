using ConsoleApp;

RepositorioDepartamento repositorioDepartamento = new RepositorioDepartamento();
// repositorioDepartamento.Agregar("finanzas");

List<Departamento> departamentos = repositorioDepartamento.Consultar();

Console.WriteLine("Lista de Departamentos:");
foreach (var departamento in departamentos)
{
    Console.WriteLine($"Id: {departamento.Id}, Nombre: {departamento.Nombre}");
}