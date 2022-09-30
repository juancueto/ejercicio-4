using System;
namespace Open_BootCampo
{
    public class Ejercicio4
    {
        public Ejercicio4()
        {
        }

        public string CondicionIf(int numeroIf) {
            if (numeroIf > 0)
            {
                return "Es positivo";
            }
            else if (numeroIf == 0)
            {
                return "Es cero";
            }
            else {
                return "Es negativo";
            }
        }

        public void BucleWhile(int numeroWhile)
        {
            while (numeroWhile < 3)
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;
            }
        }

        public void BucleDoWhile(int numeroWhile)
        {
            do
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;
            }
            while (numeroWhile < 3);
        }

        public void BucleFor()
        {
            for (int numeroFor = 0; numeroFor <= 3; numeroFor++)
            {
                Console.WriteLine(numeroFor);
            }
        }

        public void CondicionSwitch(string estacion)
        {
            switch (estacion.ToLower())
            {
                case "primavera":
                    Console.WriteLine("Estamos en primavera");
                    break;
                case "verano":
                    Console.WriteLine("Estamos en verano");
                    break;
                case "otonho":
                    Console.WriteLine("Estamos en otonho");
                    break;
                case "invierno":
                    Console.WriteLine("Estamos en invierno");
                    break;
                default:
                    Console.WriteLine("No existe la estacion");
                    break;
            }
        }
    }
}

