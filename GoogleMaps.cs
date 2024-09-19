namespace Mapas;

public class GoogleMaps : IProvedorMapa
{
    public string NomeProvedor { get;} = "Google Maps";

    public string Mapa(string coordenadas)
    {
        
        return $"Este é um mapa de Gogle Maps para" + $"as coordenadas: {coordenadas}";
    }

    public string Rotas(string origem, string destino)
    {
        return $"Está a rota: {origem} e {destino}" + $"usando Google Maps";
    }

  
}