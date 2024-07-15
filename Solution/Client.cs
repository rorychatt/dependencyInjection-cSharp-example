using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution;

public class Client : IClient
{
    private readonly IService _service;

    public Client(IService service)
    {
        _service = service;
    }
    public void Start()
    {
        _service.Serve();
    }
}
