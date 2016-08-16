using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests.Mock
{
    internal class MockTeleportStation : TeleportStation
    {
        public MockTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) : base(owner, galacticMap, location)
        {
        }
        //protected readonly IResources resources;
        //protected readonly IBusinessOwner owner;
        //protected readonly ILocation location;
        //protected readonly IEnumerable<IPath> galacticMap;

        public IResources Resources
        {
            get
            {
                return base.resources;
            }
        }

        public IEnumerable<IPath> GalacticMap
        {
            get
            {
                return base.galacticMap;
            }
        }

        public IBusinessOwner BusinessOwner
        {
            get
            {
                return this.owner;
            }
        }

        public ILocation Location
        {
            get
            {
                return this.location;
            }
        }
    }
}
