using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
        
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine("Mask was given to " + person.FirstName);
            }
            else
            {
                Console.WriteLine("Mask was not given to " + person.FirstName);
            }
           
            
        }
    }
}
