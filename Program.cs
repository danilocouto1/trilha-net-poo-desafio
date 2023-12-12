using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste para Nokia
            Nokia nokiaPhone = new Nokia("123456", "IMEI123", "Nokia Model", 64);
            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            // Teste para Iphone
            Iphone iphone = new Iphone("654321", "IMEI456", "iPhone Model", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}