using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perfil
    {
        #region Atributos

        private int id;
        private int usuario; 
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
        #endregion

        #region Constructores

        public Perfil() { }

        public Perfil(int p_id, int p_usuario) {
            this.id = p_id;
            this.usuario = p_usuario;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
