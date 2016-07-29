using Nancy;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/result"] = _ => {
        RepeatCounter newWord = new RepeatCounter ( Request.Form["new-word"], Request.Form["new-sentence"]);
        return View["result.cshtml", newWord];
      };

    }


  }

}
