using System;


class program {

    public class bicicleta {
        public string marca;
        public int rodado;
        public int anio;

        public void arrancar() {
            Console.WriteLine("Bicicleta arrancando..")
        }
        public void frenan() {
            Console.WriteLine("Bicicleta frenando..")
        }
    }
    
    public class lampara {
        public int volteos;
        public string marca;
        public string tipo; //led , solar , etc

        public void prendida() {
            Console.WriteLine("Lampara prendiendose..")
        }
        public void apagada() {
            Console.WriteLine("Lampara apagandose..")
        }
    }

     static void Main() {
        Bicicleta bici = new Bicicleta();
        bici.marca = "Venzo";
        bici.rodado = 29;
        bici.anio = 2023;
        bici.Arrancar();
        bici.Frenar();

        Console.WriteLine($"Marca: {miBici.marca}, Rodado: {miBici.rodado}, Año: {miBici.anio}");
        miBici.Arrancar();
        miBici.Frenar();

        Lampara lamparita = new Lampara();
        lamparita.marca = "Philips";
        lamparita.voltios = 220;
        lamparita.tipo = "LED";
        lamparita.Encender();
        lamparita.Apagar();
         
        Console.WriteLine($"Marca: {miLampara.marca}, Voltios: {miLampara.voltios}, Tipo: {miLampara.tipo}");
        miLampara.Encender();
        miLampara.Apagar();
    }
}

