using System;
					
public class Program
{
	public static void Main()
	{		
	
            Random rndNumber = new Random();
            bool oyun = true;
            bool reNumber = false;
            int[] loto = new int[6];
            while(oyun){
                for (int i = 0; i < 6; i++)
                {
                     reNumber = false;
                while (reNumber == false) {
                    int k = 0;
                    int randomNumber= rndNumber.Next(1, 50);
                    for (k = 0; k < 6; k++) {
                        if (loto[k] == randomNumber) {
                            break;
                        }
                    }
                    if (k == 6) {
                        loto[i] = randomNumber;
                        reNumber = true;
                    }
                }
            }           
           
            Array.Sort(loto);
            Console.WriteLine("Tahmini sayisal loto sonuclari");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(loto[i] + "-");
            }
            Console.WriteLine("Tekrar oynamak istermisiniz (e/h)?");
            string evetHayir = Console.ReadLine();
            if (evetHayir=="e") {
                oyun = true;
            } else if (evetHayir=="h") {
                oyun = false;
                Console.WriteLine("Oyun sonlandırıldı.");
            }           
            }
	}
}
