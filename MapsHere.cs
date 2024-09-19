namespace Mapas;

public class  MapsHere : IProvedorMapa
{
    public string NomeProvedor { get;} = "MapsHere";

    public string Mapa(string coordenadas)
    {
        return $"Este é um mapa de MapsHere para" + $"as coordenadas: {coordenadas}";
    }

    public string Rotas(string origem, string destino)
    {
        return $"Está a rota: {origem} e {destino}" + $"usando MapsHere";
    }

    
}
