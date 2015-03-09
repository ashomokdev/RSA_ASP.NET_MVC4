using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RSA_lab_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Encrypt(string message)
        {
            Helper h = new Helper();
            StringBuilder sb = new StringBuilder();
            Random rnd1 = new Random();
            List<int> shortprimes = Helper.Primes.GetRange(20, 70);
            int p = shortprimes[rnd1.Next(shortprimes.Count)];
            System.Threading.Thread.Sleep(200);
            ViewBag.P = p;
            Random rnd2 = new Random();
            int q = shortprimes[rnd1.Next(shortprimes.Count)];
            ViewBag.Q = q;
            int n = p * q;
            ViewBag.N = n;
            int fi = (p - 1) * (q - 1);
            ViewBag.Fi = fi;
            int e = shortprimes.OrderBy(x => Guid.NewGuid()).Where(y => y < fi).FirstOrDefault();
            ViewBag.E = e;

            int d = Helper.MultiplicativeInverse(e, fi);
            ViewBag.D = d;
            
            BigInteger c = BigInteger.Pow(BigInteger.Parse(message), e) % n;
            ViewBag.C = c;

            BigInteger decryptedMessage = BigInteger.Pow(c, d) % n;
            ViewBag.message = decryptedMessage;
            return PartialView();
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}
