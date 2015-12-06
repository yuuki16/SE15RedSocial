using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comentario
    {
        #region Atributos
        private int id;
        private int publicacion;
        private int usuario;
        private string coment;
        private string estampa;
        private char estado;
        #endregion

        #region Constructores
            public Comentario() { }

            public Comentario(int p_publicacion, int p_usuario, string p_comentario, string p_estampa, char p_estado)
            {
                this.publicacion = p_publicacion;
                this.usuario = p_usuario;
                this.coment = p_comentario;
                this.estampa = p_estampa;
                this.estado = p_estado;
            }
        #endregion

        #region Propiedades
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public int Publicacion
        {
            get
            {
                return this.publicacion;
            }
            set
            {
                if (value > 0)
                {
                    this.publicacion = value;
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

        public string Coment
        {
            get
            {
                return this.coment;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.coment = value;
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
        
    }
}
