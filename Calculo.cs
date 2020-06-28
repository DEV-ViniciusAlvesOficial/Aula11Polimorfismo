namespace Aula11
{
    public class Calculo
    {
        public string Calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int vida){
            return "A vida do campeão é "+vida;
        }

        //Argumentos e parametros definem a sobrecarga
        public string Calcular(int vida, int escudo){
            return "A vida do champeão com escudo é " + (vida+escudo);
        }

        public string Calcular(string nome, string sobrenome){
            return "O campeão se chama " + (nome + sobrenome);
        }
    }
}