using System;

namespace Abstract_Factory
{
    // Clase base de la fabrica
    public abstract class MaterialFactory
    {
        public abstract Guia CrearGuia();
        public abstract Examen CrearExamen();
    }

    // Clase base para las guias
    public abstract class Guia
    {
        public abstract void Mostrar();
    }

    // Clase base para los examenes
    public abstract class Examen
    {
        public abstract void Aplicar();
    }

    // ===== PRESENCIAL =====

    public class GuiaImpresa : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia impresa");
        }
    }

    public class ExamenEnPapel : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en papel");
        }
    }

    public class FabricaPresencial : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaImpresa();
        }

        public override Examen CrearExamen()
        {
            return new ExamenEnPapel();
        }
    }

    // ===== VIRTUAL =====

    public class GuiaVirtual : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia virtual en PDF");
        }
    }

    public class ExamenVirtual : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en linea");
        }
    }

    public class FabricaVirtual : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaVirtual();
        }

        public override Examen CrearExamen()
        {
            return new ExamenVirtual();
        }
    }

    // ===== HIBRIDO =====

    public class GuiaHibrida : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia semipresencial");
        }
    }

    public class ExamenMixto : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen mixto");
        }
    }

    public class FabricaHibrida : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaHibrida();
        }

        public override Examen CrearExamen()
        {
            return new ExamenMixto();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MaterialFactory fabrica;

            // Presencial
            fabrica = new FabricaPresencial();
            fabrica.CrearGuia().Mostrar();
            fabrica.CrearExamen().Aplicar();

            Console.WriteLine();

            // Virtual
            fabrica = new FabricaVirtual();
            fabrica.CrearGuia().Mostrar();
            fabrica.CrearExamen().Aplicar();

            Console.WriteLine();

            // Hibrido
            fabrica = new FabricaHibrida();
            fabrica.CrearGuia().Mostrar();
            fabrica.CrearExamen().Aplicar();

            Console.ReadKey();
        }
    }
}