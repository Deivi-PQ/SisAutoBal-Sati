using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Models
{
    public partial class LoginDominio
    {
        /*public bool SonDatos_Correctos()
        {
            UsuarioFacade faUsuario = new UsuarioFacade();
            CUsuario oUsuario;

            // --- Verificando si existe el usuario
            if (faUsuario.Existe(tbUsuario.Text, out oUsuario))
            {
                // --- Verificar si el logue es por el Active Directory
                if (oUsuario.flagActDir)
                {
                    // --- Verificamos usuario en el dominio
                    string Error;
                    if (LComun.ValidarUsuarioDominio(DomainController, tbUsuario.Text, tbContrasenia.Text, out Error))
                    {
                        return true;
                    }
                    else
                    {
                        laMensaje.Text = "Usuario o contraseña incorrecta.";
                        tbUsuario.Focus();
                        return false;
                    }
                }
                else
                {
                    // --- Verificamos usuario con su clave 
                    if (LComun.EncriptarMD5(tbContrasenia.Text) == oUsuario.Passwd)
                    {
                        laMensaje.Text = "";
                        return true;
                    }
                    else
                    {
                        laMensaje.Text = "Usuario o contraseña incorrecta.";
                        tbUsuario.Focus();
                        return false;
                    }
                }
            }
            else
            {
                laMensaje.Text = "Usuario o contraseña incorrecta.";
                tbUsuario.Focus();
                return false;
            }
        }*/
    }
}
