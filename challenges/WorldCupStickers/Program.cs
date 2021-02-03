using System;
using System.Collections.Generic;

namespace WorldCupStickers {
  class Program {
    public static void Main (string[] args) {  
      int stickersSpaces = int.Parse(Console.ReadLine());
      int purchasedSticker = int.Parse(Console.ReadLine());
      HashSet<int> stickersTotal = new HashSet<int>();
      
      for (int i = 0; i < purchasedSticker; i++) {
        stickersTotal.Add(int.Parse(Console.ReadLine()));
      }

      Console.Write(stickersSpaces-(stickersTotal.Count));

    }
  }
}
