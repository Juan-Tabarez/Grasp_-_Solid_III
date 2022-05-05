using System;

namespace Full_GRASP_And_SOLID.Library
{   
    /// <summary>
    /// Utilicé el principio Polimorfismo creando una interfaz IPrinter con la operación PrintRecipe la cual recibe
    /// como parametro solamente la Recipe.
    /// Luego Cree dos Clases FilePrinter y ConsolePrinter las cuales son subtipos de IPrinter y
    /// por lo tanto implementan la operacion PrintRecipe de diferente forma, una imprimiendola en consola
    /// y la otra en un archivo.txt. Por esto es que sacamos el parametro Destination, ya que no necesitamos especificarle 
    /// en donde se va a imprimir porque cada metodo lo imprime en un destino diferente para cada subtipo de IPrinter.
    /// </summary>
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}

