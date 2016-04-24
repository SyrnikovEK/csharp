﻿using System;
using System.Collections.Generic;

namespace ClinicProject
{
    public class Clinic : IClinic
    {
        public decimal Balance { get; set; }
        public List<IDoctor> Doctors { get; set; }
        public List<IPatient> Patients { get; set; }

        public void AddDoctor(IDoctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddPatient(IPatient patient)
        {
            Patients.Add(patient);
        }

        public void Cure(IPatient patient, Diagnosis diagnosis, Appointment appoitment)
        {
            //return null;
        }
    }
}