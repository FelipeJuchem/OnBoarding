﻿using OnBoarding.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IEmpresaConsulta
    {
        EmpresaDto ObterPorId(int id);

        List<EmpresaDto> Obter();
    }
}
