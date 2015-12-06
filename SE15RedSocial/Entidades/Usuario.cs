using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos

        private int id;
        private string correo;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string alias;
        private string contrasena;
        private string pais;
        private char estado;
        private string estampa; /*when retrieving from database

                                string dt = Convert.ToBase64String(dataReader["dt"] as byte[]);
                                when passing into database

                                new SqlParameter("@dt", Convert.FromBase64String(dt))*/
        #endregion

        #region Propiedades

        public int Id { 
            get {
                return this.id;
            }
            set {
                if (value > 0) {
                    this.id = value;
                }
            }
        }

        public string Correo {
            get
            {
                return this.correo;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.correo = value;
                }
            }
        }

        public string Nombre {
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

        public string ApellidoPaterno {
            get
            {
                return this.apellidoPaterno;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.apellidoPaterno = value;
                }
            }
        }

        public string ApellidoMaterno {
            get
            {
                return this.apellidoMaterno;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.apellidoMaterno = value;
                }
            }
        }

        public string Alias
        {
            get
            {
                return this.alias;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.alias = value;
                }
            }
        }

        public string Contrasena { 
            get
            {
                return this.contrasena;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.contrasena = value;
                }
            }
        }

        public string Pais
        {
            get
            {
                return this.pais;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.pais = value;
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

        public Usuario() { }
        public Usuario(int p_id, string p_correo, string p_nombre, string p_apellidoPaterno, string p_apellidoMaterno, string p_alias,
            string p_contrasena, string p_pais, char p_estado, string p_estampa) {
                this.id = p_id;
                this.correo = p_correo;
                this.nombre = p_nombre;
                this.apellidoPaterno = p_apellidoPaterno;
                this.apellidoMaterno = p_apellidoMaterno;
                this.alias = p_alias;
                this.contrasena = p_contrasena;
                this.pais = p_pais;
                this.estado = p_estado;
                this.estampa = p_estampa;
        }

        #endregion

        #region Metodos
        #endregion
    }
}
