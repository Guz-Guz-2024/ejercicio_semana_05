namespace noche.Controllers
{
    public class Rectangulo
    {

        //propiedades o atributos
        double baser;
        double alturar;

        //constructor por defecto
        public Rectangulo()
        {
            baser = 0;
            alturar = 0;
        }

        //constructor parametros
        public Rectangulo(double pbaser, double palturar)
        {
            baser = pbaser;
            alturar = palturar;
        }

        public double devolverarea()
        {
            return baser * alturar;
        }


    }
}
