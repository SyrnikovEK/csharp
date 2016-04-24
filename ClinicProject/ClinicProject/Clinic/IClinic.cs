using System.Collections.Generic;

namespace ClinicProject
{
    public interface IClinic
    {
        decimal Balance { get; set; }
        List<IDoctor> Doctors { get; set; }
        List<IPatient> Patients { get; set; }

        void AddDoctor(IDoctor doctor);
        void AddPatient(IPatient patient);

        IDoctor GiveDoctor(IPatient patient);
        Bill GiveBill(Appointment appoitment);
        void Cure(IPatient patient , Diagnosis diagnosis , Appointment appoitment);
    }
}