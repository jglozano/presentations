using System;
using System.EnterpriseServices;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using TranServices;

[WebService(Namespace = "http://demows.lozanotek.com", 
    Description="Demo web service used to show transaction support with Enterprise Services")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service() { }

    [WebMethod(TransactionOption = TransactionOption.Required, 
        Description="Gets the current transaction id for this request.")]
    public TranResult GetTransactionId()
    {
        TranResult result = new TranResult();
        result.WebServiceTranId = ContextUtil.TransactionId.ToString();

        ITransactionalDateService svc = new TransactionService();
        result.ComponentTranId = svc.GetTransactionId();

        return result;
    }

    [WebMethod(TransactionOption = TransactionOption.Required,
        Description = "Gets a DateTime object from a transactional component.")]
    public DateTime GetDateTime()
    {
        ITransactionalDateService svc = new TransactionService();
        DateTime dt = svc.GetDateTime();

        return dt;
    }
}

public class TranResult
{
    public string WebServiceTranId;
    public string ComponentTranId;
}