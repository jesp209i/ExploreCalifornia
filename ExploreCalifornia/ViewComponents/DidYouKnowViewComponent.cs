using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent]
    public class DidYouKnowViewComponent : ViewComponent
    {
        private readonly DidyouKnowDataContext _didYouKnowDataContext;

        public DidYouKnowViewComponent(DidyouKnowDataContext dykDataContext)
        {
            _didYouKnowDataContext = dykDataContext;
        }
        public IViewComponentResult Invoke()
        {
            return View(_didYouKnowDataContext.RandomFact());
        }
    }
}
