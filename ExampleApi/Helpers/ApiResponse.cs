using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Helpers
{

    public class ApiResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
    }
    public class ApiResponse<T> : ApiResponse
    {
        public T Model { get; set; }

        public int Get(T model)
        {
            return 1;
        }
    }
}
