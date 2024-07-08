using System;
namespace VickiModisette.Controllers
{
	public class ClientController
	{
        private readonly ContactContext _context;

        public ClientController(ContactContext context)
        {
            _context = context;
        }
    }
}

