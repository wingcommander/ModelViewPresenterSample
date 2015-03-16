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
using ModelViewPresenterSample.Presenters.Interfaces;
using ModelViewPresenterSample.ViewInterfaces;
using Entities;

namespace ModelViewPresenterSample.Presenters
{
    public class RoverPresenter : IRoverPresenter
    {
      
        private IRoverView roverView;

        public IRoverView RoverView
        {
            // constructor            
            set { this.roverView = value ;
                this.Initialize();
            }

            get { return this.roverView; }       
        }

        public void Initialize()
        {
            //SubscribeViewToEvents();
        }

       
        public RoverPresenter(IRoverView roverView)
        {
            this.RoverView = roverView;
         
        }              

        public void PageLoad(object sender, EventArgs e)
        {
           
        }

        private void SubscribeViewToEvents()
        {
            //RightsDetailView.SaveRights += new EventHandler(SaveRights);
            //RightsDetailView.LoadPage += new EventHandler(RightsDetailView_LoadPage);
            //RightsDetailView.CancelPage += new EventHandler(RightsDetailView_CancelPage);
            //RightsDetailView.SynchroniseRights += new EventHandler(RightsDetailView_SynchroniseRights);

            RoverView.Explore += new EventHandler(Explore);
        }

        public void Explore(Movement movement)
        {
            switch (Convert.ToInt32(movement.Direction))
            {
                case (Int32)MovementEnum.M:

                    switch (Convert.ToInt32(this.position.Orientation))
                    {
                        case (Int32)CompassPointEnum.W:
                            this.Position.Coordinate.X--;
                            break;

                        case (Int32)CompassPointEnum.N:
                            this.Position.Coordinate.Y++;
                            break;

                        case (Int32)CompassPointEnum.E:
                            this.Position.Coordinate.X++;
                            break;

                        case (Int32)CompassPointEnum.S:
                            this.Position.Coordinate.Y--;
                            break;
                    }

                    break;

                // Moving counter clockwise
                case (Int32)MovementEnum.L:

                    if (this.position.Orientation == CompassPointEnum.N)
                    {
                        this.position.Orientation = CompassPointEnum.W;
                    }
                    else
                    {
                        this.position.Orientation--;
                    }

                    break;

                // Moving clockwise
                case (Int32)MovementEnum.R:

                    if (this.position.Orientation == CompassPointEnum.W)
                    {
                        this.position.Orientation = CompassPointEnum.N;
                    }
                    else
                    {
                        this.position.Orientation++;
                    }

                    break;
            }
       } 

        //public void GetSeries(Guid seriesId)
        //{
        //    try
        //    {
        //        Series series = ContentSearchService.SearchContentById(seriesId) as Series;
        //        ContentHierarchyView.ThisSeries = series;
        //        if (series.Episodes != null)
        //        {
        //            List<Episode> displayEpisodeList = GetSortedEpisodeList(series.Episodes);
        //            ContentHierarchyView.EpisodeList = displayEpisodeList;
        //        }
        //        else
        //        {
        //            ContentHierarchyView.EpisodeList = null;
        //        }
        //        ContentHierarchyView.Display();
        //    }
        //    catch (Exception ex)
        //    {
        //        ContentHierarchyView.ShowMessage(ex.ToString());
        //    }
        //}

    
    }

}
