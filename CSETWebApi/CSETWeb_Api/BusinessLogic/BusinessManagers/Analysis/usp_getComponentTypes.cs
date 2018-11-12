//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
namespace CSETWeb_Api.Controllers
{
    public class usp_getComponentTypes
    {
        public int? Assessment_Id { get; set; }
        public string component_type { get; set; }
        public int? Total { get; set; }
        public int? Y { get; set; }
        public int? N { get; set; }
        public int? NA { get; set; }
        public int? A { get; set; }
        public int? U { get; set; }
        public  double? Value { get; set; }
        public int? TotalNoNA { get; set; }
    }
}

