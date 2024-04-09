// 1. Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Console.WriteLine("Informe o primeiro número");
// int n1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Informe o segundo número");
// int n2 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Informe o terceiro número");
// int n3 = Convert.ToInt32(Console.ReadLine());



// if(n1>n2 && n1>n3)
// {
//     Console.WriteLine($"O primeiro número {n1} é o maior número");
// }
// if(n2>n1 && n2>n3)
// {
//     Console.WriteLine($"O segundo número {n2} é o maior número");
// }
// if(n3>n1 && n3>n2)
// {
//     Console.WriteLine($"O terceiro número {n3} é o maior número");
// }


// 2. Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.
//While
// int soma1 = 0;
// int contador1 = 1;

// while (contador1 <= 10)
// {
//     Console.WriteLine(contador1);
//     soma1 += contador1;
//     contador1 ++;
// }
// Console.WriteLine($"A soma destes números é {soma1}");

// // DO-WHILE
// int soma2 = 0;
// int contador2 = 1;

// do
// {
//     Console.WriteLine(contador2);
//     soma2 += contador2;
//     contador2 ++;
// } while (contador2 <= 10);
// Console.WriteLine($"A soma destes números é {soma2}");


// // FOR

// int soma3 = 0;
// for (int contador3 = 1; contador3 <= 10; contador3++)
// {
//     Console.WriteLine(contador3);
//     soma3 += contador3;
// }
// Console.WriteLine($"A soma destes números é {soma3}");


// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;


// bool condicao = true;
// while (condicao == true)
// {
//     Console.WriteLine("Digite um número maior que zero");
//     int num = Convert.ToInt32(Console.ReadLine());

// if (num>0)
// for (int i = 0; i <=10; i++)
// {
//     int multi = i*num;
//     Console.WriteLine($"{num} x {i} é igual a = {multi}");
// }
// else
// {
//     Console.WriteLine("Este número não é maior que zero");
//     break;
// }

// Console.WriteLine("Deseja Repetir o Processo?");
// Console.WriteLine("Digite 1 = Sim");
// Console.WriteLine("Digite 2 = Não");
// int opcao = Convert.ToInt32(Console.ReadLine());
// if (opcao == 1)
// {
//     continue;
// }
// else
// {
//     condicao = false;
// }
// }


// 4. 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:
// - Incrementando 2 em cada passo
// - Incrementando 1 em cada passo 
// - Com e loop infinito (use "break" e "continue")
// int num04 = 10;
// int num05 = 10;

// while (num04 <= 20)
// {
//     if (num04%2==0 && num04 !=16)
//     {
//         Console.WriteLine(num04);
//     }
//     num04 +=2;
// }
// while (num05 <= 20)
// {
//     if (num05%2==0 && num05 !=16)
//     {
//         Console.WriteLine(num05);
//     }
//     num05 +=1;
// }


// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

Console.WriteLine("Informe um número inteiro");
int n5 = Convert.ToInt32(Console.ReadLine());
int fatorial = n5-1;
int fat = n5;

while (n5>=2)
{
    Console.WriteLine($"{fat} x {fatorial}");
    fat = fat * fatorial;
    n5--;
    fatorial--;
    Console.WriteLine($"Soma: {fat}");
}

