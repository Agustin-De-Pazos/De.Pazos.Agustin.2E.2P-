namespace Excepciones
{
    public class ArchivoInCorrectoExcepcion : Exception
    {
        public ArchivoInCorrectoExcepcion(string mensaje) : base(mensaje)
        { }
    }
}