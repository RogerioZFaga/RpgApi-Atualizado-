using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RpgApi.Extensions
{
    public static class ClaimTypesExtension
    {
        public static int UsuarioId(this ClaimsPrincipal user)
        {
            try
            {
                var UsuarioId = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                return int.Parse(UsuarioId);
            }
            catch
            {
                return 0;
            }
        }
    }
}