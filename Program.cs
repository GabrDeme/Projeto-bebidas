//entrada
string pepsi;
string cocacola;
string fanta;
string agua;
string leite;

Console.WriteLine(@$"                                       
//                                                                         ------------------------------
//                                                                         | Programa bebidas           |
//                                                                         | Informe a bebida escolhida |
//                                                                         | Pepsi                      |
//                                                                         | Coca-Cola                  |
//                                                                         | Fanta                      |
//                                                                         | Água                       |
//                                                                         | Leite                      |
//                                                                         ------------------------------
");

//recebe a operação escolhida
string bebida = Console.ReadLine().ToLower();

//processamento
string adGelo;

switch (bebida)
{
    case "pepsi":

        Console.WriteLine($"Gostaria de gelo na sua bebida?");
        adGelo = Console.ReadLine().ToLower();
        if (adGelo == "sim")
        {
            Console.WriteLine($"Será adcionado gelo na bebida");
        }
        else if (adGelo == "nao")
        {
            Console.WriteLine($"Não será adcionado gelo na bebida");
        }
        else
        {
            Console.WriteLine($"Essa variável não existe");
        }
        break;

    case "cocacola":
        Console.WriteLine($"Gostaria de gelo na sua bebida?");
        adGelo = Console.ReadLine().ToLower();
        if (adGelo == "sim")
        {
            Console.WriteLine($"Será adcionado gelo na bebida");
        }
        else if (adGelo == "nao")
        {
            Console.WriteLine($"Não será adcionado gelo na bebida");
        }
        else
        {
            Console.WriteLine($"Essa variável não existe");
        }
        break;

    case "fanta":
        Console.WriteLine($"Gostaria de gelo na sua bebida?");
        adGelo = Console.ReadLine().ToLower();
        if (adGelo == "sim")
        {
            Console.WriteLine($"Será adcionado gelo na bebida");
        }
        else if (adGelo == "nao")
        {
            Console.WriteLine($"Não será adcionado gelo na bebida");
        }
        else
        {
            Console.WriteLine($"Essa variável não existe");
        }
        break;

    case "agua":
        Console.WriteLine($"Não é possivel colocar gelo na bebida.");
        break;

    case "leite":
        Console.WriteLine($"Não é possivel colocar gelo na bebida.");
        break;

    default:
        Console.WriteLine($"Não é possivel entender qual bebida foi escolhida");
        break;
}