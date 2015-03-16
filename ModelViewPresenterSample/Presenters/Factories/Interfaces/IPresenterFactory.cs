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
using ModelViewPresenterSample.ViewInterfaces;
using ModelViewPresenterSample.Presenters.Interfaces;

namespace ModelViewPresenterSample.Presenters.Factories.Interfaces
{
    public interface IPresenterFactory
    {
        //IContentSearchPresenter GetPresenter(IContentSearchView view);
        //IContentHierarchyPresenter GetPresenter(IContentHierarchyView view);
        //IRightsSummaryPresenter GetPresenter(IRightsSummaryView view);
        //IRightsDetailPresenter GetPresenter(IRightsDetailView view);
        IRoverPresenter GetPresenter(IRoverView view);

    }
}
