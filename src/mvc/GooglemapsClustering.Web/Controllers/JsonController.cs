﻿using System;
using System.Web.Mvc;
using GooglemapsClustering.Clustering.Contract;
using GooglemapsClustering.Clustering.Data.Json;

namespace GooglemapsClustering.Web.Controllers
{
    public class JsonController : BaseController
    {
        private readonly IMapService _mapService; // Clustering API
				
		public JsonController()
		{
			throw new Exception("IoC error");
		}

		/// <summary>
		/// IoC
		/// </summary>
		/// <param name="mapService"></param>
		public JsonController(IMapService mapService)
		{
			_mapService = mapService;
		}

		public ContentResult Index()
        {
			return JsonDefault("json service");
        }

        public ContentResult GetMarkers(JsonGetMarkersInput input)
        {
            return JsonMin(_mapService.GetMarkers(input));
        }

        public ContentResult GetMarkerInfo(string id)
        {            
            return JsonMin(_mapService.GetMarkerInfo(id));
        }

        public ContentResult Info(string id)
        {            
            return JsonMin(_mapService.Info());
        }
    }
}
