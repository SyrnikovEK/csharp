using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public class InsuranceCompany : IInsuranceCompany
    {
        public List<InsuranceAccount> Clients { get; set; }

        public void AddClient(InsuranceAccount client)
        {

        }

        public void PayBill(IClinic clinic , InsuranceAccount client)
        {

        }
    }
}
