using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facade
{
    class FachadaDeProcesos
    {
        
        private BuscarVuelos APIBUS = new BuscarVuelos();
        private ReservarVuelos APIRES = new ReservarVuelos();
        private CobrarVuelos APICOB = new CobrarVuelos();
        public void AdquirirVuelo()
        {
            APIBUS.BuscarVuelo();
            APIRES.ReservarVuelo();
            APICOB.CobrarVuelo();
        }


            
        

        
    }
}
