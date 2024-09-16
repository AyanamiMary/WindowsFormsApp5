using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBuilderBurger _builder;

        public BurgerDirector(IBuilderBurger builder)
        {
        _builder = builder;
        }
        public void BuildDefault()
        {
            _builder
            .AddCheese()
            .AddTomato()
            .AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
            .AddTomato()
            .AddBacon()
            .AddTomato();
        }
    }
}
