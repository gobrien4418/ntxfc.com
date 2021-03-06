//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FlyingClub.Data.Model
{
    public partial class aircraftimage
    {
        #region Primitive Properties
    
        public virtual long Id
        {
            get;
            set;
        }
    
        public virtual long AircraftId
        {
            get { return _aircraftId; }
            set
            {
                if (_aircraftId != value)
                {
                    if (aircraft != null && aircraft.Id != value)
                    {
                        aircraft = null;
                    }
                    _aircraftId = value;
                }
            }
        }
        private long _aircraftId;
    
        public virtual string ImageType
        {
            get;
            set;
        }
    
        public virtual string Url
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual aircraft aircraft
        {
            get { return _aircraft; }
            set
            {
                if (!ReferenceEquals(_aircraft, value))
                {
                    var previousValue = _aircraft;
                    _aircraft = value;
                    Fixupaircraft(previousValue);
                }
            }
        }
        private aircraft _aircraft;

        #endregion
        #region Association Fixup
    
        private void Fixupaircraft(aircraft previousValue)
        {
            if (previousValue != null && previousValue.aircraftimages.Contains(this))
            {
                previousValue.aircraftimages.Remove(this);
            }
    
            if (aircraft != null)
            {
                if (!aircraft.aircraftimages.Contains(this))
                {
                    aircraft.aircraftimages.Add(this);
                }
                if (AircraftId != aircraft.Id)
                {
                    AircraftId = aircraft.Id;
                }
            }
        }

        #endregion
    }
}
