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
    public class MainGroceyController : ApiController
    {
        private DataContext dbcontext = new DataContext();
        
        // GET api/values
        /// <summary>
        /// Return All list on Grocey
        /// </summary>
        /// <returns></returns>
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

        // GET api/values/{Guid}
        /// <summary>
        /// Return the Grocey List By Id
        /// </summary>
        /// <param name="id">GUID</param>
        /// <returns></returns>
        public string Get(Guid id)
        {
            IList<GroceyMain> mainViewModel = new List<GroceyMain>();
            var results = dbcontext.masterList.Find(id);
            Mapper.CreateMap<MasterListModel, GroceyMain>();
         
            GroceyMain groceyViewModel = Mapper.Map<MasterListModel, GroceyMain>(results);
            mainViewModel.Add(groceyViewModel);
            return JsonConvert.SerializeObject(mainViewModel);
        }

        /// <summary>
        /// Return the Grocey List By part of the name
        /// </summary>
        /// <param name="name">part of grocey title</param>
        /// <returns></returns>
        public string Get(string name)
        {
            IList<GroceyMain> mainViewModel = new List<GroceyMain>();
            var results = from d in dbcontext.masterList
                          where d.ListName.Contains(name)
                          select d;
            Mapper.CreateMap<MasterListModel, GroceyMain>();
            foreach (var result in results)
            {
                GroceyMain groceyViewModel = Mapper.Map<MasterListModel, GroceyMain>(result);
                mainViewModel.Add(groceyViewModel);
            }
            
            return JsonConvert.SerializeObject(mainViewModel);
        }

        
    }
}
