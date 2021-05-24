namespace SingletonConsole
{
    // La clase Singleton define el método "GetInstance"
    // que sirve como alternativa al constructor y permite a los clientes acceder
    // a la misma instancia de esta clase una y otra vez.
    class Singleton
    {
        // El constructor Singleton siempre debe ser privado
        // para evitar llamadas de construcción directas con el operador `new`.
        private Singleton()
        {
        }

        // La instancia de Singleton se almacena en un campo estático.
        // Hay varias formas de inicializar este campo, todas tienen varios pros y contras.
        // En este ejemplo, mostraremos la más simple de estas formas,
        // que, sin embargo, no funcionan muy bien en programas multiproceso.
        private static Singleton instance;

        // Este es el método estático que controla el acceso a la instancia de singleton.
        // En la primera ejecución, crea un objeto singleton y lo coloca en el campo estático.
        // En ejecuciones posteriores, devuelve el objeto existente
        // del cliente almacenado en el campo estático.
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        // Finalmente, cualquier singleton debe definir alguna lógica de negocio,
        // que se puede ejecutar en su instancia.
        public static void SomeBusinessLogic()
        {
            // ...
        }
    }
}