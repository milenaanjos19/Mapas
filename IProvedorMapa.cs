namespace Mapas;

public interface IProvedorMapa
{
    public string NomeProvedor { get; }

    string Mapa(string coordenadas);
    string Rotas(string origem,string destino);
}