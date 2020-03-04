﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface IUsuarioService
    {
        Task Create(UsuarioDTO usuario);
        Task<UsuarioDTO> Authenticate(string email, string password);
    }
}
