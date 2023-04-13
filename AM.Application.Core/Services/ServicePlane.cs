﻿using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Passenger> GetPassenger(Plane plane) { 
        return GetById(plane.PlaneId).Flights.SelectMany(f=>f.Passengers).ToList();
                }
    }
}