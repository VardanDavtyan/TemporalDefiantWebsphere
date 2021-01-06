using System;

class MainClass {
  public static void Main (string[] args) {
    while(!Convert.ToBoolean(0)) {
      Console.Write ("ENTER LETTER: ");
      char let = Convert.ToChar(Console.ReadLine());
      Console.Write ("ENTER NUMBER(1-8): ");
      int num = Convert.ToInt32(Console.ReadLine());
      string coord = String.Concat(let.ToString(), num);

      bool isWhite = false;
      char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
      for (int i = 0; i < 8; i++) {
        for (int j = 0; j < 8; j++) {
          if (let == letters[j] && num == i + 1) 
            Console.WriteLine("KNIGHT IS IN " + (isWhite ? "WHITE" : "BLACK") + " ZONE!");
          isWhite = !isWhite;
        } isWhite = !isWhite;
      }
      Console.ReadKey();
    }
  }
}