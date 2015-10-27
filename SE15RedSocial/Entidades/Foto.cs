using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Foto
    {
        #region Atributos

        private int id;
        private int perfil;
        private string nombre;
        private string archivo;
        private DateTime fecha;
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

        public int Perfil
        {
            get
            {
                return this.perfil;
            }
            set
            {
                if (value > 0)
                {
                    this.perfil = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.nombre = value;
                }
            }
        }

        public string Archivo
        {
            get
            {
                return this.archivo;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.archivo = value;
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
                if (value != null)
                {
                    this.fecha = value;
                }
            }
        }
        #endregion

        #region Constructores

        public Foto() { }

        public Foto(int p_id, int p_perfil, string p_nombre, string p_archivo, DateTime p_fecha) {
            this.id = p_id;
            this.perfil = p_perfil;
            this.nombre = p_nombre;
            this.archivo = p_archivo;
            this.fecha = p_fecha;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
