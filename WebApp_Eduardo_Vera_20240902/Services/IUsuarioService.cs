﻿using WebApp_Eduardo_Vera_20240902.Models;

namespace WebApp_Eduardo_Vera_20240902.Services
{
    public interface IUsuarioService
    {
        Task<Usuario> login(Login login);

    }
}
