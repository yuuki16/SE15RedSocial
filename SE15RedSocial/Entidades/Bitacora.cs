using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bitacora
    {
        #region Atributos
        private int id;
        private DateTime fecha;
        private string tipo;
        private int usuario;
        private string ip;
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

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                if (value != null )
                {
                    this.fecha = value;
                }
            }
        }

        public string Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.tipo = value;
                }
            }
        }

        public int Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                if (value > 0)
                {
                    this.usuario = value;
                }
            }
        }

        public string IP
        {
            get
            {
                return this.ip;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.ip = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Bitacora() { }

        public Bitacora(int p_id, DateTime p_fecha, string p_tipo, int p_usuario, string p_ip) {
            this.id = p_id;
            this.fecha = p_fecha;
            this.tipo = p_tipo;
            this.usuario = p_usuario;
            this.ip = p_ip;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
