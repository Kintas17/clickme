using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickme
{
    class clicar
    {
        private int pontos;
        private int tempo = 10;

        public string timeS()
        {
            if (tempo > 0)
            {
                tempo -= 1;
            }
            return tempo.ToString();
        }


        public string points()
        {
            if (tempo > 0)
            {
                pontos += 1;
            }
            return pontos.ToString();
        }
        public string treset()
        {
            
            tempo = 10;
            return tempo.ToString();
           
        }
        public string preset()
        {
            pontos = 0;
            return pontos.ToString();
        }
        
    }
}
