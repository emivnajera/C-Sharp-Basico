// See https://aka.ms/new-console-template for more information
List<string> listadeCompras = new List<string>();


listadeCompras.Add("Leche");
listadeCompras.Add("Huevos");
listadeCompras.Add("Carne");
listadeCompras.Add("Coca-Cola");


for(int i = 0; i < listadeCompras.Count; i++)
{
    Console.WriteLine(listadeCompras[i]);
}
listadeCompras.Remove("Carne");

Console.WriteLine();

for (int i = 0; i < listadeCompras.Count; i++)
{
    Console.WriteLine(listadeCompras[i]);
}