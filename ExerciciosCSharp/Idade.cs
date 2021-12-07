using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp {

    public class Idade {
        //double n1 = 0;
        //double n2 = 0;
        //double n3 = 0;
        //double n4 = 0;
        //double n5 = 0;

        public double Calcular(double n1, double n2, double n3, double n4, double n5) {

            var media = (n1 + n2 + n3 + n4 + n5) / 5;
            return media;
        }
    }

    internal class Executar {

        public static void Main2() {
            var idade = new Idade();
            Console.WriteLine(idade.Calcular(12, 26, 17, 94, 71));

        }
    }
}
