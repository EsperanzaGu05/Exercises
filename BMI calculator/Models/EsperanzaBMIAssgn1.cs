namespace EsperanzaAssgn1.Models
{
    public class EsperanzaBMIAssgn1
    {
        public decimal Weight844 { get; set; }
        public decimal Height844 { get; set; }
        public decimal CalculateBMI() {

            decimal bodyMassIndex844 = Weight844 / (Height844 * Height844) * 703;
            return bodyMassIndex844;
        }
    }
}
