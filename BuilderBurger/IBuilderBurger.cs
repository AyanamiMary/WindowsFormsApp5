using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.DBCon;

namespace WindowsFormsApp5.BuilderBurger
{
    public interface IBuilderBurger
    {
        IBuilderBurger AddCheese();
        IBuilderBurger AddBacon();
        IBuilderBurger AddLetuce();
        IBuilderBurger AddTomato();
        IBuilderBurger AddPickles();
        Burgers GetBurgers();
    }
}
