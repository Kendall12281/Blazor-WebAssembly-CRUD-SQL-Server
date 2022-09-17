using CRUD_Blazor.Shared;

namespace CRUD_Blazor.Server.Servicios
{
    public interface IUsuario
    {
        public List<Usuario> DatosUsuarios();
        public void NuevoUsuario(Usuario usuario);
        public void ActualizarUsuario(Usuario usuario);
        public Usuario DatosUsuario(int id);
        public void EliminarUsuario(int id);


    }
}
