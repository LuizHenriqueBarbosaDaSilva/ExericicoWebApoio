namespace Apoio.Models
{
    public class Aposta 
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal PrevisaoDeGanho { get; set; }
        public bool Vencedora { get; set; }
        public int ApostadorId {  get; set; }
        public Apostador? Apostador { get; set; }

        public void atualizarSaldo() 
        { 
            if (Vencedora) 
            {
                Apostador.Saldo = Valor * PrevisaoDeGanho;    
            }
        }
    }
}
