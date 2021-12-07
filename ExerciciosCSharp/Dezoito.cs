using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp {

    

    internal class Dezoito {
        int idade;
        

        
      

        public Dezoito(int Idade) {
            idade = Idade;
        }

        public void Cal() {
            
        }
    

    }


    class Fazer {
        public static void Main() {
            Console.WriteLine("Qtde de pessoas para calcular:");
            int n = int.Parse(Console.ReadLine());
            int cont1 = 0, cont2 = 0;

        var count = 1;


            var lista = new ArrayList { };

            while (count < n+1) {

                Console.WriteLine($"Insira Idade {count}:");
                int i = int.Parse(Console.ReadLine());
                lista.Add(i);
                count++;
            }


            foreach(int inte in lista) {
                if(inte > 18) {
                    cont1++;                    
                } else {
                    cont2++;
                }
            }

            Console.WriteLine("\n\n> 18:  ");
            Console.WriteLine(cont1);
            Console.WriteLine("< 18:  ");
            Console.WriteLine(cont2);

            

        }
    }
}
