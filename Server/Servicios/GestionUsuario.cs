using CRUD_Blazor.Server.Modelos;
using CRUD_Blazor.Shared;

namespace CRUD_Blazor.Server.Servicios
{
    public class GestionUsuario : IUsuario
    {
        readonly CRUD_BlazorContext dbContext = new();

        public GestionUsuario(CRUD_BlazorContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Usuario DatosUsuario(int id)
        {
            try
            {
                Usuario? usuario = dbContext.Usuarios.Find(id);
                if(usuario != null)
                {
                    return usuario;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                dbContext.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public List<Usuario> DatosUsuarios()
        {
            try
            {
                return dbContext.Usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void EliminarUsuario(int id)
        {
            try
            {
                Usuario? usuario = dbContext.Usuarios.Find(id);
                if(usuario != null)
                {
                    dbContext.Remove(usuario);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void NuevoUsuario(Usuario usuario)
        {
            try
            {
                usuario.FechaAlta = DateTime.Now;
                dbContext.Usuarios.Add(usuario);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    }
}
