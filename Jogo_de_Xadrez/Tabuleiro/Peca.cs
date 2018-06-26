namespace Tabuleiro
{
    public class Peca
    {
        public Posicao posicao;
         public Cor cor {get ; private set; }
          public int qteMovimentos {get; private set;}
          public Tabuleiro tab {get; private set;}

          public Peca(Posicao posicao, Tabuleiro tab, Cor cor){
              this.posicao = posicao;
              this.tab = tab;
              this.cor = cor;
              this.qteMovimentos = 0;
          }
    }
}