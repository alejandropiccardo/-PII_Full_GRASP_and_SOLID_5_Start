using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        //por DIP cambiamos la firma Recipe a IRecipe
        public void PrintRecipe(IRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}