using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OpenBar.Clases
{
    class Usuarios
    {
        //Parametros: pUsuario y pContraseña
        public static int AltaCuentas(String pUsuario, String pContraseña)
        {
            int resultado = 0;

            SqlConnection cn = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader dr;
            cn.ConnectionString = Project_OpenBar.Ruta_Servidor.strRutaServidorSQL;
            // comando.Connection = cn;
            cn.Open();

            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO USUARIOS (USUARIO, CONTRASEÑA) values ('{0}', PwdEncrypt('{1}'))", pUsuario, pContraseña), cn);
            resultado = comando.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public static int Login(String pUsuario, String pContraseña)
        { 
            int resultado = -1;
            SqlConnection cn = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader dr;
            cn.ConnectionString = Project_OpenBar.Ruta_Servidor.strRutaServidorSQL;
            // comando.Connection = cn;
            cn.Open();

            SqlCommand comando = new SqlCommand(string.Format("Select * from USUARIOS where Usuario = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", pUsuario, pContraseña), cn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }        
            cn.Close();
            return resultado;
        }

        public static int ActualizarPass(String pUsuario, String pContraseña)
        {
            int resultado = -2;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Project_OpenBar.Ruta_Servidor.strRutaServidorSQL;
            // comando.Connection = cn;
            cn.Open();

            SqlCommand comando = new SqlCommand(string.Format("Update USUARIOS SET CONTRASEÑA =  PwdCompare('{1}') where Usuario = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", pUsuario, pContraseña), cn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            cn.Close();
            return resultado;
        }
    }
}
