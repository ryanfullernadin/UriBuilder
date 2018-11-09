using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

/*
 * Created:- 22/10/2018
 * Arguments needed:- requires the full Url string to be passed to it including dynamic parameters which the program then loops 
   through concatinates and re-direct you to that specified URL
 * Example:- filepath to the exe file plus all the additional parameters are needed for this URL, each space separates each argument and 
   in the cases where an '&' needs to be passed through a double '&&' must be specified when passed from IFS (google maps example below)
 * C:\UriBuilder\UriBuilder\bin\Debug\UriBuilder.exe https://maps.google.com/?q= &CF$_LATITUDE , &CF$_LONGITUDE &&ll= &CF$_LATITUDE , 
   &CF$_LONGITUDE &&z=10 
  */
namespace UriBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
               string longurl = string.Empty;

               foreach (string item in args)
               {
                    longurl += item;
               }

               var uriBuilder = new System.UriBuilder(longurl);
               System.Diagnostics.Process.Start(longurl);
        }
    }
}
