using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace fictionsplash.Pages
{
    public class GoshoModel : PageModel
    {
        private readonly ILogger<GoshoModel> _logger;

        public GoshoModel(ILogger<GoshoModel> logger)
        {
            _logger = logger;
        }

        public bool saveResult(int score)
        {
            return true;
        }
    }
}