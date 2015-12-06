using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Solicitud
    {
        #region Atributos

        private int id;
        private int emisor;
        private int receptor;
        private char estado;
        private string estampa;
        #endregion

        #region Propiedades
        public int Id { 
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

        public int Emisor { get
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

        public int Receptor { get
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

        public char Estado { get
            {
                return this.estado;
            }
            set
            {
                    this.estado = value;
                
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
                if (value != string.Empty)
                {
                    this.estampa = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Solicitud() { }

        public Solicitud(int p_id, int p_emisor, int p_receptor, char p_estado, string p_estampa) {
            this.id = p_id;
            this.emisor = p_emisor;
            this.receptor = p_receptor;
            this.estado = p_estado;
            this.estampa = p_estampa;
        }
        #endregion

        #region Metodos
        #endregion

    }
}
