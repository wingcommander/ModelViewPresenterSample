using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelViewPresenterSample.ViewInterfaces;


namespace ModelViewPresenterSample.Presenters.Interfaces
{
    public interface IRoverPresenter
    {
        //void GetSeries(Guid id);
        //IContentHierarchyView ContentHierarchyView { get; set; }

        IRoverView RoverView { get; set; }
    }
}
