﻿using ReverseProxy.Store.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReverseProxy.Store.Entity
{
    public class ProxyMatch
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Only match requests that use these optional HTTP methods. E.g. GET, POST.
        /// </summary>
        public string Methods { get; set; }

        /// <summary>
        /// Only match requests with the given Host header.
        /// </summary>
        public string Hosts { get; set; }

        /// <summary>
        /// Only match requests with the given Path pattern.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Only match requests that contain all of these query parameters.
        /// </summary>
        public List<RouteQueryParameter> QueryParameters { get; set; }

        public virtual List<RouteHeader> Headers { get; set; }

        public int ProxyRouteId { get; set; }
        public virtual ProxyRoute ProxyRoute { get; set; }
    }
}
