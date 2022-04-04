/*Já a passagem aérea contém a empresa aérea, classe, poltrona, valor, horário de embarque, data da passagem, 
VOO (que deverá ter numero, horário, destino e origem) e a escala (formada pela duração, local e horário de chegada) 
e qualquer outro atributo que julgar necessário. */


namespace AgenciaTurismo.Classes
{
    public class Passagem
    {
      public string EmpresaAerea {get; set;}
      public string Classe {get; set;}
      public int Poltrona {get; set;}
      public float Valor {get; set;}
      public int HorarioEmbarque {get; set;}
      public string DataPassagem {get; set;}

    }
}