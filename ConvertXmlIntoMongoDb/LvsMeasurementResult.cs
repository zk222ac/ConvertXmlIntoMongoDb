using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertXmlIntoMongoDb
{
    public class LvsMeasurementResult 
    {
        public string PlaceId { get; set; }
        public string Place { get; set; }
        public DateTime TimeStamp { get; set; }
        public string StuffId { get; set; }
        public string StuffName { get; set; }
        public string UnitId { get; set; }
        public string UnitValue { get; set; }
        public float Result { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        
    }
}
