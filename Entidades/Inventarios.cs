namespace Tipos_de_Inventarios.Entidades
{
    public class Inventarios
    {
        public string Fecha { get; set; }
        public int Cuenta { get; set; }
        public string Detalle { get; set; }
        public int Auxiliar { get; set; }
        public int Debito { get; set; }
        public int Credito { get; set; }

        public Inventarios(string fecha, int cuenta, string detalle, int auxiliar, int debito, int credito)
        {
            this.Fecha = fecha;
            this.Cuenta = cuenta;
            this.Detalle = detalle;
            this.Auxiliar = auxiliar;
            this.Debito = debito;
            this.Credito = credito;
        }
    }
}
