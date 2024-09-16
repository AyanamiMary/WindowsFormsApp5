using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.DBCon;

namespace WindowsFormsApp5.BuilderBurger
{
    public class BurgerBuilder : IBuilderBurger
    {

        private Burgers _burger;
        public BurgerBuilder()
        {
            _burger = new Burgers();
        }

        public IBuilderBurger AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public IBuilderBurger AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public IBuilderBurger AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public IBuilderBurger AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public IBuilderBurger AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }
    }

}
