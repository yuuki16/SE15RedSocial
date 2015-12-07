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
        private string estado;
        private DateTime estampa;
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

        public string Estado { get
            {
                return this.estado;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.estado = value;
                }
                
            }  
        }

        public DateTime Estampa
        {
            get
            {
                return this.estampa;
            }
            set
            {
                if (value > DateTime.MinValue && value < DateTime.MaxValue)
                {
                    this.estampa = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Solicitud() { }

        public Solicitud(int p_id, int p_emisor, int p_receptor, string p_estado, DateTime p_estampa) {
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
