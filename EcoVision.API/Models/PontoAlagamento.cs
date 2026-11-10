namespace EcoVision.API.Models
{
    public class PontoAlagamento
    {
        public int Id { get; set; }
        public string Localizacao { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public double NivelAguaCm { get; set; }
        public bool RiscoTransbordo { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;
    }
}