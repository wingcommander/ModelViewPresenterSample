using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ModelViewPresenterSample.Presenters.Factories.Interfaces;
using ModelViewPresenterSample.ViewInterfaces;
using ModelViewPresenterSample.Presenters.Interfaces;

namespace ModelViewPresenterSample.Presenters.Factories

{
    public class PresenterFactory : IPresenterFactory
    {
        public IRoverPresenter GetPresenter(IRoverView view)
        {
            return new RoverPresenter(view);
        }     
    }
}
