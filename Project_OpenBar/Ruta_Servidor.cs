using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OpenBar
{
    class Ruta_Servidor
    {
        //RUTA Servidor SQL Notebook BP:
        //public static string strRutaServidor = "Data Source=SV001\\;Initial Catalog=Decom_V8;Persist Security Info=True;User ID=sa;Password=Admin48471283";
        //public static string
        //   strRutaServidorSQL = "Data Source=BP-NBK-35;Initial Catalog=OpenBar;Persist Security Info=True;User ID=sa;Password=1234";

        //----------------------------------------------------------------------------------------------
        //RUTA Servidor SQL PC MATIAS:
        // - OLD - public static string strRutaServidor = "Data Source=SV001\\;Initial Catalog=Decom_V8;Persist Security Info=True;User ID=sa;Password=Admin48471283";

        public static string 
        strRutaServidorSQL = "Data Source=DESKTOP-MATIAS\\SQLPRUEBA;Initial Catalog=OpenBar;Persist Security Info=True;User ID=sa;Password=1234";
        
         //  strRutaServidorSQL = "Data Source=NBMATIAS;Initial Catalog=OpenBar;Persist Security Info=True;User ID=sa;Password=1234";

        //----------------------------------------------------------------------------------------------
        //RUTA MATIAS ACCESS 2007 o Superior:
        //public static string 
        //    strRutaServidor = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\SIGESoftware\\Sgiw8.accdb;Jet OLEDB:Database Password=";
         
        // CONEXION ACCESS
        //return  ConfigurationManager.ConnectionStrings["CONEXIONACCESS"].ConnectionString;

    }
}
