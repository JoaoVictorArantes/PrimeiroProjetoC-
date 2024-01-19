/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

//using System; //ja está implícito que o system esta sendo usado

// Retire o comentário da parte que você gostaria de testar.

namespace PrimeiroProjeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            String nomeCriador = "João Victor Almeida Arantes";
            Console.WriteLine(nomeCriador);


            /* ============= converção e casting de variaveis ============= 
             
            String a = "123";
            Console.WriteLine("valor: " + a + " tipo:" + a.GetType);
            int b = Convert.ToInt32(a);
            Console.WriteLine(" Sendo convertida para: " + b.GetType());

            String c = "321.1";
            Console.WriteLine("valor: " + c + " tipo:" + c.GetType);
            double d = Convert.ToDouble(c);
            Console.WriteLine(" Sendo convertida para: " + d.GetType());

            int e = 768;
            Console.WriteLine("valor: " + e + " tipo:" + e.GetType);
            String f = Convert.ToString(b);
            Console.WriteLine(" Sendo convertida para: " + f.GetType());

            Console.WriteLine("Qual o seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Olá, " + nome);
            Console.WriteLine("Você tem " + idade + " anos.");
            */

            //============= arithmetic operators ============= 
            /* 
            int dois = 2;
            
            dois = dois + 1; //3
            dois += 1; //3
            dois++; //3

            dois = dois * 2; //4 
            dois *= 2;//4 

            dois = dois / 2 ; //1
            dois /= 2; //1

            int resto = dois % 2; // 0
            Console.WriteLine(resto);
            
            Console.WriteLine(dois);
            */

            //============= Math class ============= 

            /*

            double numero = 3;
            double numero1 = 3.5701;
            double numero3 = 5;

            double a = Math.Pow(numero, 2); // pow de power = elevado a;  resultado: 9
            double b = Math.Sqrt(numero); // sqare root = raiz quadrada; resultado: 1,7320508075688772
            double c = Math.Abs(numero); // distancia desse numero até 0 (zero) também chamado em Pt/Br de valor absoluto; resultado: 3
            double d = Math.Round(numero1);// arredondar;  resulado: 4   
            double e = Math.Ceiling(numero1);// arredonda sempre pra cima; resutado: 4
            double f = Math.Floor(numero1);// arreonda sempre pra baixo; resultado: 3
            double g = Math.Max(numero, numero3); // maior numero entre os dois numeros; resultado: 5
            double h = Math.Min(numero, numero3); // menor numero entre os dois numeros; resultado: 3

            Console.WriteLine(numero);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            */

            //============= random numbers ============= 

            /* 
             
            Random random = new Random();

            int numero = random.Next(1, 7);// numero aleatorio de 1 a 6.  
            double numero1 = random.NextDouble();// numero aleatorio de 0 a 1


            Console.WriteLine(numero);
            Console.WriteLine(numero1);
            
            */

            //============= hypotenuse calculator program ============= 

            /*

            //questão : c = sqrt((a**2) + (b**2))

            Console.WriteLine("Digite o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());
 
            double hipotenusa = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
            */

            //============= string methods ============= 

            /*

            String nome = "João Victor Almeida Arantes";
            String numeroTelefone = "12345-6789";
            String nomeUsuario = nome; 

            String nomeUp = nome.ToUpper(); // pra maiusculo
            String nomeDown = nome.ToLower(); // pra minusculo
            numeroTelefone = numeroTelefone.Replace("-", ""); // troca o '-' por ''(nada)
            String nomeUsuario1 = nomeUsuario.Insert(0, "O bobo do "); // Adiciona na posição 0 o que está entre aspas duplas.
            String primeiroNome = nome;

            Console.WriteLine(nomeUp);
            Console.WriteLine(nomeDown);
            Console.WriteLine(numeroTelefone);
            Console.WriteLine(nomeUsuario);
            Console.WriteLine(nomeUsuario1);
            Console.WriteLine(nome.Length); // pega o tamanho
            Console.WriteLine(numeroTelefone.Length);// pega o tamanho
            Console.WriteLine(nomeUsuario.Length);// pega o tamanho
            Console.WriteLine(primeiroNome.Substring(0, 4)); // Cria outra String usando o index passado ('0') e a quantidade selecionada (4 caracteres) e cri outra string 

            */

            //============= if statements ============= 

            /*

            Console.WriteLine("Digite o seu nome: ");
            String nome = Console.ReadLine();

            if (nome == "")
            {
                Console.WriteLine("Degita seu nome!!! kkkkkkk");
            }
            else
            {
                 Console.WriteLine("Ola " + nome);
            }
            
            int hora = 20; 
            
            // MANEIRA CURTA DE FAZER UM IF ELSE EM C#!!!
            string resultado = (hora < 18) ? "Good day." : "Good evening."; // Se (if) o que esta em parenteses for verdadeiro então (?) bom-dia ao contrario (else :) boa noite. 
            Console.WriteLine(resultado); // variavel = (condição) ? casoVerdadeira :  casoFalso;

            */

            //============= switches =============

            /*

            Console.WriteLine("Digite o dia da semana: ");
            String diaSemana = Console.ReadLine();

            /*if (diaSemana == "Segunda")
            {
                Console.WriteLine("Hoje é segunda-feira!");
            }else if (diaSemana == "Terça")
            {
                Console.WriteLine("Hoje é Terça-feira!");
            }
            else if (diaSemana == "Quarta")
            {
                Console.WriteLine("Hoje é Quarta-feira!");
            }
            else if (diaSemana == "Quinta")
            {
                Console.WriteLine("Hoje é Quinta-feira!");
            }
            else if (diaSemana == "Sexta")
            {
                Console.WriteLine("Hoje é Sexta-feira!");
            }
            else if (diaSemana == "Sabado")
            {
                Console.WriteLine("Hoje é Sabado!");
            }
            else if (diaSemana == "Domingo")
            {
                Console.WriteLine("Hoje é Domingo!");
            }
            else
            {
                Console.WriteLine("Digite um dia da semana válido (com a PRIMEIRA letra maiuscula e sem o 'feira')");
            }// // NÃO É PRATICO FAZER ISSO, SUJEITO A XINGAMENTOS!
            
            switch (diaSemana)
            {
                case "Segunda": // Use ':' e não o ';'
                    Console.WriteLine("Hoje é Segunda-feira!");
                    break;
                case "Terça":
                    Console.WriteLine("Hoje é Terça-feira!");
                    break;
                case "Quarta":
                    Console.WriteLine("Hoje é Quarta-feira!");
                    break;
                case "Quinta":
                    Console.WriteLine("Hoje é Quinta-feira!");
                    break;
                case "Sexta":
                    Console.WriteLine("Hoje é Sexta-feira!");
                    break;
                case "Sabado":
                    Console.WriteLine("Hoje é Sabado!");
                    break;
                case "Domingo":
                    Console.WriteLine("Hoje é Domingo!");
                    break;
                default:
                    Console.WriteLine("Digite um dia da semana válido (com a PRIMEIRA letra maiuscula e sem o 'feira')");
                    break;
            }// Maneira otimizada de se fazer isso.


            */

            //============= logical operators && || =============

            /*

            Console.WriteLine("Digite a temperatura em cº");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura >= 10 && temperatura <= 25) // ambos tem que ser verdadeiro
            {
                Console.WriteLine("Está frio!");
            }
            else if(temperatura <= 50 || temperatura >= 50) // um deles pode ser verdadeiro
            {
                Console.WriteLine("NÃO SAIA DE CASA! RISCO DE VIDA!!!");
            }
            
            */

            //============= while loops =============

            /*
            
            String nome = "";

            while (nome == "")// enquanto a string estiver vazia, ele vai continuar perguntando o meu nome.
            {
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Olá " + nome);
            
            */

            //============= for loops =============

            /*

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Feliz Ano Novo!");

            */

            //============= nested loops =============

            /*

            Console.Write("Quantas colunas?");
            int colunas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas linhas?");
            int linhas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual simbolo?");
            String simbolo = Console.ReadLine();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(simbolo);
                }
                Console.WriteLine(); //pra mudar a linha
            }

            */

            //============= number guessing game =============

            /* MINHA MANEIRA DE RESOVER O PROBLEMA
            
            Random random = new Random();
            int numeroAleatorio = Convert.ToInt32(random.Next(1, 101));

            int numeroEscolhido = -1;

            //Console.WriteLine("Adivinhe o numero que está de 0-100: ");
            //numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            int opornidadesUsadas = 0;

            while ( numeroEscolhido != numeroAleatorio)
            {
                Console.WriteLine("Adivinhe o numero que está de 0-100: ");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());

                /* USANDO TERNARY OPERATOR

                String indice = "";

                //variavel = (condição) ? casoVerdadeira : casoFalso;

                indice = (numeroEscolhido < numeroAleatorio) ? numeroEscolhido + " está abaixo do aleatorio..."
                    : (numeroEscolhido > numeroAleatorio) ? numeroEscolhido + " está acima do aleatorio..."      
                    : "Você acertou o numero aleatorio!!! :)";
                
                Console.WriteLine(indice);

                *-/ // TIRE O '-' DAQUI PARA TESTAR AS MINHAS VERSÕES

                //* USANDO IF/ELSE NORMAL 
                          
                if (numeroEscolhido < numeroAleatorio )
                {
                    Console.WriteLine(numeroEscolhido + " está abaixo do aleatorio...");
                    oportunidadesUsadas++;
                }
                else if (numeroEscolhido > numeroAleatorio )
                {
                    Console.WriteLine(numeroEscolhido + " está acima do aleatorio...");
                    oportunidadesUsadas++;
                }
                else
                {
                    Console.WriteLine("Você acertou o numero aleatorio!!! :)");
                    Console.WriteLine("Você conseguiu em: " + opornidadesUsadas + " tentativa(s) :)");
                }
                
            }
            */

            /* VERSÃO DO CURSO

            Random ramdom = new Random();
            bool jogarNovamente = true;
            int min = 1;
            int max = 100;
            int oportunidadesUsadas;
            int numeroAleatorio;
            int numeroEscolhido;
            String resposta;

            while (jogarNovamente)
            {
                oportunidadesUsadas = 0;
                numeroEscolhido = 0;
                resposta = "";
                numeroAleatorio = ramdom.Next(min, max + 1);

                while (numeroEscolhido != numeroAleatorio)
                {
                    Console.WriteLine("Adivinhe o numero que está de "+ min + " - "+ max +" : ");
                    numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero escolhido: "+ numeroEscolhido);

                    if (numeroEscolhido > numeroAleatorio)
                    {
                        Console.WriteLine(numeroEscolhido + " está acima do aleatorio...");                        
                    }
                    else if (numeroEscolhido < numeroAleatorio)
                    {
                        Console.WriteLine(numeroEscolhido + " está abaixo do aleatorio...");                        
                    }
                    oportunidadesUsadas++;
                }

                Console.WriteLine("Numero: " + numeroEscolhido);
                Console.WriteLine("VOCÊ GANHOU!!! :)");
                Console.WriteLine("Chances: " + oportunidadesUsadas);

                Console.WriteLine("Gostaria de jogar novamente? (S/N)");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();

                if (resposta == "S")
                {
                    jogarNovamente = true;
                }
                else
                {
                     jogarNovamente = false;
                }
            }
            Console.WriteLine("Obrigado por jogar!");
            
            */


            //============= rock-paper-scissors game =============

            /*

            Random random = new Random();

            bool jogarNovamente = true;
            String escolhaUsuario;
            String escolhaMaquina = "";
            int index;
            String resposta = "";

            while (jogarNovamente)
            {

                Console.Write("Escolha entre: Pedra, papel ou tesoura: ");
                escolhaUsuario = Console.ReadLine();
                escolhaUsuario = escolhaUsuario.ToUpper();                

                switch (index = random.Next(1, 4))
                {
                    case 1:
                        escolhaMaquina = "PEDRA";
                        break;
                    case 2:
                        escolhaMaquina = "PAPEL";
                        break;
                    case 3:
                        escolhaMaquina = "TESOURA";
                        break;
                }

                if (escolhaUsuario == escolhaMaquina)
                {
                    Console.WriteLine("Foi um empate... :(");
                }
                else if (escolhaMaquina == "PEDRA" || escolhaUsuario == "Papel")
                {
                    Console.WriteLine("Você ganhou... :)");
                }
                else if (escolhaMaquina == "PAPEL" || escolhaUsuario == "TESOURA")
                {
                    Console.WriteLine("Você ganhou... :)");
                }
                else if (escolhaMaquina == "TESOURA" || escolhaUsuario == "PEDRA")
                {
                    Console.WriteLine("Você ganhou... :)");
                }
                else
                {
                    Console.WriteLine("Você perdeu... :(");
                }

                Console.WriteLine();
                Console.WriteLine("Sua Escolha: " + escolhaUsuario);
                Console.WriteLine("Escolha da maquina: " + escolhaMaquina);

                Console.WriteLine("Gostaria de jogar novamente? (S/N)");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();

                if (resposta == "S")
                {
                    jogarNovamente = true;
                }
                else
                {
                    jogarNovamente = false;
                }
            }
            Console.WriteLine( "Obrigado por jogar! :)");

            */

            //============= calculator =============

            /*

            double numero1, numero2;
            //char operacao = 'a';
            double resultado;

            do 
            {

                Console.WriteLine("=====================");
                Console.WriteLine("CALCULADORA DOS FODAS");
                Console.WriteLine("=====================");

                Console.Write("Digite o primeiro numero:");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual operação você gostaria de fazer? ");
                Console.WriteLine("\t+ : Soma");
                Console.WriteLine("\t- : Subtração");
                Console.WriteLine("\t* : Multiplicação");
                Console.WriteLine("\t/ : Divisão");

                //operacao = Convert.ToChar(Console.ReadLine());

                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "+":
                        resultado = numero1 + numero2;
                        Console.WriteLine($"Seu resultado é: {numero1} + {numero2} = "+ resultado);                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        Console.WriteLine($"Seu resultado é: {numero1} - {numero2} = " + resultado);
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        Console.WriteLine($"Seu resultado é: {numero1} * {numero2} = " + resultado);
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Seu resultado é: {numero1} / {numero2} = " + resultado);
                        break;
                    default:
                        Console.WriteLine("Opção invalida. :(");
                        break;
                }
                Console.WriteLine("Gostaria de continuar usando a calculadora? (S/N)");
            }while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Obrigado por usar minha calculadora! :)");

            */

            //============= ARRAYS =============

            /*

            //Array é uma variavel que pode conter vários valores.

            String[] carros = new string[4];

            //String[] carros = {"Bmw", "Fiat", "Ferrari" };

            carros[0] = "Bmw";
            carros[1] = "Fiat";
            carros[2] = "Ferrari";

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

            */

            //============= Foreach =============

            /*

            //Foreach é uma maneira mais simples de iterar um array mas é menos flexivel que o 'for' (não tem i++, i--, i+=2)

            
            String[] carros = {"Bmw", "Fiat", "Ferrari" };


            foreach (String carro in carros)
            {
                Console.WriteLine(carro);
            }

            */

            //============= Ativiade FoR =============

            /*
            int numero;


            Console.Write("Digite um valor inteiro maior que 1 e menor que 1000: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 1000 || numero < 1)
            {
                Console.WriteLine("Numero invalido... :(");
            }
            else
            {
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("FIM! :)");

            */

            //============= Metodos =============

            /*

            /* Metodos = usa uma seção do codigo quando ele é 'chamado';
             * Beneficios do metodo = Reutilzar partes do codigo sem ter que ficar repetindo a mesma coisa;
             * parametros = O que o metodo precisa receber para ser chamado
             /

            String nome = "João";
            int idade = 24;

            cantar(nome,idade);


            */

            //============= RETURN KEYWORD =============

            /*
            // TIRAR O "/*" "*'/" DO METODO MULTIPLICACAO
            //Retorna os dados para onde o metodo foi invocado/ chamado;

            double x, y, resultado;

            Console.Write("Digite o primeiro valor para ser multiplicado: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor para ser multiplicado: ");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = multiplicacao(x, y);

            Console.WriteLine(resultado);

            */

            //============= method overloading =============

            /*

            // TIRAR O "/*" "*'/" DO METODO MULTIPLICACAO E MULTIPLACAO2

            //  method overloading = metodos podem compartilhar o mesmo nome mas diferentes parametros;
            //  nome + parametros = asinatura do metodo;
            //  metodos devem ter uma assinatura única;

            double resultado;

            resultado = multiplicacao(2, 3,4);

            Console.WriteLine(resultado);

            */

            //============= params keyword =============

            // TIRAR O "/*" "*'/" DO METODO CHECKOUT


            /*

            //  by using the 'params' keyword a single method can receive several parameters whithout the need to create several methods;
            //  params keyword = um parametro do metodo que pode receber um numero varíável de argumentos;
            //  o tipo parametro deve ser um array unidimensional;

            double total = checkout(3.99, 5.75, 9.99, 15, 57.50);

            Console.WriteLine(total);

            */

            //============= exception handling =============

            /*

            //  exception = erros que ocorrem durante a execução;

            //  try = tenta um codigo conciderado 'perigoso';
            //  catch = pega uma exceção quando ela acontece;
            //  finally = sempre executa independente se a exceção é pega ou não;

            int numero1;
            int numero2;
            int resultado;

            try
            {

                Console.Write("Digite o numero 1: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o numero 2: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                resultado = numero1 / numero2;

                Console.WriteLine("Resultado: " + resultado);

            } catch (FormatException e)
            {
                Console.WriteLine("Digite um numero válido! :(");
            } catch (DivideByZeroException e) 
            {
                Console.WriteLine("Não é possivel dividir por zero! :(");
            }catch (Exception e) //Ele pega qualquer exceção que aparece. É problematico de usar pois fica dificil dizer o que aconteceu de errado. (Poor practice)
            {
                Console.WriteLine("Alguma coisa deu errado! :(");
            }   finally //Executa independente de ter erro ou não. Comum de ser usado para fechar arquivos pós uso. (Ex. após instalar/ desinstalar um programa)
            {
                Console.WriteLine(":)");
            }

            */

            //=============  =============

            /*

            //  String interpolation = Permite inserir variaveis em uma string (EX: Console.WriteLine("Esse tipo de String");)
            //  Precede de $
            //  {} é onde você vai colocar o nome da variavel na string.

            String primeiroNome = "João";
            String segundoNome = "Victor";
            int idade = 24;

            //Sem interpolação de String.
            Console.WriteLine("Olá, " + primeiroNome + " " + segundoNome + ", tudo bem? ");
            Console.WriteLine("Você tem " + idade + " de idade.");

            //Com interpolação de String.
            Console.WriteLine($"Olá, {primeiroNome} {segundoNome}, tudo bem? ");
            Console.WriteLine($"Você tem {idade,10} de idade.");// O ", 10" é para dar 10 espaços antes o valor da interpolação. (Pode ser qualquer valor, caso coloque um valor negativo muda pa onde vai os espaços)

            */

            //============= multidimensional arrays =============

            /*

            String[] fiat = { "Siena", "Palio", "Uno" };
            String[] honda= { "City", "Civic","Pcx"};
            String[] yamaha = {"Mt-03", "Mt-07", "R3" };

            String[,] concessionaria = { { "Siena", "Palio", "Uno" } , 
                                         { "City", "Civic", "Pcx" } , 
                                         { "Mt-03", "Mt-07", "R3" }
                                       };

            //Console.WriteLine(concessionaria[0, 2]);//concessionaria fila 0, coluna 2.

            concessionaria[1, 0] = "Hrv";
            concessionaria[2, 2] = "R1";

            /*
            foreach (String automovel in concessionaria)
            {
                Console.WriteLine(automovel);
            } 
            *-/

            for (int i = 0; i < concessionaria.GetLength(0); i++)
            {
                for (int j = 0; j < concessionaria.GetLength(1); j++)
                {
                    Console.Write($" {concessionaria[i,j]} ");
                }
                Console.WriteLine();
            }

            */

            //============= classes =============

            // PARA USAR TIRE O /* */ DAS SEGUINTES CLASSE: OLA, ESPERANDO E TCHAU;
            // OU USE A CLASSE MENSAGENS CRIADA FORA DESTE ARQUIVO

            /*

            // class = um pacote de codigo;
            // pode ser usado como um diagrama/blueprint para criar objetos em poo;

            Mensagens.ola();
            Mensagens.esperando();
            Mensagens.tchau();
             
            */

            //============= OBJETOS e construtores =============

            // TIRAR O /* *-/ DA CLASSE HUMANO

            /*

            //  Objetos são instancias de uma classe
            //  pode ser usado como um diagrama/blueprint para criar objetos em poo;
            //  Objetos tem campos e metodos (caracteristicas e ações);

            // Metodo especial de um objeto
            // tem o mesmo nome da classe
            // pode ser usado para designar argumentos para as caracteristicas/fields quando criando um objeto; 

            Humano humano1 = new Humano("João", 24);
            Humano humano2 = new Humano("Leonardo", 21);


            //humano1.nome = "João"; // Como eu criei um construtor eu posso colocar esses dados no momento da instanciação do objeto.
            //humano1.idade = 24;

            //humano2.nome = "Leonardo";
            //humano2.idade = 21;

            humano1.comer();
            humano1.dormir();

            humano2.comer();
            humano2.dormir();

            */

            //============= STATIC =============

            // TIRAR O /* *-/ DA CLASSE CARRO


            /*

            //  Modificador para declarar um membro estatico, que pertence a uma classe ao invés de um objeto em especifico.

            Carro carro = new Carro("Mustang");
            Carro carro1 = new Carro("Siena");
            Carro carro2 = new Carro("Fox");

            //Console.WriteLine(carro.numeroCarros); // Maneira não estatica = cada objeto terá o seu
            //Console.WriteLine(carro1.numeroCarros);

            Console.WriteLine(Carro.numeroCarros); // Maneira estatica = conta da classe como um todo e não de cada objeto da classe.

            Carro.comecoCorrida();
            Carro.fimCorrida();

            */

            //============= overloaded constructors =============

            // TIRAR O /* *-/ DA CLASSE PIZZA


            /*

            //  constructor overloading = Tecnica de criar multiplos construtores com diferentes parametros;
            //  nome + parametros = asinatura do metodo;
            //  metodos devem ter uma assinatura única;

            Pizza pizza = new Pizza("massa1", "Molho de tomate", "cheddar","Catupiri");
            Pizza pizza1 = new Pizza("massa2", "Molho a bolonhesa", "Prato");

            pizza.ingredientes();
            pizza1.ingredientes();


            */

            //============= inheritance =============

            // /*



            // */

            //============= abstract classes =============

            // /*



            // */

            //=============  =============

            // /*



            // */

            //=============  =============

            // /*



            // */

            //=============  =============

            // /*



            // */




            Console.ReadKey();
            Console.Beep();

        }

        /*
        static void cantar(String nome,int idade)
        {
            Console.WriteLine("Parabens para voce!");
            Console.WriteLine("Nessa data querida!");
            Console.WriteLine("Muitas felicidades!");
            Console.WriteLine("Muitos anos de vida!");
            Console.WriteLine("Viva "+ nome + " por seus " + idade + " anos!!!");
        }
        */
        /*
        static double multiplicacao(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
        */
        /*
        static double multiplicacao(double numero1, double numero2, double numero3)
        {
            return numero1 * numero2 * numero3;
        }
        */
        /*
        static double checkout(params double[] precos)
        {
            double total = 0;

            foreach (var preco in precos)
            {
                total += preco;
            }

            return total;
        }
        */

    }
    /*
    class mensagens
    {
        void ola()
        {
            Console.WriteLine("Olá! Tudo bem?");
        }

        void esperando()
        {
            Console.WriteLine("Estou esperando algo, o que? não sei kkkk");
        }

        void tchau ()
        {
            Console.WriteLine("Até mais! Obrigado por usar o meu programa! :)");
        }        
    }
    */
    /*
    class Humano
    {
        public String nome; //fields/ caracteristicas do objeto
        public int idade;//fieds/ caracteristicas do objeto

        public Humano (String nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void comer()//metodos são o que um objeto pode fazer
        {
            Console.WriteLine($"{nome} está comendo.");
        }

        public void dormir()//metodos são o que um objeto pode fazer
        {
            Console.WriteLine($"{nome} está dormindo.");
        }
    }
    */

    /*
    class Carro
    {
        String modelo;
        // public int numeroCarros; //maneira não estatica
        public static int numeroCarros; // Com o static isso se torna da classe e não do objeto.

        public Carro(String modelo)
        {
            this.modelo = modelo;
            numeroCarros++;
        }

        public static void comecoCorrida()
        {
            Console.WriteLine("Inicio da corrida!!! :)");
        }
        public static void fimCorrida()
        {
            Console.WriteLine("Fim da corrida!!! :(");
        }
    }
    */
    // /*
    class Pizza
    {
        public String molho;
        public String queijo;
        public String massa;
        public String recheioBorda;

        public Pizza(String massa, String molho, String queijo)
        {
            this.molho = molho;
            this.queijo = queijo;
            this.massa = massa;
        }
        public Pizza(String massa, String molho, String queijo, String recheioBorda)
        {
            this.molho = molho;
            this.queijo = queijo;
            this.massa = massa;
            this.recheioBorda = recheioBorda;
        }
        public void ingredientes()
        {
            Console.WriteLine($"A pizza tem a massa {massa}, com o molho {molho}, o queijo {queijo} e o recheio de {recheioBorda}");
        }
    }
    // */
}