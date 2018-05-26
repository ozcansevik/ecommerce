
using Modele.MonProjet.Configuration;

namespace Modele.Console.Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Contexte();
            a.Clients.tolist();
        }
    }
}
