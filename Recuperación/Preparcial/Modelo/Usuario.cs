namespace Preparcial.Modelo
{
    public class Usuario
    {
        public string IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public bool Admin { get; set; }

        
        public Usuario(string idUsuario, string nombre, string contrasenia, bool admin)
        {
            IdUsuario = idUsuario;
            //cambio de nombreUsuario a nombre
            NombreUsuario = nombre;
            Contrasena = contrasenia;
            Admin = admin;
        }
    }
}
