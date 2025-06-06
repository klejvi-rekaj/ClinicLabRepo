using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLab.Application.Models
{
    public class TestOrder
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int TestTypeId { get; set; }
        public DateTime OrderedDate { get; set; }
        public string Status { get; set; }
        public string ResultFilePath { get; set; }
    }
}
