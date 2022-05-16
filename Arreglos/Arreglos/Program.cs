// See https://aka.ms/new-console-template for more information


string[] tiposCafe;
float[] valores;

tiposCafe = new string[] { "Expreso", "Largo", "Filtrado", "Latte" };
valores = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

for(int i = 0; i < tiposCafe.Length; i++)
{
    Console.WriteLine(tiposCafe[i] + ": " + valores[i]);
}
