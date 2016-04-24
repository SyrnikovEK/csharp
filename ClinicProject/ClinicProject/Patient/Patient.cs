using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public class Patient : Human , IPatient
    {
        public Complaint PatientComplaint { get; set; }
    }
}
