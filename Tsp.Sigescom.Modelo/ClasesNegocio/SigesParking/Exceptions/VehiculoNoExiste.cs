﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsp.Sigescom.Modelo.Entidades.Exceptions;

namespace Tsp.Sigescom.Modelo.Custom.SigesParking.Exceptions
{
    public class VehiculoNoExisteException: LogicaException
    {
        public string Placa { get; set; }
        public VehiculoNoExisteException (string Placa) : base(String.Format("El Vehículo con placa {0} no existe", Placa))
        {

        }
        
    }
}
