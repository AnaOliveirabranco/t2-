namespace T04_22
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, cargo;
            decimal salario;
            int tempo;

            Console.Write("Nome do funcionario: ");
            nome = Console.ReadLine();
            Console.Write($"Digite qual será o cargo de {nome} ? ");
            cargo = Console.ReadLine();
            Console.Write($"Qual salário inicial de {nome} como {cargo} ? ");
            salario = decimal.Parse(Console.ReadLine());
            Console.Write($"Por quantos meses voçê quer contratar {nome} ? ");
            tempo = int.Parse(Console.ReadLine());

            if (tempo >= 7)
            {
                Console.WriteLine($"{nome} será efetivado(a) como {cargo} com o salário no valor de {salario} ");
                Console.WriteLine($" Parabéms voçê faz parte da nossa equipe! ");
                Console.WriteLine();
            
            }
            else
            {
                Console.WriteLine($"{nome} será membro honorário como {cargo},  com o salario {salario}, pro {tempo} meses!");
                Console.WriteLine();
            }



        }
    }
}