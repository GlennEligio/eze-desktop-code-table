using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZECodesList.Dto
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Professor { get; set; }
        public DateTime DateReceived { get; set; }
        public string Code { get; set; }
        public bool IsSeen { get; set; }

    }
}
