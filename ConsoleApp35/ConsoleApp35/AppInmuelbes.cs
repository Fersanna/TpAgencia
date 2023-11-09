using System;
using System.Collections.Generic;

namespace ConsoleApp35
{
    internal class AppInmuebles
    {
        Validador validador;
        List<Inmueble> inmuebles;
        List<Concepto> conceptos;
        public AppInmuebles()
        {

            validador = new Validador();
            inmuebles = new List<Inmueble>();
            conceptos = new List<Concepto>();

            inmuebles.Add(new Propio("1", "Numero 1", DateTime.Now.ToString(), 1000, 5, 2));
            inmuebles.Add(new Tercero("2", "Numero 2-Alquilado", DateTime.Now.ToString(), "Susana", 1000, 5, 2));
            conceptos.Add(new Concepto("Gastos Varios", "CO5", 5, 1000, "P"));


        }

        internal void Ejecutar()
        {
            string opcion = "";

            do
            {
                opcion = validador.pedirStringNoVacio("Ingrese opcion\n1-Ingresar Inmueble\n2-Ingresar Concepto\n3-Listado\n4-Ver conceptos por inmueble");
                if (opcion == "1")
                {
                    IngresarInmuelbe();
                }
                else if (opcion == "2")
                {
                    IngresarConcepto();
                }
                else if (opcion == "3")
                {
                    listadoParaPresupuesto();
                }
                else if (opcion == "4")
                {
                    VerDetallePorInmueble();
                }
            } while (opcion != "5");
        }

        private void VerDetallePorInmueble()
        {
            //imprime listado de inmuebles con sus codigos, el usuario elige el codigo del inmueble a consultar y emite listado de inmueble con los conceptos de gastos cargados.

            foreach (Inmueble inmueble in inmuebles)
            {
                Console.WriteLine(inmueble.ToString());
            }

            string codigoConsultado = "";

            codigoConsultado = validador.pedirStringNoVacio("ingrese un codigo");

            Inmueble inmuebleConsultado = inmuebles.Find(inmueble => inmueble.GetCodigo() == codigoConsultado);

            Console.WriteLine("El inmueble elegido es el siguiente:\n" + inmuebleConsultado);

            //conceptos.FindAll(concepto => concepto.AplicaApropios(inmuebleConsultado));

            List<Concepto> conceptosAplicables = new List<Concepto>();

            double totalPorConcepto = 0;


            foreach (Concepto concepto in conceptos)
            {
                if (inmuebleConsultado is Propio && concepto.AplicaApropios(inmuebleConsultado as Propio))
                {
                    conceptosAplicables.Add(concepto);
                    totalPorConcepto += concepto.GetImporte();
                }
                else if (inmuebleConsultado is Tercero && concepto.AplicaATerceros(inmuebleConsultado as Tercero))
                {
                    conceptosAplicables.Add(concepto);
                    totalPorConcepto += concepto.GetImporte();
                }
            }

            Console.WriteLine("Conceptos aplicables al inmueble:");

            foreach (Concepto concepto in conceptosAplicables)
            {
                Console.WriteLine(concepto);
            }

          

            Console.WriteLine("Total por Concepto: " + totalPorConcepto);
        }
    
    

        private void listadoParaPresupuesto()
        {
            Console.WriteLine("Listado para Presupuesto:");
            Console.WriteLine("------------------------------------");
            
            foreach (Inmueble inmueble in inmuebles)
            {
                Console.WriteLine(inmueble.ToString());
                Console.WriteLine("Amortización: " + inmueble.GetAmortizacion());
                Console.WriteLine("Alquiler: " + inmueble.GetAlquiler());
                Console.WriteLine("Gastos Adicionales: " + inmueble.GetGastosAdicionales());
                Console.WriteLine("------------------------------------");
            }
        }


        private void IngresarConcepto()
        {
            conceptos.Add(IngresarConceptos());
        }

        private Concepto IngresarConceptos()
        {
            Concepto retorno = null;

            string tipo = "";
            string codigoAcargar = "";
            string nombre = "";
            int  mesesRestantes = 0;
            double importe = 0;

            codigoAcargar = validador.pedirStringNoVacio("Por favor ingrese el codigo del concepto");

            conceptos.Exists(concepto => concepto.GetCodigo() == codigoAcargar);

            {
                Console.WriteLine("Ese concepto ya fue cargado");
            }

            nombre = validador.pedirStringNoVacio("Ingrese el nombre del concepto");
            importe = validador.pedirDouble("Ingrese importe", 0, 10000);
            mesesRestantes = validador.pedirInteger("Ingrese meses restantes que aplica", 0, 12);

            do
            {
                tipo = validador.pedirStringNoVacio("Por favor ingrese CP para concepto propios y CT para concepto de terceros");
                
                if (tipo != "CP" && tipo != "CT")
                {
                    Console.WriteLine("Debe ingresar CP o CT");

                }

                if (tipo == "CP")
                {
                    retorno = new Concepto(nombre, codigoAcargar, mesesRestantes, importe, "P");
                }
                if (tipo == "CT")
                {
                    retorno = new Concepto(nombre, codigoAcargar, mesesRestantes, importe, "T");
                }


            } while (tipo != "CP" && tipo != "CT");

            

            return retorno;


        }

        private void IngresarInmuelbe()
        {

            inmuebles.Add(IngresarInmueble());


        }

        private Inmueble IngresarInmueble()
        {
            Inmueble retorno = null;

            string tipo = "";
            string nombre = "";
            string codigo = "";
            string fecha = "";
            int fee = 0;
            int mesesTotales = 0;
            int mesesRestantes = 0;

            do
            {
                tipo = validador.pedirStringNoVacio("Ingrese P para inmueble propio o T para inmueble de tercero");

                if (tipo != "P" && tipo != "T")
                {
                    Console.WriteLine("Debe ingresar una opcion valida");
                }
            } while (tipo != "P" && tipo != "T");


            if (tipo == "P")
            {
                nombre = validador.pedirStringNoVacio("Ingrese el nombre");
                codigo = validador.pedirStringNoVacio("Ingrese el codigo");
                fecha = DateTime.Now.ToString();

                retorno = new Propio(codigo, nombre, "", 0, 0, 0);

                if (inmuebles.Contains(retorno))
                {
                    Console.WriteLine("Ese inmuble ya fue cargado");
                }
                else if
                       (tipo == "T")
                {
                    nombre = validador.pedirStringNoVacio("Ingrese el nombre");
                    codigo = validador.pedirStringNoVacio("Ingrese el codigo");
                    fecha = DateTime.Now.ToString();
                    fee = validador.pedirInteger("Ingrese el fee mensual", 0, 1000000);
                    mesesTotales = validador.pedirInteger("Ingrese el fee mensual", 0, 12);
                    mesesRestantes = validador.pedirInteger("Ingrese el fee mensual", 0, 12);



                    retorno = new Tercero(codigo, nombre,fecha, "", 0, mesesTotales, mesesRestantes);
                }

            }
            return retorno;

        }
    }
}
