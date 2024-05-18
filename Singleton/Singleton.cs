using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Esto funciona mucho por ejemplo si esta es una función de mostrar un calendario
    //a todos los usuarios del sistema y no queremos que gaste recurso generandoselo a
    //cada uno, sino que en sistema ya está creado una vez.
    class Singleton
    {
        //Hace una llamada privada a sí misma, recursivo
        private static Singleton instance = null;

        public string Mensaje { get; set; }

        protected Singleton() {
            Mensaje = "Hola Mundo, soy un singleton";
        }

        //Este siguiente metodo hace la magia para que no se repita la creacion del objeto
        //el verifica si ya se creó (si no está en null), si ya existe entonces devuelve el objeto que ya existe y listo.
        public static Singleton Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }

        }

    }
}
