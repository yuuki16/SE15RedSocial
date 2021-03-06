﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
using Entidades;

namespace BL
{
    public class BL_Usuario
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private Boolean resultado = false;
        private DAO_Usuario dao_usuario = new DAO_Usuario();

        public DataSet ObtenerUsuario(Usuario usuario)
        {

            try
            {
                ds = dao_usuario.ObtenerUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return ds;

        }

        public DataTable ObtenerDatosUsuario(Usuario usuario)
        {

            try
            {
                dt = dao_usuario.ObtenerDatosUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;

        }

        public int ObtenerIDUsuarrio(Usuario usuario)
        {

            int idUsuario;

            try
            {
                idUsuario = dao_usuario.ObtenerIDUsuarrio(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return idUsuario;

        }

        public Boolean AgregarUsuario(Usuario usuario){
        
            try 
	        {	        
		        resultado = dao_usuario.AgregarUsuario(usuario);
	        }
	        catch (Exception ex)
	        {
		        throw new Exception(ex.Message, ex);
	        }

            return resultado;
        
        }

        public Boolean ModificarUsuario(Usuario usuario)
        {

            try
            {
                resultado = dao_usuario.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

        public Boolean InActivarUsuario(Usuario usuario)
        {

            try
            {
                resultado = dao_usuario.CambioEstadoUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

        public Boolean LoginUsuario(Usuario usuario)
        {

            try
            {
                resultado = dao_usuario.LoginUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos inválidos", ex);
            }

            return resultado;

        }


    }
}
