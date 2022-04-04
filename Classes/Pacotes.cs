/*Os pacotes possuem, além da data de ida, a data da volta e o valor do pacote, uma série de serviços 
que ficam a critério do cliente contratar,como: almoço (que possui valor), jantar (que possui valor), 
café da manhã (que possui valor) e passeios locais (que possuem valor, local do passeio e horário).*/

namespace AgenciaTurismo.Classes
{
    public class Pacotes
    {
        public Passagem DataIda {get; set;}
        public Passagem DataVolta {get; set;}
        public float ValorPacote {get; set;}
        public float ValorAlmoco {get; set;}
        public float ValorJantar {get; set;}
        public float ValorCafe {get; set;}
        public float ValorPasseio {get; set;}
    }
}