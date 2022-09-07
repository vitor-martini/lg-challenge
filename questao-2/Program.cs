IDictionary<string, int> times = new Dictionary<string, int>();
string linha;
string time;
string maiorCampeao = "";
int maisTitulos = 0;

using (StreamReader reader = new StreamReader("F:\\Repositories\\prova-lg\\questao-2\\campeoes.csv"))
{
    for (int i = 0; i < 20; i++)
    {
        linha = reader.ReadLine();
        time = linha.Substring(linha.LastIndexOf(',') + 1);
        AdicionarTitulo(times, time);
    }
    Console.WriteLine(String.Format("O maior campeão é o {0} com {1} títulos.", maiorCampeao, maisTitulos));
}

void AdicionarTitulo(IDictionary<string, int> times, string time)
{
    int titulos;
    if(times.TryGetValue(time, out titulos))
        times[time] = titulos + 1;
     else    
        times.Add(time, 1);
    
    if (times[time] > maisTitulos)
    {
        maisTitulos = times[time];
        maiorCampeao = time;
    }
}