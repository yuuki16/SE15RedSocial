using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        #region Atributos

        private int id;
        private int emisor;
        private int receptor;
        private string estampa;
        private string msj;
        private string multimedia;

        #endregion

        #region Propiedades
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
            }
        }

        public int Emisor
        {
            get
            {
                return this.emisor;
            }
            set
            {
                if (value > 0)
                {
                    this.emisor = value;
                }
            }
        }

        public int Receptor
        {
            get
            {
                return this.receptor;
            }
            set
            {
                if (value > 0)
                {
                    this.receptor = value;
                }
            }
        }

        public string Estampa
        {
            get
            {
                return this.estampa;
            }
            set
            {
                if (value != string.Empty )
                {
                    this.estampa = value;
                }
            }
        }

        public string Msj
        {
            get
            {
                return this.msj;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.msj = value;
                }
            }
        }

        public string Multimedia
        {
            get
            {
                return this.multimedia;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.multimedia = value;
                }
            }
        }

        #endregion

        #region Constructores

        public Mensaje() { }

        public Mensaje(int p_id, int p_emisor, int p_receptor, string p_estampa, string p_mensaje, string p_multimedia) { }
        
        #endregion

        #region Metodos
        #endregion
    }
}

