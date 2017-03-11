using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuonKit.W3cValidationClient;
using MuonKit.W3cValidationClient.Html;

namespace W3Cock
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new W3CValidator(new HttpClient(), new Soap12ValidationResponseParser());
            var validationReport = validator.ValidateDocument(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd""><html xmlns=""http://www.w3.org/1999/xhtml""><head><title>test</title></head><body><p>hello</p></body></html>");
            if (validationReport.Validity)
            {
                Console.WriteLine("YAY!");
            }
            else
                Console.WriteLine("NAY.");
        }
    }
}
