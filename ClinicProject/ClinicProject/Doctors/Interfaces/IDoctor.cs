using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public interface IDoctor
    {
        Diagnosis Diagnosticate(Complaint complaint);
        Appointment PrescribeAppointment(Diagnosis diagnosis);
    }
}
