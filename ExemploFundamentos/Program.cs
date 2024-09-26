using System.Data;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using ExemploFundamentos.Common.models;




 Pessoa p = new Pessoa();
 p.Nome="israel";
 p.Idade=22;
 p.Apresentar();










// bool exibirMenu = true; 
// string opcao;
// while(exibirMenu)
// {
//     System.Console.WriteLine("Digite sua opção:");
//     System.Console.WriteLine("1 - Cadastrar cliente");
//     System.Console.WriteLine("2 - Buscar cliente");
//     System.Console.WriteLine("3 - Apagar cliente");
//     System.Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();
    

//     Console.Clear();
//     Console.WriteLine("-------------------------------\n\n\n\n");

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente"); break;
//         case "2": 
//             Console.WriteLine("Buscar Cliente"); break;
//         case "3": 
//             System.Console.WriteLine("Apagar cliente"); break;
//         case "4": 
//             System.Console.WriteLine("Encerrar");
//             exibirMenu=false;
//             //Environment.Exit(0);
//              break;
//         default: 
//             System.Console.WriteLine("Opção inválida !"); break;
//     }
//     Console.WriteLine("-------------------------------\n\n");
// }

















// int numero = 10;

//  System.Console.WriteLine("-----------------------For-----------------------------");
// for(int cont=0;cont <= 10; cont++)
// {
//     System.Console.WriteLine($"{numero} x {cont} = {numero * cont}");
// }
//  System.Console.WriteLine("-----------------------While-----------------------------");
// int cont2 =0;
// while(cont2 <= 10){
//  System.Console.WriteLine($"{numero} x {cont2} = {numero * cont2}");
//  cont2++;
//  if(cont2 == 8){
//     break;
//  }
// }
//  System.Console.WriteLine("-----------------------DoWhile-----------------------------");
//   int entrada = 0 , soma = 0;
// do{
//  System.Console.WriteLine("Digite um Numero maior que zero para somar \n Digite Zero para parar o Programa");
//  System.Console.WriteLine($"Soma atual: {soma}");
//  entrada = Convert.ToInt32(Console.ReadLine());
//  soma += entrada;

// }while(entrada != 0);

// System.Console.WriteLine($"Total da Soma: {soma}");



















// Calculadora calc = new Calculadora();

// calc.Somar(10,5);
// calc.Subtrair(10,5);
// calc.Multiplicar(10,5);
// calc.Dividir(10,5);
// calc.Potencia(3,3);
// calc.Modulo(10,5);
// calc.Incrementar(10);
// calc.Decrementar(10);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.RaizQuadrada(9);










// bool choveu = false;
// bool estaTarde = true;

// if(!choveu && !estaTarde){
//     System.Console.WriteLine("Vou Pedalar");
// }
// else{
//     System.Console.WriteLine("Vou pedalar um outro dia");
// }














// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// // if(letra == "a"){
// //     System.Console.WriteLine("Está letra e uma vogal!");
// // }else if(letra == "e"){
// //    System.Console.WriteLine("Está letra e uma vogal!");
// // }else if(letra == "i"){
// //     System.Console.WriteLine("Está letra e uma vogal!");
// // }else if(letra == "o"){
// //     System.Console.WriteLine("Está letra e uma vogal!");
// // }else if(letra == "u"){
// //     System.Console.WriteLine("Está letra e uma vogal!");
// // }else {
// //     System.Console.WriteLine("Não e um vogal!");
// // }
 
// if( letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
//     {
//         System.Console.WriteLine("Esta leftra é uma vogal!");
//     }else{
//         System.Console.WriteLine("Não e uma vogal!");
//     }

// switch (letra)
// {
//     case "a": 
//     case "e": 
//     case "i": 
//     case "o": 
//     case "u": 
//         System.Console.WriteLine("Está letra e uma vogal!"); 
//         break;
//     default: System.Console.WriteLine("Não e um vogal!"); 
//         break;

// }








// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0){
//  System.Console.WriteLine("Venda inválida");   
// }
// else if(possivelVenda){
//     Console.WriteLine("Venda realizada.");
// }
// else{
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }





















// string a = "15-";

// int b = 0;

// int.TryParse(a,out b);

// Console.WriteLine(b);
// Console.WriteLine("Coversão realizada com sucesso!");








// int a = 5;
// double b = a;

// Console.WriteLine(b);





// int a = Convert.ToInt32("5");
// string a1 = Convert.ToString(5.5);

// int b = int.Parse("10");
// double b1 = double.Parse("10.5");

// int c = Convert.ToInt32(null);
// //int d = int.Parse(null); "Erro não converte valor null"

// string e = a1.ToString();

// Console.WriteLine(a1);
// Console.WriteLine(b1);
// Console.WriteLine(c);
// //Console.WriteLine(d); "Erro não converte valor null"
// Console.WriteLine(e);

// Pessoa p = new Pessoa();

// String apresentacao = "Olá, seja bem vindo";
// int quantidade= 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// DateTime dataAtual = DateTime.Now.AddDays(5);

// p.Idade=10;
// p.Nome="Israel";

// Console.WriteLine($"{apresentacao},{quantidade},{altura},{preco},{condicao}");
// Console.WriteLine("Valor da variável quantidade: "+ quantidade);
// Console.WriteLine("Valor da variável quantidade: "+ altura.ToString("0.00"));
// Console.WriteLine("Valor da variável quantidade: "+ preco);
// Console.WriteLine("Valor da variável quantidade: "+ condicao);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// p.Apresentar();