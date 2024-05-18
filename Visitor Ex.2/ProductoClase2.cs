
namespace PatronVisitor2Iva
{
    public class ProductoClase2 : Producto
    {
        public override double Aceptar(IVisitor v)
        {
            return v.Visitar(this);
        }
    }
}