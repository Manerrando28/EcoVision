namespace EcoVision.API.Models
{
    public class AlertaEmergencia
    {
        public int Id { get; set; }
        public int PontoAlagamentoId { get; set; }
        public string MensagemAlerta { get; set; } = string.Empty;
        public string NivelGravidade { get; set; } = "Moderado"; // Baixo, Moderado, Crítico
        public DateTime DataEmissao { get; set; } = DateTime.UtcNow;
    }
}