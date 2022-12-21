using DesafioPOO.Models;

Nokia nokia = new Nokia("00-0000-0000","Nokia 5.4", "545621790546208", 4 );
Iphone iphone = new Iphone("00-0000-0000","Iphone X", "512687560165416", 8 );



        Console.WriteLine("Bem Vindo ao sistema arcaico de consulta para sistams operacionais mobile!");

        bool menu = true;

        string[] iphone_nokia = new string[2];
        iphone_nokia[0] = "1";
        iphone_nokia[1] = "2";

        Console.WriteLine("Digite 1 para Iphone ou 2 para Nokia");
        string opcao = Console.ReadLine();

    
        if (iphone_nokia[0] == opcao)
        {

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Visualizar número");
                Console.WriteLine("2 - Alterar número");
                Console.WriteLine("3 - Fazer ligação");
                Console.WriteLine("4 - Receber ligação");
                Console.WriteLine("5 - Aplicativos");
                Console.WriteLine("6 - Especificações tecnicas");

                switch(Console.ReadLine())
                {
                    case "1":
                        iphone.VisualizarNumero();
                        Console.WriteLine("Seu numero é: " + iphone.Numero);
                        break;
                    case "2":
                        Console.WriteLine("Digite seu novo número: ");
                        iphone.AlterarNumero(Console.ReadLine());
                        break;
                    case "3":
                        iphone.Ligar();
                        break;
                    case "4":
                        iphone.ReceberLigacao();
                        break;
                    case "5":
                        Console.WriteLine("Selecione o aplicativo que deseja instalar:");
                        Console.WriteLine("1 - ITunes");
                        Console.WriteLine("2 - Safari");
                        Console.WriteLine("Aguardando atualizações da loja...");
                        iphone.InstalarAplicativo(Console.ReadLine());
                        break;
                    case "6":
                        iphone.EspecificacoesTecnicas();
                        Console.WriteLine($"Modelo {iphone.Modelo}\nMemoria {iphone.Memoria} Gb\nEmei {iphone.Emei}");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();

            }

        }

          else if(iphone_nokia[1] == opcao)
            {   
                while(menu)
                {
                    Console.Clear();
                    Console.WriteLine("Opções:");
                    Console.WriteLine("1 - Visualizar número");
                    Console.WriteLine("2 - Alterar número");
                    Console.WriteLine("3 - Fazer ligação");
                    Console.WriteLine("4 - Receber ligação");
                    Console.WriteLine("5 - Aplicativos");
                    Console.WriteLine("6 - Especificações tecnicas");

                        switch(Console.ReadLine())
                    {
                        case "1":
                            nokia.VisualizarNumero();
                            Console.WriteLine("Seu numero é: " + nokia.Numero);
                            break;
                        case "2":
                            Console.WriteLine("Digite seu novo número: ");
                            nokia.AlterarNumero(Console.ReadLine());
                            break;
                        case "3":
                            nokia.Ligar();
                        break;
                        case "4":
                            nokia.ReceberLigacao();
                            break;
                        case "5":
                            Console.WriteLine("Selecione o aplicativo que deseja instalar:");
                            Console.WriteLine("1 - Google Play");
                            Console.WriteLine("2 - Mozila Firefox");
                            Console.WriteLine("Aguardando atualizações da loja...");
                            nokia.InstalarAplicativo(Console.ReadLine());
                            break;
                        case "6":
                            nokia.EspecificacoesTecnicas();
                            Console.WriteLine($"Modelo {nokia.Modelo}\nMemoria {nokia.Memoria} Gb\nEmei {nokia.Emei}");
                            break;
                
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();   
                    
                }
                
            }
        

