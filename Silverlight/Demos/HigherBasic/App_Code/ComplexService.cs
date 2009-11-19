using System;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for ComplexService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class ComplexService : WebService
{
    [WebMethod]
    public Person GetPerson()
    {
        Person p = new Person();
        p.Name = "Joe";

        return p;
    }
}

[Serializable]
public class Person
{
    public string Name { get; set; }
}