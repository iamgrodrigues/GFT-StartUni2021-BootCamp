using System;

namespace Animal {
  class Program {
      
    public static void Main (string[] args) {  
      String classe; 
      String tipo;
      String dieta;

      classe = Console.ReadLine();
      tipo = Console.ReadLine();
      dieta = Console.ReadLine();

      if ((classe == "vertebrado") && (tipo == "ave")  && (dieta == "carnivoro")) {
        Console.WriteLine("aguia\n");
      }

      if ((classe == "vertebrado") && (tipo == "ave")  && (dieta == "onivoro")) {
        Console.WriteLine("pomba\n");
      }

      if ((classe == "vertebrado") && (tipo == "mamifero")  && (dieta == "onivoro")) {
        Console.WriteLine("homem\n");
      }

      if ((classe == "vertebrado") && (tipo == "mamifero")  && (dieta == "herbivoro")) {
        Console.WriteLine("vaca\n");
      }

      if ((classe == "invertebrado") && (tipo == "inseto")  && (dieta == "hematofago")) {
        Console.WriteLine("pulga\n");
      }

      if ((classe ==  "invertebrado") && (tipo == "inseto")  && (dieta == "herbivoro")) {
        Console.WriteLine("lagarta\n");
      }
      
      if ((classe  == "invertebrado") && (tipo == "anelideo") && (dieta == "onivoro")) {
        Console.WriteLine("minhoca\n");
      }

      if ((classe  == "invertebrado") && (tipo == "anelideo") && (dieta == "hematofago")) {
        Console.WriteLine("sanguessuga\n");
      }
    }
  }
}