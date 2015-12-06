using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicacion
    {
        #region Atributos

        private int id;
        private int usuario;
        private string post;
        private string estampa;
        private char estado;
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

        public string Post
        {
            get
            {
                return this.post;
            }
            set
            {
                if (value != string.Empty )
                {
                    this.post = value;
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

        public char Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        #endregion

        #region Constructores
        public Publicacion() { }

        public Publicacion(int p_id, int p_usuario, string p_publicacion, string p_estampa, char p_estado) {
            this.id = p_id;
            this.usuario = p_usuario;
            this.post = p_publicacion;
            this.estampa = p_estampa;
            this.estado = p_estado;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
