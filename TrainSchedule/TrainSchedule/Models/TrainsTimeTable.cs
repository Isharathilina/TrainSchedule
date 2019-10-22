using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSchedule.Models
{
    class TrainsTimeTable
    {

        public string Id { get; set; }
        public string TrainName { get; set; }
        public string Station { get; set; }
        public DateTime ArriveTime { get; set; }
        public DateTime LeaveTime { get; set; }
       


    }
}
