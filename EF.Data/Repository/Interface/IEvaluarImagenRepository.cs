﻿using EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Repository.Interface
{
    internal interface IEvaluarImagenRepository
    {
        void GuardarImagen(EvaluarImagen evaluarImagen);
    }
}