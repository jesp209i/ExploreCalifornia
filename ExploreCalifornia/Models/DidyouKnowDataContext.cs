using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class DidyouKnowDataContext
    {
        IList<DidYouKnow> dykList = new List<DidYouKnow> {
            new DidYouKnow{ Text = "California produces over 17 million gallons of wine each year!" },
            new DidYouKnow{ Text = "New random fact" },
            new DidYouKnow{ Text = "Another new random fact" },
            new DidYouKnow{ Text = "The fact here is also random" },
            new DidYouKnow{ Text = "Hiaydadadaeh!" },
            new DidYouKnow{ Text = "Chili/Hvidløg." },
            new DidYouKnow{ Text = "My momma says Im special." },
            new DidYouKnow{ Text = "yet another random fact" },
            new DidYouKnow{ Text = "Being random is a fact of life!"}
        };
        public DidYouKnow RandomFact() {
            return dykList[new Random().Next(0,dykList.Count)];
        }
    }
}
