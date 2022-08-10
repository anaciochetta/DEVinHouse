namespace aula0208.Infra
{
    public class LogAcao
    {
        public string CaminhoArquivo { get; set; }

        public LogAcao(string caminhoArquivo)
        {
            CaminhoArquivo = caminhoArquivo;
        }

        public void GravarLog(string texto) 
        {
            //aqui grava o log do arquivo
        }
    }
}
