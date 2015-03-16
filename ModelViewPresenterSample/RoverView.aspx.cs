using System;
using System.Collections;
using System.Configuration;
using System.Data;
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
using ModelViewPresenterSample.Presenters.Factories.Interfaces;
using Entities;
using ModelViewPresenterSample.Presenters.Factories;

namespace ModelViewPresenterSample
{
    public partial class RoverView : System.Web.UI.Page, IRoverView
    {
        private Rover thisRover;
        private IRoverPresenter presenter;
        private IPresenterFactory presenterFactory;
    

        public event EventHandler Explore;




        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            presenter = this.PresenterFactory.GetPresenter(this);
           
        }

        public Rover ThisRover
        {
            get { return thisRover; }
            set { thisRover = value;
                
            }
        }

        public IRoverPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = this.PresenterFactory.GetPresenter(this);
                }

                return presenter;
            }
            set { presenter = value; }
        }

        public IPresenterFactory PresenterFactory
        {
            get
            {
                if (presenterFactory == null)
                {
                    presenterFactory = new PresenterFactory();

                }
                return presenterFactory;

            }
            set { presenterFactory = value; }
        }

    }

     
}
