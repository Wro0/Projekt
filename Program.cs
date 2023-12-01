// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System;
using System.Diagnostics;

int svar = 0;

körs();
    void körs()
{
    Console.WriteLine("██╗░░██╗██╗░░░██╗░█████╗░██████╗░░██████╗██╗████████╗████████╗███╗░░██╗██╗░██████╗░███╗░░██╗");
    Console.WriteLine("██║░██╔╝██║░░░██║██╔══██╗██╔══██╗██╔════╝██║╚══██╔══╝╚══██╔══╝████╗░██║██║██╔════╝░████╗░██║");
    Console.WriteLine("█████═╝░╚██╗░██╔╝███████║██████╔╝╚█████╗░██║░░░██║░░░░░░██║░░░██╔██╗██║██║██║░░██╗░██╔██╗██║");
    Console.WriteLine("██╔═██╗░░╚████╔╝░██╔══██║██╔══██╗░╚═══██╗██║░░░██║░░░░░░██║░░░██║╚████║██║██║░░╚██╗██║╚████║");
    Console.WriteLine("██║░╚██╗░░╚██╔╝░░██║░░██║██║░░██║██████╔╝██║░░░██║░░░░░░██║░░░██║░╚███║██║╚██████╔╝██║░╚███║");
    Console.WriteLine("╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░░░░╚═╝░░░╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚══╝");
    int i = 0;
    while (i < 20)
    {
        Console.WriteLine(" ");
        i++;
    }
    while (i < 35)
    {
        Console.WriteLine(" ");
        Thread.Sleep(300);
        i++;
    }
    Console.Clear();

        Console.WriteLine("Du är ensam på nattetid på Balderskolan du befinner dig i sal A337. (1) för att gå ut, (2) för att stanna");
        int svar = int.Parse(Console.ReadLine());
        bool pinne = false;
        if (svar == 1)
        {
            Console.WriteLine("Du går ut ur salen och befinner dig i korridoren. Det finns en läskig trapp du kan gå ner för. Du kan också fortsätta i korridoren och på en bro... (1) för att gå ner för trappan, (2) för att gå över bron");
        }
        if (svar != 1)
        {
            bool a = false;
            while (a == false)
            {
                Console.WriteLine("Du kan sitta och vänta eller så kan du ta upp en av Anders glasfiberpinnar. (1) för att vänta, (2) för att ta pinnen");
                svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    Console.WriteLine("Du väntar");
                }
                if (svar != 1)
            {
                    Console.WriteLine("Du tar pinnen");
                    pinne = true;
                }
                Console.WriteLine("(1) för att stanna, (2) för att gå ut");
                svar = int.Parse(Console.ReadLine());
                if (svar != 1)
                {
                    a = true;
                    Console.WriteLine("Du går ut ur salen och befinner dig i korridoren. Det finns en läskig trapp du kan gå ner för. Du kan också fortsätta i korridoren och på en bro... (1) för att gå ner för trappan, (2) för att gå över bron");
                }
            }
            
        }
        
        svar = int.Parse(Console.ReadLine());

        if (svar == 1)
        {
            Console.WriteLine("Du vinglar dig ner för trappan och är nu på Entré plan. Du kan gå till stora Entrén eller gå till hissen. (1) för att gå ut ur stora Entrén, (2) för att gå till hissen");
                svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    Console.WriteLine("Du går ut");
                    Console.WriteLine("Vill du börja om? (1) för ja, (2) för nej");
                    starta_om();
                }

                if (svar != 1)
                {
                    Console.WriteLine("Du åker upp och ner i hissen några gånger. (1) för att fortsätta, (2) för att gå");
                    svar = int.Parse(Console.ReadLine());
                    if (svar == 1)
                    {
                        int h = 0;
                        while (h < 4 && svar == 1)
                        {
                            h++;
                            Console.WriteLine("Du åker upp och ner i hissen några gånger. (1) för att fortsätta, (2) för att gå");
                            svar = int.Parse(Console.ReadLine());
                            if (h > 3)
                            {
                                Console.WriteLine("Du åker upp, och hissen stannar efter en stund kraschar den i marken och du vrickar ett ben,");
                                if (pinne == true)
                                {
                                    Console.WriteLine("Du använder pinnen för att stödja dig på");
                                    Console.WriteLine("Du klättrar upp för hisschaktet och stiger ut ur skolan");
                                    starta_om();
                                    
                                
                                
                                
                                }
                                if (pinne == false)
                                {
                                    Console.WriteLine("Skulle haft något  att hjälpa dig gå med");
                                    starta_om();

                                }
                            }

                        }



                    }
                    if (svar != 1)
                    {
                        Console.WriteLine("Du går ut");
                        starta_om();
                    }
                }
            }
        if (svar != 1)
        {
            Console.WriteLine("Du faller");
            if (pinne == true)
            {
                Console.WriteLine("Och landar på pinnen, den går sönder");
            }
            starta_om();

           
        }

        if (svar != 1)
        {
            Console.WriteLine();
        }
        svar = int.Parse(Console.ReadLine());

        if (svar == 1)
        {
            Console.WriteLine("Du går ut");
            starta_om();
        }
        if (svar != 1)
        {
            Console.WriteLine();
        }
        
    }




void starta_om()
{
    Console.WriteLine("Börja om? (1) för ja, (2) för nej");
    svar = int.Parse(Console.ReadLine());
    if (svar == 1)
    {
        Console.WriteLine("Börjar om");
        Thread.Sleep(700);
        Console.Clear();
        körs();
    }
    if (svar != 1)
    {
        Console.WriteLine("Slut");
        Console.Clear();
        Environment.Exit(0);
    }
}







/*
if (x == 1)
{
    Console.WriteLine();
}
if (x == 2)
{
    Console.WriteLine();
}
x = int.Parse(Console.ReadLine());
*/