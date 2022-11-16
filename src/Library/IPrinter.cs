
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        //debemos cambiar la firma por DIP de Recipe a IRecipe
         void PrintRecipe(IRecipe recipe);
    }
}