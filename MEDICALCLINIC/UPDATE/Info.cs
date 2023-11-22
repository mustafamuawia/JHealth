using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDICALCLINIC.UPDATE
{
public enum Typeupate{
Normal,
critical,
Recommanded
}
    class Info
    {
        public string Version { get; set; }
        public string VersionText { get; set; }
        public string Description { get; set; }
        public Typeupate Typeupates { get; set; }
    }
}
