using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA_aps
{
    class Program
    {
        static void Main(string[] args)
        {
            string cript, chave1;
            char[] chave2;
            char[] entrada;
            char[] txt_cript;
            char[] descript;

            int j, op2;
            Console.WriteLine("=================ESCOLHA UMA OPÇÃO================");
            Console.WriteLine("1 ==>    -CRIPTOGRAFAR");
            Console.WriteLine("2 ==>    -DESCRIPTOGRAFAR");
            Console.WriteLine("3 ==>    -ENCERRAR O PROGRAMA");
            op2 = int.Parse(Console.ReadLine());

            switch (op2)
            {

                case 1:

                    descript = new char[128];
                    chave2 = new char[128];
                    entrada = new char[128];

                    Console.WriteLine("---------Digite seu texto para Criptografar----------");
                    cript = Console.ReadLine();


                    // enquanto o texto for menor que 3 caracteres, ele irá pedir para digitar novamente.
                    while (cript.Length < 4)
                    {
                        Console.WriteLine("-----DIGITE O TEXTO MAIOR QUE 3 CARACTERES-----");
                        cript = Console.ReadLine();
                    }
                    //remove os espaços do texto.
                    cript = cript.Replace(" ", "");

                    //vetor entrada recebe a string

                    for (j = 0; j < cript.Length; j++)
                    {

                        cript = cript.ToUpper();

                        entrada[j] = cript[j];
                    }

                    // verifica se o texto contem apenas letras.
                    for (j = 0; j < cript.Length; j++)
                    {
                        if (entrada[j] < 'A' || entrada[j] > 'Z')
                        {
                            
                            Console.WriteLine("Erro, o programa recebe apenas letras");
                            return;

                        }
                    }
                    
                    Console.WriteLine("---------DIGITE SUA CHAVE---------");
                    chave1 = Console.ReadLine();
                    //remove os espaços da chave.
                    chave1 = chave1.Replace(" ", "");

                    // se chave for maior ou igual a 4 ele recebe seus caracteres no vetor
                    if (chave1.Length >= 4 && chave1.Length <= cript.Length)
                    {
                        for (j = 0; j < chave1.Length; j++)

                        {   //deixando a chave maiscula para uniformizar os caracteres.
                            chave1 = chave1.ToUpper();
                            chave2[j] = chave1[j];
                        }
                    }
                    while (chave1.Length < 4 || chave1.Length > cript.Length)
                    {
                        Console.WriteLine("---------DIGITE SUA CHAVE COM MAIS DE 3 CARACTERES E DE TAMANHO MENOR OU IGUAL AO TEXTO--------");
                        chave1 = Console.ReadLine();
                        for (j = 0; j < chave1.Length; j++)

                        {   //deixando a chave maiscula para uniformizar os caracteres.
                            chave1 = chave1.ToUpper();
                            chave2[j] = chave1[j];
                        }
                    }

                    //verifica se a chave contem apenas letras, se não ele encerra o programa.
                    for (j = 0; j < chave1.Length; j++)
                    {
                        if (chave2[j] < 'A' || chave2[j] > 'Z')
                        {
                            Console.WriteLine("Erro,  a chave deve conter apenas letras");
                            return;
                        }
                    }
                    
                    // criptografia.
                    int novocrip;
                    
                    txt_cript = new char[128];
                    // Verificar se é uma letra, se não for ele não criptografa.

                    for (j = 0; j < cript.Length; j++)
                    {

                        novocrip = ((entrada[j] - 'A') + (chave2[j % chave1.Length] - 'A')) % 26 + 'A';
                        
                        txt_cript[j] = Convert.ToChar(novocrip);
                                                
                    }

                    Console.WriteLine("------>>>>>>>>>>TEXTO CRIPTOGRAFADO :");
                    Console.WriteLine(txt_cript);
                    Console.ReadKey();
                    break;


                case 2:
                                      
                    Console.WriteLine("Escolheu a opção: 2");
                    string d2, chave3;

                    char[] d;
                    d = new char[128];
                    int ab;

                    char[] descript2 = new char[128];
                    char[] chave4 = new char[128];

                    Console.WriteLine("-----DIGITE O CODIGO CRIPTOGRAFADO-----");
                    d2 = Console.ReadLine();
                    //convertendo o codigo cifrado para maiusculo.
                    d2 = d2.ToUpper();

                    Console.WriteLine("---------DIGITE SUA CHAVE---------");
                    chave3 = Console.ReadLine();


                    //remove os espaços da chave.
                    chave3 = chave3.Replace(" ", "");




                    // se chave for maior ou igual a 4 ele recebe seus caracteres no vetor
                    if (chave3.Length >= 4)
                    {
                        for (j = 0; j < chave3.Length; j++)

                        {   //deixando a chave maiscula para uniformizar os caracteres.
                            chave3 = chave3.ToUpper();
                            chave4[j] = chave3[j];
                        }
                    }
                    while (chave3.Length < 4)
                    {
                        Console.WriteLine("---------DIGITE SUA CHAVE COM MAIS DE 3 CARACTERES E DE TAMANHO MENOR OU IGUAL AO TEXTO--------");
                        chave1 = Console.ReadLine();
                        for (j = 0; j < chave3.Length; j++)

                        {   //deixando a chave maiscula para uniformizar os caracteres.
                            chave3 = chave3.ToUpper();
                            chave4[j] = chave3[j];
                        }
                    }

                    //verifica se a chave contem apenas letras, se não ele encerra o programa.
                    for (j = 0; j < chave3.Length; j++)
                    {
                        if (chave4[j] < 'A' || chave4[j] > 'Z')
                        {
                            Console.WriteLine("Erro,  a chave deve conter apenas letras");
                            return;
                        }
                    }

                    for (j = 0; j < d2.Length; j++)
                    {
                        //recebendo a string no vetor.
                        descript2[j] = d2[j];
                        //convertendo cada caracter para int e recebendo na variavel ab.
                        ab = Convert.ToInt32(descript2[j]);
                        //descifrando o codigo.
                        ab = (descript2[j] - chave4[j % chave3.Length] + 26) % 26 + 'A';
                        // converte de cada caracter de int para char.
                        d[j] = Convert.ToChar(ab);


                    }

                    Console.Write("------>>>>SEU CODIGO DESCIFRADO: ");
                    Console.Write(d);

                    break;
                    
                case 3:
                    Console.WriteLine("PROGRAMA FINALIZADO");
                    return;
                   
                    break;
                                   
            }
        }
    }
}



  
