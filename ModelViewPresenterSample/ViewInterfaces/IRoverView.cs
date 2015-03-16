using System;
using Entities;

namespace ModelViewPresenterSample.ViewInterfaces
{
    public interface IRoverView
    {
        Rover ThisRover { get; set; }
        event EventHandler<Movement> Explore;
    }
}
