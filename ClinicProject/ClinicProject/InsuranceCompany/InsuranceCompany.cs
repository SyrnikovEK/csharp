using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public class InsuranceCompany : IInsuranceCompany
    {
        public List<InsuranceAccount> Clients { get; }
        public static event PayBillEvent BillIsPayed;

        public void AddClient(InsuranceAccount client)
        {
            Clients.Add(client);
        }

        public void PayBill(InsuranceAccount client , Bill bill)
        {
            //if (bill.Sum <= client.Balance)
            //{
            //    clinic.Balance += bill.Sum;
            //    client.Balance -= bill.Sum;
            //    bill.IsPayed = true;
            //    BillIsPayed.Invoke(client);
            //}
            //else
            //{
            //    bill.IsPayed = false;
            //}
            BillIsPayed.Invoke(client);
        }
    }
}
