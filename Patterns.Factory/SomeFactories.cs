using Patterns.Factory.DummyServices;
using Patterns.Factory.Lookups;
using Patterns.Factory.Models;
using Patterns.Factory.VoiceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    /*
     * 1.   a really simple factory is just a method that creates an object for you. The advantage of this is:
     *          a.  you can perform actions against the new object, or that relate to the new object that are difficult
     *              to put in the constructor. Without a factory it might be easy to forget to do these actions if you're
     *              creating the object in a lot of different places. You do all that logic a single time because 
     *              creation happens in a single place.
     *      you probably wouldn't do this for subtypes like in this example - I don't think I ever have?
     */

    internal class SuperSimpleDuckFactory
    {

        internal IDuck MakeMallard()
        {
            var duck = new Duck
            {
                Name = "Mallard",
                StarSign = StarSignService.GetStarSign(),
                Voice = new Quacker()
            };
            LakeService.NotifyOfNewDuck();
            return duck;
        }

        internal IDuck MakeRubberDuck()
        {
            var duck = new Duck
            {
                Name = "Rubber",
                StarSign = StarSignService.GetStarSign(),
                Voice = new Squeeker()
            };
            ToyShopService.UpdateInventory(duck);
            return duck;
        }

    }

    /*
     * 2.   you can have a factory that takes as input something that indicates the type of object you are trying to create
     *      the advantages you get from this are:
     *          a.  the above advantage of the creation logic happening in a single place rather than multiple places
     *          b.  your calling code doesn't need to know about the different sub types that can be created, it only needs
     *              to know about the interface/contract
     * */

    internal class SimpleDuckFactory 
    {

        internal IDuck MakeDuck(DuckType duckType)
        {
            var duck = new Duck
            {
                Name = duckType.ToString(),
                StarSign = StarSignService.GetStarSign()
            };
            if(duckType == DuckType.Rubber)
            {
                duck.Voice = new Squeeker();
                ToyShopService.UpdateInventory(duck);
            } 
            else if (duckType == DuckType.Mallard)
            {
                duck.Voice = new Quacker();
                LakeService.NotifyOfNewDuck();
            }
            return duck;
        }

    }

    /*
     * 3.   You can have multiple factories that create specific subtypes. You get the advantages of the above, but could use
     *      this when wanting to inject the factory rather than having to pass in a flag to indicate what you wanted created.
     *      Code creating the subtypes doesn't need to know about the subtypes (yay I guess).
     *      This would be a good one to use with DI provided you were always creating the same subtype at runtime?
     */

    internal abstract class DuckFactory
    {
        internal abstract IDuck MakeDuck();
    }

    internal class SomeFactories : DuckFactory
    {
        internal override IDuck MakeDuck()
        {
            var duck = new Duck
            {
                Name = "Mallard",
                Voice = new Quacker(),
                StarSign = StarSignService.GetStarSign()
            };
            LakeService.NotifyOfNewDuck();

            return duck;
        }
    }
    internal class RubberDuckFactory : DuckFactory
    {
        internal override IDuck MakeDuck()
        {
            var duck = new Duck
            {
                Name = "Rubber",
                Voice = new Squeeker(),
                StarSign = StarSignService.GetStarSign()
            };
            ToyShopService.UpdateInventory(duck);

            return duck;
        }
    }
}
