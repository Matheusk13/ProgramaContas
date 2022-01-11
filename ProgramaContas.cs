using System;
using System.Globalization;

class Program{


        static void Main(){

            Console.WriteLine("Olá bem vindo ao programa de contas básicas da sua casa!");
            Console.WriteLine("Quantas pessoas moram na sua casa?");
            var NumPessoa = Console.ReadLine();
            var np = int.Parse(NumPessoa);

            switch(np){
                case 1:
                    calc1p();
                break;
                case 2:
                    calc2p();
                break;
                default:
                    Console.WriteLine("Por hora nosso sistema trabalha somente com casais (2 pessoas na família)");
                break;
            }

            
    }

    static void calc1p(){
        Console.WriteLine("Qual o nome da pessoa?");
        var nome1 = Console.ReadLine();
        Console.WriteLine($"{nome1} trabalha?");
        var resp1 = Console.ReadLine();


        if(resp1 == "sim"){
            Console.WriteLine($"quanto {nome1} recebe por mês?");
            var sal1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"1-{nome1} recebe {sal1} reais por mês.");
            Console.WriteLine($"2-{nome1} recebe aproximadamente {sal1*12f} reais por ano.");
            Console.WriteLine($"3-Considerando a taxa de 20% de imposto de renda, o valor de imposto do seu salário no ano é de {sal1*12*0.2f} reais");

            var SalarioTotal = sal1;

            if(SalarioTotal>=15000){
                Console.WriteLine("Sua família é de classe Alta.");
            }
            
            else if (SalarioTotal<=14999 || SalarioTotal>3000){
                Console.WriteLine("Sua família é de classe Média.");
            }
            
            else{
                Console.WriteLine("Sua família é de classe Baixa.");
            }

            }            
        else
        {
            Console.WriteLine("Alguém da família precisa estar trabalhando.");
        }
    }

    static void calc2p(){
        Console.WriteLine("Qual o nome da primeira pessoa?");
        var nome1 = Console.ReadLine();
        Console.WriteLine($"{nome1} trabalha?");
        var resp1 = Console.ReadLine();
        Console.WriteLine("Qual o nome da segunda pessoa?");
        var nome2 = Console.ReadLine();
        Console.WriteLine($"{nome2} trabalha?");
        var resp2 = Console.ReadLine();


        if(resp1 == "sim" || resp2 == "sim"){
            Console.WriteLine($"Quanto os dois recebem por mês?");
            var sal1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"1- A família recebe {sal1} reais por mês.");
            Console.WriteLine($"2- Recebem aproximadamente {sal1*12f} reais por ano.");
            Console.WriteLine($"3-Considerando a taxa de 20% de imposto de renda, o valor de imposto do seu salário no ano é de {sal1*12*0.2f} reais");

            var SalarioTotal = sal1;

            if(SalarioTotal>=15000){
                Console.WriteLine("Sua família é de classe Alta.");
            }
            
            else if (SalarioTotal<=14999 || SalarioTotal>3000){
                Console.WriteLine("Sua família é de classe Média.");
            }
            
            else{
                Console.WriteLine("Sua família é de classe Baixa.");
            }

            }            
        else
        {
             Console.WriteLine("Alguém da família precisa estar trabalhando.");
        }
    }
}