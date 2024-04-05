using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
   
    public void IAApplyForMask(Person person)
    {
        return null;
    }

    public List<Person>GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirth)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }

    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }
}
