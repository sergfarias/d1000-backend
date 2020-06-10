using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Application
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            this.AllowNullCollections = true;

            Conversores.Configuracao.Registrar(this);

        }
    }
}
