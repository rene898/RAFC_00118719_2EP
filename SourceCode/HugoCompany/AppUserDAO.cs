using System;
using System.Collections.Generic;
using System.Data;

namespace HugoCompany
{
    public class AppUserDAO
    {

        public static void iniciarSesion(string pusername)
        {
            agregarUsuario(pusername, "");
        }

        private static void agregarUsuario(string pusername, string password)
        {
            string sql = String.Format(
                "INSERT INTO appuser(username, password) VALUES ('{0}', {1});",
                pusername, password);

            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static List<AppUser> getList()
        {
            string query = "SELECT * FROM appuser";
            DataTable DT = ConnectionDB.ExecuteQuery(query);


            List<AppUser> list = new List<AppUser>();
            foreach (DataRow fila in DT.Rows)
            {
                AppUser au = new AppUser();
                au.idUser = Convert.ToInt16(fila[0].ToString());
                au.fullname = fila[1].ToString();
                au.username = fila[2].ToString();
                au.password = fila[3].ToString();
                au.userType = Convert.ToBoolean(fila[4].ToString());

                list.Add(au);
            }

            return list;
        }

        public static void actualizarContra(string username, string password)
        {
            string sql = string.Format(
                "UPDATE appuser SET password='{0}' WHERE username='{1}';",
                username, password);

            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}