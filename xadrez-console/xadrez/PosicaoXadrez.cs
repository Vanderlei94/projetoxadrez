using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {

        static Dictionary<char, char> TabelaCharacters = new Dictionary<char, char>();
        static PosicaoXadrez()
        {
            //Add Keys with respective values / tipo, A vale 0, isso? sim, complete e testa =]
            // vc pode configurar o tipo de dado aqui.. entendeu? sim =] ali poderia ser char, bool, ali que configura issso, usa muito para string tbm mas vai qqr coisa olha..
            TabelaCharacters.Add('a', (char)0);//CTRL + D tenta duplica a  selecao ou a linha tenta
            TabelaCharacters.Add('b', (char)1);//CTRL + K + D deixa o codigo organizado
            TabelaCharacters.Add('c', (char)2);
            TabelaCharacters.Add('d', (char)3);
            TabelaCharacters.Add('e', (char)4);
            TabelaCharacters.Add('f', (char)5);
            TabelaCharacters.Add('g', (char)6);
            TabelaCharacters.Add('h', (char)7);
            //Dictionary e um mapeamento saca? uma lista de referencias, o primeiro e chamado de Key(chave), segundo e value
        }

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = TabelaCharacters[coluna];//isso se chama cast, serve para converter o valor na frente no cast
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - TabelaCharacters['a']);//como assim numero - character (a = 97 decimal vai virar um numero baseado na tabela UTC)
        }
        public override string ToString()
        {
            return "" + coluna + linha;

        }
    }
}
