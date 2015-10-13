using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using GroceyWebApp.Models;
using GroceyWebApp.ViewModels;

using Newtonsoft.Json;

using AutoMapper;

namespace GroceyWebApp.Controllers
{
    public class ValuesController : ApiController
    {
        private DataContext dbcontext = new DataContext();
        // GET api/values
        public string Get()
        {
            IList<GroceyMain> mainViewModel = new List<GroceyMain>();
            var results = dbcontext.masterList.ToList();
            Mapper.CreateMap<MasterListModel, GroceyMain>();
            foreach (var result in results)
            {
                GroceyMain groceyViewModel = Mapper.Map<MasterListModel, GroceyMain>(result);
                mainViewModel.Add(groceyViewModel);
            }
            return JsonConvert.SerializeObject(mainViewModel);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}