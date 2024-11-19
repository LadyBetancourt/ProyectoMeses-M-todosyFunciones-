namespace ProyectoMeses_MétodosyFunciones_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();

                string mes = ObtenerMes(Console.ReadLine());
                Console.WriteLine(mes);
                Console.ReadLine();
            }
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingresa un número:");
            Console.WriteLine("");
        }

        static string ObtenerMes(string dato)
        {
            string mes = "";

            switch (dato)
            {
                case "1":
                    mes = "Enero";
                    break;
                case "2":
                    mes = "Febrero";
                    break;
                case "3":
                    mes = "Marzo";
                    break;
                case "4":
                    mes = "Abril";
                    break;
                case "5":
                    mes = "Mayo";
                    break;
                case "6":
                    mes = "Junio";
                    break;
                case "7":
                    mes = "Julio";
                    break;
                case "8":
                    mes = "Agosto";
                    break;
                case "9":
                    mes = "Septiembre";
                    break;
                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;
                case "12":
                    mes = "Diciembre";
                    break;

                default:
                    MensajeError($"El dato introducido es incorrecto: {dato}");
                    break;
            }

            return mes;
        }

        static void MensajeError(string mensajeDeError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensajeDeError);
            Console.ResetColor();
        }
    }
}
