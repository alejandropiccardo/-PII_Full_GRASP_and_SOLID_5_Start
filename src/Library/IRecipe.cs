//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    //Por DIP , creamos una interfaz de recipe de la cual los printer dependerán, en vez de depender directamente de Recipe
    public interface IRecipe
    {
        string GetTextToPrint();
        //como lo usaremos solo para imprimir,(en este caso) solo usaremos la firma del método imprimir.
    }
}