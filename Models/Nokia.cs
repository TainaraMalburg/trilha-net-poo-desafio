namespace DesafioPOO.Models
{
    public class Nokia : Smartphone 
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string WhatsApp)
       
    {
        Console.WriteLine("Instalando o aplicativo " + WhatsApp + " no Nokia");
    }
    }
}


