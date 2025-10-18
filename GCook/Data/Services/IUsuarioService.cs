using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Data.Services;

    public interface IUsuarioService
    {
        Task<SignInResult> LoginUsuario(LoginVM login);

        Task LogoutUsuario();
    }
    
