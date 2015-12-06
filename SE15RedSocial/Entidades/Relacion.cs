using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Relacion
    {
        #region Atributos

        private int id;
        private int usuario1;
        private int usuario2;
        private string tipo;
        private string estampa;
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

        public int Usuario1
        {
            get
            {
                return this.usuario1;
            }
            set
            {
                if (value > 0)
                {
                    this.usuario1 = value;
                }
            }
        }

        public int Usuario2
        {
            get
            {
                return this.usuario2;
            }
            set
            {
                if (value > 0)
                {
                    this.usuario2 = value;
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
        public Relacion() { }
        public Relacion(int p_id, int p_usuario1, int p_usuario2, string p_tipo, string p_estampa) {
            this.id = p_id;
            this.usuario1 = p_usuario1;
            this.usuario2 = p_usuario2;
            this.tipo = p_tipo;
            this.estampa = p_estampa;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
