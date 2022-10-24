using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_MVCWeb.ViewModels
{
    public class EditAcc
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string OldPass { get; set; }

        public string NewPass { get; set; }
    }
}
