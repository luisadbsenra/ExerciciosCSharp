using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp {
    internal class ParImpar {


        public ParImpar() {

        }


        public string Determinar(int n) {

            int p = 1;
            while (p < 2) {
                if (n % 2 == 1) {
                    return "Número Impar";
                } else {
                    return "Numero Par";
                }
            }

            return "";
        }

    }
        


     class DoPar {
        public static void Main2() {

            var e = 1;
            while (e < 2) {
                int d = int.Parse(Console.ReadLine());
                var pi = new ParImpar();
                Console.WriteLine(pi.Determinar(d));
            }
        
        }
     }

}
