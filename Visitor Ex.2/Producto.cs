
namespace PatronVisitor2Iva
{
    public abstract class Producto : IVisitable
    {
        public double Precio { get; set; }

        public abstract double Aceptar(IVisitor v);
    }
}