using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public abstract class AbstractDoctor : Human , IDoctor
    {
        public virtual Diagnosis Diagnosticate(Complaint complaint)
        {
            return new Diagnosis();
        }      
        public virtual Appointment PrescribeAppointment(Diagnosis diagnosis)
        {
            return new Appointment();
        }
    }
}
