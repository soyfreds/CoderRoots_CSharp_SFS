
namespace PatronVisitor2Iva
{
    public interface IVisitor
    {
        double Visitar(ProductoClase1 p);
        double Visitar(ProductoClase2 p);
    }
}