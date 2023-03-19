﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsp.Sigescom.Modelo.ClasesNegocio.Core.LibrosElectronicos.PlainModel;
using Tsp.Sigescom.Modelo.ClasesNegocio.EBookViewModel.Custom;
using Tsp.Sigescom.Modelo.Entidades;
using Tsp.Sigescom.Modelo.Entidades.Custom;

namespace Tsp.Sigescom.Modelo.Negocio.LibrosElectronicos
{
    public interface ILibrosElectronicosConcarLogica
    {
        LibroElectronicoConcar ObtenerLibrosElectronicosConcar(Periodo periodo);
    }

}
