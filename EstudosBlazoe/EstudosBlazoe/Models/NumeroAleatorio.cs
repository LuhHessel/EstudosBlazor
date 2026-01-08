namespace EstudosBlazoe.Models
{
    public class NumeroAleatorio
    {
        public int NumeroIdentificador { get; set; }

        public NumeroAleatorio()
        {
            Random rnd = new Random();
            NumeroIdentificador = rnd.Next(0, 1000);
        }
    }
}
