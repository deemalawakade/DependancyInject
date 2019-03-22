using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionById(long institutionId)
        {
            return new Institution
            {
                InstitutionId = institutionId,
                Name="Demo Institution",
                Address="Demo Address",
                Telephone="9373054744"
            
            };
        }
    }
}
