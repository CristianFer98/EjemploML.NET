﻿using AplicationMachineLearning.Service.data;
using EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationMachineLearning.Service.Interface
{
    public interface IEmailServicio
    {
        void GuardarMensaje(Mensaje mensaje);
    }
}
