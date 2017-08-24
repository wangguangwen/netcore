using System;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        /// <summary>
        /// ddddd
        /// </summary>
        public string RequestId { get; set; } 

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}