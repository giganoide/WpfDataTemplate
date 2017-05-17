using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataTemplateApp
{
    public class Tornio : IMacchina
    {
        public string TypeLabel => "Tornio";
        public string Prova => "Prova";
    }

    public class Fresa : IMacchina
    {
        public string TypeLabel => "Fresa";
    }

    public class Combinato : IMacchina
    {
        public string TypeLabel => "Combinato";
    }

    public interface IMacchina
    {
        string TypeLabel { get; }
    }
}
